using Models.Identity;

namespace Artemis.Servicios.Base
{
    /// <summary>
    /// Clase encargada de administrar la sesión de un usuario dentro
    /// del sistema.
    /// </summary>
    internal class Sesion
    {
        /// <summary>
        /// Objeto simple de tipo Usuario.
        /// </summary>
        public static Usuario Usuario { get; private set; }

        /// <summary>
        /// Indica si existe una sesión activa dentro del sistema.
        /// </summary>
        public static bool IsActive => Usuario != null;

        /// <summary>
        /// Establece un nuevo inicio de sesión en base al usuario
        /// proporcionado.
        /// </summary>
        /// <param name="usuario">Usuario que iniciará dentro del sistema.</param>
        public static void SetSession(Usuario usuario)
        {
            if (usuario is null)
            {
                CloseSession();
                return;
            }

            Usuario = usuario;
        }

        /// <summary>
        /// Cierra la sesión actual.
        /// </summary>
        private static void CloseSession()
        {
            Usuario = null;
        }
    }
}
