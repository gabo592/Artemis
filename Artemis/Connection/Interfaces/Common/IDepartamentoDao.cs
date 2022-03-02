using System.Collections.Generic;
using Connection.Base;
using Models.Common;

namespace Connection.Interfaces.Common
{
    /// <summary>
    /// DAO del objeto Departamento.
    /// </summary>
    public interface IDepartamentoDao : IDao<Departamento>
    {
        /// <summary>
        /// Realiza la búsqueda de los registros de tipo Categoría
        /// en base al nombre proporcionado.
        /// </summary>
        /// <param name="nombre">Nombre del departamento.</param>
        /// <returns>Colección de objetos de tipo Departamento que coincidan con la búsqueda.</returns>
        IEnumerable<Departamento> Read(string nombre);

        /// <summary>
        /// Realiza la búsqueda de los registros de tipo Categoría
        /// en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del departamento.</param>
        /// <returns>Objeto de tipo Departamento que coincida con el parámetro de búsqueda.</returns>
        Departamento GetById(int id);
    }
}
