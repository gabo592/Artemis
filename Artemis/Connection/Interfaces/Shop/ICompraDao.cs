using System;
using System.Collections.Generic;
using Connection.Base;
using Models.Shop;

namespace Connection.Interfaces.Shop
{
    /// <summary>
    /// DAO del objeto Compra.
    /// </summary>
    public interface ICompraDao : IDao<Compra>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Compra en base
        /// al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único de la compra.</param>
        /// <returns>Objeto de tipo Compra que coincida con el parámetro de búsqueda.</returns>
        Compra FindById(int id);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Compra en base
        /// a la fecha proporcionada.
        /// </summary>
        /// <param name="fecha">Fecha de la compra.</param>
        /// <returns>Colección de objetos de tipo Compra que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Compra> Read(DateTime fecha);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Compra en base
        /// al ID del proveedor proporcionado.
        /// </summary>
        /// <param name="idProveedor">Identificador único del proveedor.</param>
        /// <returns>Colección de objetos de tipo Compra que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Compra> FindByIdProveedor(int idProveedor);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Compra en base
        /// al ID del empleado proporcionado.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del empleado.</param>
        /// <returns>Colección de objetos de tipo Compra que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Compra> FindByIdEmpleado(int idEmpleado);
    }
}
