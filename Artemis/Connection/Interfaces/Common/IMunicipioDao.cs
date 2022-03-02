using System.Collections.Generic;
using Connection.Base;
using Models.Common;

namespace Connection.Interfaces.Common
{
    /// <summary>
    /// DAO del objeto Municipio.
    /// </summary>
    public interface IMunicipioDao : IDao<Municipio>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Municipio
        /// en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del municipio.</param>
        /// <returns>Objeto de tipo Municipio que coincida con el parámetro de búsqueda.</returns>
        Municipio GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Municipio
        /// en base al nombre proporcionado.
        /// </summary>
        /// <param name="nombre">Nombre del municipio.</param>
        /// <returns>Colección de objetos de tipo Municipio que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Municipio> Read(string nombre);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Municipio
        /// en base al ID del Departamento proporcionado.
        /// </summary>
        /// <param name="idDepartamento">Identificador único del departamento.</param>
        /// <returns>Colección de objetos de tipo Departamento que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Municipio> GetByIdDepartamento(int idDepartamento);
    }
}
