namespace Models.Interfaces
{
    /// <summary>
    /// Indica que un registro contiene los detalles de otro registro de transacción.
    /// </summary>
    public interface ITransactionDetail
    {
        /// <summary>
        /// Identificador único del producto asociado a la transacción.
        /// </summary>
        int IdProducto { get; set; }

        /// <summary>
        /// Cantidad (a comprar o vender) del producto asociado a la transacción.
        /// </summary>
        int Cantidad { get; set; }

        /// <summary>
        /// Descuento aplicado al producto en la transacción.
        /// </summary>
        float Descuento { get; set; }

        /// <summary>
        /// Costo del envío (fletes) involucrados en la transacción.
        /// </summary>
        decimal CostoEnvio { get; set; }
    }
}
