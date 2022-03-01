using System.Drawing;
using Models.Interfaces;

namespace Models.Common
{
    /// <summary>
    /// Objeto simple de tipo Categoría.
    /// </summary>
    public class Categoria : IIdentity, INameable, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <summary>
        /// Representación gráfica del producto.
        /// </summary>
        public Image Imagen { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
