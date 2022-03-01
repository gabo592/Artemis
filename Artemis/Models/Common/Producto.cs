using System.Drawing;
using Models.Interfaces;

namespace Models.Common
{
    /// <summary>
    /// Objeto simple de tipo Producto.
    /// </summary>
    internal class Producto : IIdentity, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <summary>
        /// Descripción del producto.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Representación gráfica del producto.
        /// </summary>
        public Image Imagen { get; set; }

        /// <summary>
        /// Precio en catálogo del producto.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Cantidad en stock del producto.
        /// </summary>
        public int Stock { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único de la categoría a la que está asociado.
        /// </summary>
        public int IdCategoria { get; set; }
    }
}
