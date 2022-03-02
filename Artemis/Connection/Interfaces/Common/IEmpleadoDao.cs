using System.Collections.Generic;
using Connection.Base;
using Models.Common;

namespace Connection.Interfaces.Common
{
    /// <summary>
    /// DAO del objeto Empleado.
    /// </summary>
    public interface IEmpleadoDao : IDao<Empleado>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Empleado
        /// en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del Empleado.</param>
        /// <returns>Objeto de tipo Empleado que coincida con el parámetro de búsqueda.</returns>
        Empleado GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Empleado
        /// en base al valor proporcionado. Puede ser por nombres,
        /// apellidos, correo, cédula, etc.
        /// </summary>
        /// <param name="value">Valor a filtrar.</param>
        /// <returns>Colección de objetos de tipo Empleado que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Empleado> Read(string value);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Empleado
        /// en base al ID del municipio proporcionado.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del municipio.</param>
        /// <returns>Colección de objetos de tipo Municipio que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Empleado> GetByIdMunicipio(int idMunicipio);
    }
}
