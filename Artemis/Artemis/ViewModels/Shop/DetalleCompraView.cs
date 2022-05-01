namespace Artemis.ViewModels.Shop
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Compra desde una vista personalizada.
    /// </summary>
    internal class DetalleCompraView
    {
        /// <summary>
        /// Identificador único del producto a comprar.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripción del producto a comprar.
        /// </summary>
        public string Producto { get; set; }

        /// <summary>
        /// Costo del producto a comprar.
        /// </summary>
        public decimal Costo { get; set; }

        /// <summary>
        /// Cantidad a comprar del producto.
        /// </summary>
        public int Cantidad { get; set; }

        /// <summary>
        /// Descuento aplicado a la compra del producto.
        /// </summary>
        public float Descuento { get; set; }

        /// <summary>
        /// Costo de envío del producto.
        /// </summary>
        public decimal Envio { get; set; }
    }
}
