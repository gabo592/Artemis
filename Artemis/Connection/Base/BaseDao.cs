using System.Collections.Generic;
using Common.Util;

namespace Connection.Base
{
    /// <summary>
    /// Clase encargada de la implementación base del acceso a un objeto.
    /// </summary>
    /// <typeparam name="TModel">Tipo de modelo a implementar.</typeparam>
    internal abstract class BaseDao<TModel> : IDao<TModel> where TModel : new()
    {
        /// <summary>
        /// Objeto de la clase Database.
        /// </summary>
        private readonly Database Database;

        /// <summary>
        /// Constructor de la clase. Toma en cuenta la cadena de conexión a la base de
        /// datos y una instancia del administrador de errores.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión.</param>
        /// <param name="handler">Administrador de errores.</param>
        public BaseDao(string connectionString, ErrorHandler handler)
        {
            Database = new Database(connectionString, handler);
        }

        /// <inheritdoc cref="IDao{TModel}.Create(TModel)"/>
        public abstract TModel Create(TModel model);

        /// <inheritdoc cref="IDao{TModel}.Delete(TModel)"/>
        public abstract TModel Delete(TModel model);

        /// <inheritdoc cref="IDao{TModel}.Read"/>
        public abstract IEnumerable<TModel> Read();

        /// <inheritdoc cref="IDao{TModel}.Update(TModel)"/>
        public abstract TModel Update(TModel model);

        /// <inheritdoc cref="Database.Read{TModel}(string, IDictionary{string, object})"/>
        public IEnumerable<TModel> Read(string procedure, IDictionary<string, object> parameters = null) => Database.Read<TModel>(procedure, parameters);
    }
}
