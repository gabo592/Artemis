using Artemis.Servicios.Base;
using Connection.Interfaces.Identity;
using Common.Util;
using Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemis.Servicios.Identity
{
    /// <summary>
    /// Clase encargada de proveer los servicios
    /// para los usuarios dentro del sistema.
    /// </summary>
    internal class UsuarioService : IServicioBase
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto usuario.
        /// </summary>
        private readonly IUsuarioDao UsuarioDao;

        public UsuarioService()
        {
            Handler = new ErrorHandler();
            UsuarioDao = DaoFactory.Get<IUsuarioDao>(Handler);
        }

        /// <summary>
        /// Realiza el inicio de sesión al sistema en base a las credenciales
        /// proporcionadas.
        /// </summary>
        /// <param name="nombre">Nombre de usuario.</param>
        /// <param name="contraseña">Contraseña del usuario.</param>
        public void Login(string nombre, string contraseña)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                Handler.Add("NOMBRE_DEFAULT");
                return;
            }

            if (string.IsNullOrEmpty(contraseña))
            {
                Handler.Add("CONTRASEÑA_DEFAULT");
                return;
            }

            Usuario usuario = UsuarioDao.Login(nombre, contraseña);

            if (usuario is null)
            {
                Handler.Add("USUARIO_NULO");
                return;
            }

            Sesion.SetSession(usuario);
        }

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            Handler.Clear();
        }

        /// <inheritdoc cref="IServicioBase.GetErrorMessage"/>
        public string GetErrorMessage() => Handler.GetErrorMessage();

        /// <inheritdoc cref="IServicioBase.HasError"/>
        public bool HasError() => Handler.HasError();
    }
}
