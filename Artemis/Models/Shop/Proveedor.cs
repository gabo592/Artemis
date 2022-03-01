using Models.Interfaces;

namespace Models.Shop
{
    /// <summary>
    /// Objeto simple de tipo Proveedor
    /// </summary>
    public class Proveedor : IIdentity, INameable, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <summary>
        /// Número telefónico del proveedor.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Dirección del proveedor.
        /// </summary>
        public string Direccion { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
