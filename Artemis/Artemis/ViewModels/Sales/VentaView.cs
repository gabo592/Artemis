using System;

namespace Artemis.ViewModels.Sales
{
    /// <summary>
    /// Objeto simple de tipo Venta desde una vista
    /// personalizada.
    /// </summary>
    internal class VentaView
    {
        /// <summary>
        /// Identificador único de la venta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha en que se realizó la venta.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Nombre del cliente asociado a la venta.
        /// </summary>
        public string Cliente { get; set; }

        /// <summary>
        /// Nombre del empleado que realizó la venta.
        /// </summary>
        public string Empleado { get; set; }
    }
}
