using System.Collections.Generic;
using System.Linq;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Identity;
using Common.Util;
using Models.Identity;

namespace Connection.Identity
{
    /// <summary>
    /// Clase encargada de proveer el acceso a la base de datos
    /// al objeto Usuario.
    /// </summary>
    internal class UsuarioDao : BaseDao<Usuario>, IUsuarioDao
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor de la clase. Toma en cuenta la cadena de conexión a la base de datos
        /// y una instancia del administrador de errores.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión.</param>
        /// <param name="handler">Administrador de errores.</param>
        public UsuarioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Usuario Create(Usuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.UsuarioCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Contraseña", model.Contraseña },
                {"Rol", model.Rol },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Usuario Delete(Usuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.UsuarioDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IUsuarioDao.FindById(int)"/>
        public Usuario FindById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"Id", id},
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IUsuarioDao.FindByIdEmpleado(int)"/>
        public Usuario FindByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado < 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"Estado", 1 },
                {"IdEmpleado", idEmpleado }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IUsuarioDao.Login(string, string)"/>
        public Usuario Login(string nombre, string contraseña)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                Handler.Add("NOMBRE_DEFAULT");
                return null;
            }

            if (string.IsNullOrEmpty(contraseña))
            {
                Handler.Add("CONTRASEÑA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.UsuarioLogin, new Dictionary<string, object>
            {
                {"Nombre", nombre },
                {"Contraseña", contraseña }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Usuario> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IUsuarioDao.Read(string)"/>
        public IEnumerable<Usuario> Read(string value)
        {
            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Rol", value },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Usuario Update(Usuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.UsuarioUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Contraseña", model.Contraseña },
                {"Rol", model.Rol },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
