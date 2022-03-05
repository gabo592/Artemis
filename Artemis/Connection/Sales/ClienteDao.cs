using System.Collections.Generic;
using System.Linq;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Sales;
using Common.Util;
using Models.Sales;

namespace Connection.Sales
{
    /// <summary>
    /// Clase encargada de proveer el acceso a la base de datos
    /// al objeto Cliente.
    /// </summary>
    internal class ClienteDao : BaseDao<Cliente>, IClienteDao
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
        public ClienteDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Cliente Create(Cliente model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.ClienteCreate, new Dictionary<string, object>
            {
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Correo", model.Correo },
                {"Telefono", model.Telefono },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Cliente Delete(Cliente model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.ClienteDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IClienteDao.FindById(int)"/>
        public Cliente FindById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"Id", id},
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IClienteDao.FindByIdMunicipio(int)"/>
        public IEnumerable<Cliente> FindByIdMunicipio(int idMunicipio)
        {
            if (idMunicipio.Equals(default) || idMunicipio < 0)
            {
                Handler.Add("ID_MUNICIPIO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"Estado", 1 },
                {"IdMunicipio", idMunicipio }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Cliente> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IClienteDao.Read(string)"/>
        public IEnumerable<Cliente> Read(string value)
        {
            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"PrimerNombre", value },
                {"SegundoNombre", value },
                {"PrimerApellido", value },
                {"SegundoApellido", value },
                {"Correo", value },
                {"Telefono", value },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Cliente Update(Cliente model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.ClienteUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Correo", model.Correo },
                {"Telefono", model.Telefono },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault() ?? null;
        }
    }
}
