using Models.Interfaces;

namespace Models.Sales
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Venta.
    /// </summary>
    public class DetalleVenta : ITransactionDetail, IActivable
    {
        /// <summary>
        /// Identificador único de la venta a la que está asociada el detalle.
        /// </summary>
        public int IdVenta { get; set; }

        /// <inheritdoc cref="ITransactionDetail.IdProducto"/>
        public int IdProducto { get; set;  }

        /// <summary>
        /// Precio de venta del producto.
        /// </summary>
        public decimal Precio { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Cantidad"/>
        public int Cantidad { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Descuento"/>
        public float Descuento { get; set; }

        /// <inheritdoc cref="ITransactionDetail.CostoEnvio"/>
        public decimal CostoEnvio { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
