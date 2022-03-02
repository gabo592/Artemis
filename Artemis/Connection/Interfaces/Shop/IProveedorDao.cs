using System.Collections.Generic;
using Connection.Base;
using Models.Shop;

namespace Connection.Interfaces.Shop
{
    /// <summary>
    /// DAO del objeto Proveedor
    /// </summary>
    public interface IProveedorDao : IDao<Proveedor>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Proveedor en
        /// base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del proveedor.</param>
        /// <returns>Objeto de tipo Proveedor que coincida con el parámetro de búsqueda.</returns>
        Proveedor FindById(int id);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Proveedor en
        /// base al valor proporcionado. Puede ser por: nombre, dirección,
        /// teléfono, etc.
        /// </summary>
        /// <param name="value">Valor a filtrar.</param>
        /// <returns>Colección de objetos de tipo Proveedor que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Proveedor> Read(string value);
    }
}
