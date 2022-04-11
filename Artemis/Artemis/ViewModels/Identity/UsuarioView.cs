namespace Artemis.ViewModels.Identity
{
    /// <summary>
    /// Objeto simple de tipo Usuario desde una vista personalizada.
    /// </summary>
    internal class UsuarioView
    {
        /// <summary>
        /// Identificador único del usuario.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de usuario.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Rol del usuario dentro del sistema.
        /// </summary>
        public string Rol { get; set; }

        /// <summary>
        /// Nombre del empleado que utiliza este usuario.
        /// </summary>
        public string Empleado { get; set; }
    }
}
