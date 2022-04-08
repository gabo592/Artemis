namespace Artemis.ViewModels.Shop
{
    /// <summary>
    /// Objeto simple de tipo Proveedor desde una vista
    /// personalizada.
    /// </summary>
    internal class ProveedorView
    {
        /// <summary>
        /// Identificador único del Proveedor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del Proveedor.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Número telefónico del Proveedor.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Dirección física del Proveedor.
        /// </summary>
        public string Direccion { get; set; }
    }
}
