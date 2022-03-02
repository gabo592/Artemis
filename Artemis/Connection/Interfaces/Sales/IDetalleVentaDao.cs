using System.Collections.Generic;
using Connection.Base;
using Models.Sales;

namespace Connection.Interfaces.Sales
{
    /// <summary>
    /// DAO del objeto Detalle de Venta.
    /// </summary>
    public interface IDetalleVentaDao : IDao<DetalleVenta>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Venta
        /// en base al ID de la venta proporcionado.
        /// </summary>
        /// <param name="idVenta">Identificador único de la venta.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleVenta> FindByIdVenta(int idVenta);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Venta
        /// en base al ID del producto proporcionado.
        /// </summary>
        /// <param name="idProducto">Identificador único del producto.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleVenta> FindByIdProducto(int idProducto);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Venta
        /// en base al ID de la venta y el ID del producto proporcionado.
        /// </summary>
        /// <param name="idVenta">Identificador único de la venta.</param>
        /// <param name="idProducto">Identificador único del producto.</param>
        /// <returns>Objeto de tipo Detalle de Venta que coincida con los parámetros de búsqueda.</returns>
        DetalleVenta Read(int idVenta, int idProducto);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Venta
        /// en base al precio proporcionado.
        /// </summary>
        /// <param name="precio">Precio de venta.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleVenta> FindByPrecio(decimal precio);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Venta
        /// en base al intervalo de precios proporcionado.
        /// </summary>
        /// <param name="precioBajo">Precio más bajo del detalle de venta.</param>
        /// <param name="precioAlto">Precio más alto del detalle de venta.</param>
        /// <returns>Colección de objetos de tipo Detalle de Ventas que coincidan con los parámetros de búsqueda.</returns>
        IEnumerable<DetalleVenta> FindByPrecio(decimal precioBajo, decimal precioAlto);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Venta
        /// en base a la cantidad proporcionada.
        /// </summary>
        /// <param name="cantidad">Cantidad de productos involucrados en el detalle de venta.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que coincian con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleVenta> FindByCantidad(int cantidad);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Venta
        /// en base al descuento proporcionado.
        /// </summary>
        /// <param name="descuento">Desciento aplicado en el detalle de venta.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que coincian con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleVenta> FindByDescuento(float descuento);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Venta
        /// en base al costo del envío proporcionado.
        /// </summary>
        /// <param name="constoEnvio">Costo del envío del producto.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que coincian con el parámetro de búsqueda.</returns>
        IEnumerable<DetalleVenta> FindByCostoEnvio(decimal constoEnvio);
    }
}
