namespace Artemis.ViewModels.Common
{
    /// <summary>
    /// Objeto simple de tipo Municipio desde una vista
    /// personalizada.
    /// </summary>
    internal class MunicipioView
    {
        /// <summary>
        /// Identificador único del municipio.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del municipio.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Nombre del departamento asociado al municipio
        /// </summary>
        public string Departamento { get; set; }
    }
}
