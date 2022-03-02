using System.Collections.Generic;
using Connection.Base;
using Models.Common;

namespace Connection.Interfaces.Common
{
    /// <summary>
    /// DAO del objeto Categoría.
    /// </summary>
    public interface ICategoriaDao : IDao<Categoria>
    {
        /// <summary>
        /// Método encargado de realizar la búsqueda de registros de tipo
        /// Categoría en base al nombre proporcionado.
        /// </summary>
        /// <param name="nombre">Nombre de la categoría.</param>
        /// <returns>Colección de objetos de tipo Categoría que coincidan con la búsqueda.</returns>
        IEnumerable<Categoria> Read(string nombre);

        /// <summary>
        /// Método encargado de realizar la búsqueda de registros de tipo
        /// Categoría en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único de la categoría.</param>
        /// <returns>Objeto de tipo Categoría que coincida con el parámetro de búsqueda.</returns>
        Categoria GetById(int id);
    }
}
