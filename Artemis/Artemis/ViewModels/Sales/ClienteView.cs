using System;

namespace Artemis.ViewModels.Sales
{
    /// <summary>
    /// Objeto simple de tipo Cliente desde una vista personalizada.
    /// </summary>
    internal class ClienteView
    {
        /// <summary>
        /// Identificador único del cliente.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Primer y segundo nombre del cliente.
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Primer y segundo apellido del cliente.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Fecha de nacimiento del cliente.
        /// </summary>
        public DateTime Nacimiento { get; set; }

        /// <summary>
        /// Correo electrónico del cliente.
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// Número telefónico del cliente.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Nombre del municipio donde vive el cliente.
        /// </summary>
        public string Municipio { get; set; }

        /// <summary>
        /// Nombre del departamento asociado al municipio del cliente.
        /// </summary>
        public string Departamento { get; set; }
    }
}
