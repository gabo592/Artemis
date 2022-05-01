using System;

namespace Artemis.ViewModels.Shop
{
    /// <summary>
    /// Objeto simple de tipo Compra desde una vista personalizada.
    /// </summary>
    internal class CompraView
    {
        /// <summary>
        /// Identificador único de la compra.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha en que se realiza la compra.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Nombre del proveedor asociado a la compra.
        /// </summary>
        public string Proveedor { get; set; }

        /// <summary>
        /// Nombre del empleado que realizó la compra.
        /// </summary>
        public string Empleado { get; set; }
    }
}
