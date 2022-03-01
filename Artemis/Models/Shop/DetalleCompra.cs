using Models.Interfaces;

namespace Models.Shop
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Compra.
    /// </summary>
    public class DetalleCompra : ITransactionDetail, IActivable
    {
        /// <summary>
        /// Identificador único del registro Compra asociado al Detalle de Compra.
        /// </summary>
        public int IdCompra { get; set; }

        /// <inheritdoc cref="ITransactionDetail.IdProducto"/>
        public int IdProducto { get; set; }

        /// <summary>
        /// Costo asumido por la adquisición del bien.
        /// </summary>
        public decimal Costo { get; set; }

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
