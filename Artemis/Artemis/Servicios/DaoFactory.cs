using Artemis.Properties;
using Common.Util;

namespace Artemis.Servicios
{
    /// <summary>
    /// Clase encargada de fabricar el DAO del tipo
    /// especificado.
    /// </summary>
    internal static class DaoFactory
    {
        /// <summary>
        /// Cadena de conexión a la base de datos
        /// </summary>
        private static readonly string conexion;

        static DaoFactory()
        {
            conexion = Settings.Default.ConnectionString;
        }

        /// <inheritdoc cref="Connection.Factory.Invoke{TDao}(string, ErrorHandler)"/>
        public static TDao Get<TDao>(ErrorHandler handler) => Connection.Factory.Invoke<TDao>(conexion, handler);
    }
}
