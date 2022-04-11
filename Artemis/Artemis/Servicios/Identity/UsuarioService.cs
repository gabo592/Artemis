using Artemis.Servicios.Base;
using Artemis.Servicios.Common;
using Artemis.ViewModels.Identity;
using Connection.Interfaces.Identity;
using Common.Util;
using Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        /// <summary>
        /// Proveedor de servicios para los Empleados.
        /// </summary>
        private readonly EmpleadoService EmpleadoService;

        public UsuarioService()
        {
            Handler = new ErrorHandler();
            UsuarioDao = DaoFactory.Get<IUsuarioDao>(Handler);
            EmpleadoService = new EmpleadoService();
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

        /// <summary>
        /// Crea un nuevo registro de tipo Usuario en la base de datos tomando en cuenta
        /// los valores o propiedades del mismo.
        /// </summary>
        /// <param name="values">Valores o propiedades del usuario.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se pasan los valores.</exception>
        public void Create(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "No es posible crear el usuario sin sus valores.");

            Usuario usuario = UsuarioDao.Create(new Usuario
            {
                Nombre = values["Nombre"].ToString(),
                Contraseña = values["Contraseña"].ToString(),
                Rol = values["Rol"].ToString(),
                IdEmpleado = (int)values["IdEmpleado"]
            });

            if (usuario is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IUsuarioDao.Read(string)"/>
        public IEnumerable<UsuarioView> GetUsuarios(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) value = null;

            IEnumerable<Usuario> usuarios = UsuarioDao.Read(value);

            return usuarios.Select(usuario =>
            {
                var empleado = EmpleadoService.GetById(usuario.IdEmpleado);

                return new UsuarioView
                {
                    Id = usuario.Id,
                    Nombre = usuario.Nombre,
                    Rol = usuario.Rol,
                    Empleado = $"{empleado.PrimerNombre} {empleado.PrimerApellido}"
                };
            });
        }

        /// <summary>
        /// Modifica un registro de tipo Usuario de la base de datos tomando en cuenta
        /// los valores o propiedades del mismo.
        /// </summary>
        /// <param name="values">Valores o propiedades del usuario.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se pasan los valores.</exception>
        public void Update(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "No es posible crear el usuario sin sus valores.");

            Usuario usuario = UsuarioDao.Update(new Usuario
            {
                Id = (int)values["Id"],
                Nombre = values["Nombre"].ToString(),
                Contraseña = values["Contraseña"].ToString(),
                Rol = values["Rol"].ToString(),
                IdEmpleado = (int)values["IdEmpleado"]
            });

            if (usuario is null) Handler.Add("MODELO_NULO");
        }

        #region IServicioBase Members

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            Handler.Clear();
        }

        /// <inheritdoc cref="IServicioBase.GetErrorMessage"/>
        public string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (EmpleadoService != null && EmpleadoService.HasError())
            {
                builder.AppendLine(EmpleadoService.GetErrorMessage());
            }

            return builder.ToString();
        }

        /// <inheritdoc cref="IServicioBase.HasError"/>
        public bool HasError() => Handler.HasError() || EmpleadoService.HasError();

        #endregion
    }
}
