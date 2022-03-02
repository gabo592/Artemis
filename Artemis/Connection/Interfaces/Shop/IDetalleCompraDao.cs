using System.Collections.Generic;
using Connection.Base;
using Models.Shop;

namespace Connection.Interfaces.Shop
{
    /// <summary>
    /// DAO del objeto Detalle de Compra.
    /// </summary>
    public interface IDetalleCompraDao : IDao<DetalleCompra>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Compra
        /// en base al ID de la compra proporcionado.
        /// </summary>
        /// <param name="idCompra">Identificador único de la compra.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleCompra> FindByIdCompra(int idCompra);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Compra
        /// en base al ID del producto proporcionado.
        /// </summary>
        /// <param name="idProducto">Identificador único del producto.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleCompra> FindByIdProducto(int idProducto);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Compra
        /// en base al ID de la compra y el ID del producto proporcionado.
        /// </summary>
        /// <param name="idCompra">Identificador único de la compra.</param>
        /// <param name="idProducto">Identificador único del producto.</param>
        /// <returns>Objeto de tipo Detalle de Compra que coincida con los parámetros de búsqueda.</returns>
        DetalleCompra Read(int idCompra, int idProducto);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Compra
        /// en base al costo proporcionado.
        /// </summary>
        /// <param name="costo">Costo de la compra.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleCompra> FindByCosto(decimal costo);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Compra
        /// en base al intervalo de costos proporcionado.
        /// </summary>
        /// <param name="costoBajo">Costo más bajo del detalle de compra.</param>
        /// <param name="costoAlto">Costo más alto del detalle de compra.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compras que coincidan con los parámetros de búsqueda.</returns>
        IEnumerable<DetalleCompra> FindByCosto(decimal costoBajo, decimal costoAlto);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Compra
        /// en base a la cantidad proporcionada.
        /// </summary>
        /// <param name="cantidad">Cantidad de productos involucrados en el detalle de compra.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que coincian con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleCompra> FindByCantidad(int cantidad);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Compra
        /// en base al descuento proporcionado.
        /// </summary>
        /// <param name="descuento">Desciento aplicado en el detalle de compra.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que coincian con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleCompra> FindByDescuento(float descuento);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Compra
        /// en base al costo del envío proporcionado.
        /// </summary>
        /// <param name="constoEnvio">Costo del envío del producto.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que coincian con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleCompra> FindByCostoEnvio(decimal constoEnvio);
    }
}
