namespace Artemis.ViewModels.Sales
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Venta desde una vista
    /// personalizada.
    /// </summary>
    internal class DetalleVentaView
    {
        /// <summary>
        /// Identificador único del detalle de venta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripción del producto asociado al detalle.
        /// </summary>
        public string Producto { get; set; }

        /// <summary>
        /// Precio del producto a vender.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Cantidad a vender del producto.
        /// </summary>
        public int Cantidad { get; set; }

        /// <summary>
        /// Descuento aplicado al producto en la venta del mismo.
        /// </summary>
        public float Descuento { get; set; }

        /// <summary>
        /// Costo del envío a cubrir en la venta asociada al detalle.
        /// </summary>
        public decimal Envio { get; set; }
    }
}
