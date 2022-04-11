namespace Artemis.ViewModels.Common
{
    /// <summary>
    /// Objeto simple de tipo Empleado desde una vista personalizada.
    /// </summary>
    internal class EmpleadoView
    {
        /// <summary>
        /// Identificador único del empleado.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Primer y segundo nombre del empleado.
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Primer y segundo apellido del empleado.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Correo electrónico del empleado.
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// Número de cédula del empleado.
        /// </summary>
        public string Cedula { get; set; }

        /// <summary>
        /// Nombre del municipio al que pertenece el empleado.
        /// </summary>
        public string Municipio { get; set; }

        /// <summary>
        /// Nombre del departamento al que pertenece el municipio.
        /// </summary>
        public string Departamento { get; set; }
    }
}
