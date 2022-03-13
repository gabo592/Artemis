using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using Common.Util;

namespace Connection
{
    /// <summary>
    /// Clase encargada de hacer comunicarse con la base de datos y
    /// realizar los procedimientos almacenados. Esta clase no puede heredarse.
    /// </summary>
    internal sealed class Database
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// Cadena de conexión a la base de datos.
        /// </summary>
        private readonly string ConnectionString;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor de la clase Database. Toma como parámetro la cadena de conexión y una instancia
        /// del administrador de errores.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión.</param>
        /// <param name="handler">Administrador de errores.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la cadena de conexión no es especificada.</exception>
        public Database(string connectionString, ErrorHandler handler)
        {
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException(nameof(connectionString), "La cadena de conexión no puede estar vacía.");

            ConnectionString = connectionString;
            Handler = handler;
        }

        #endregion

        /// <summary>
        /// Método encargado de realizar lectura y ejecución de un procedimiento almacenado
        /// tomando en cuenta el nombre del procedimiento y una colección de valores.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo resultante de la ejecución del procedimiento.</typeparam>
        /// <param name="procedure">Nombre del procedimiento almacenado.</param>
        /// <param name="parameters">Colección genérica de pares clave-valor que conforman los parámetros del procedimiento.</param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException">Se dispara cuando el nombre del procedimiento almacenado no se especifica.</exception>
        /// <exception cref="ArgumentException">Se dispara cuando no se logra establecer la conexión.</exception>
        public IEnumerable<TModel> Read<TModel>(string procedure, IDictionary<string, object> parameters) where TModel : new()
        {
            if (string.IsNullOrEmpty(procedure)) throw new NullReferenceException("El nombre del procedimiento almacenado no puede estar vacío.");

            if (parameters is null) parameters = new Dictionary<string, object>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    throw new ArgumentException("No se logró establecer la conexión.");
                }

                using (SqlCommand command = new SqlCommand(procedure, connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 20
                })
                {
                    SqlCommandBuilder.DeriveParameters(command);

                    foreach (SqlParameter parameter in command.Parameters)
                    {
                        parameters.TryGetValue(RemueveSigno(parameter.ParameterName), out object value);
                        parameter.Value = value is null ? DBNull.Value : value;
                    }

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        return MapTopObject<TModel>(reader).ToArray();
                    }
                    catch (Exception ex)
                    {
                        Handler.Add(ex);
                        return Enumerable.Empty<TModel>();
                    }
                }
            }
        }

        #region Private Methods

        /// <summary>
        /// Método encargado de realizar el mapping de un objeto como resultado de la ejecución
        /// de un procedimiento almacenado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a realizar el mapping.</typeparam>
        /// <param name="reader">Letor de registros.</param>
        /// <returns>Colección de modelos del tipo especificado como resultado de la ejecución del procedimiento almacenado.</returns>
        private IEnumerable<TModel> MapTopObject<TModel>(IDataReader reader) where TModel : new()
        {
            Type type = typeof(TModel);

            while (reader.Read())
            {
                TModel model = new TModel();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string name = reader.GetName(i);
                    PropertyInfo property = type.GetProperty(name);

                    if (property is null) continue;

                    object value = reader.IsDBNull(i) ? null : reader.GetValue(i);

                    if (value is decimal && property.PropertyType == typeof(double)) value = Convert.ToDouble(value);

                    if (value is double && property.PropertyType == typeof(decimal)) value = Convert.ToDecimal(value);

                    if (value is byte[] && property.PropertyType == typeof(string)) value = string.Empty;

                    property.SetValue(model, value);
                }

                yield return model;
            }
        }


        /// <summary>
        /// Remueve el primer caracter de una cadena, suponiendo que es un arroba.
        /// </summary>
        /// <param name="value">Cadena de texto a modificar.</param>
        /// <returns>Cadena de texto modificada sin el primer caracter.</returns>
        private string RemueveSigno(string value) => value.Substring(1);

        #endregion
    }
}
