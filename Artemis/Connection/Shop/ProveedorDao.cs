using System.Collections.Generic;
using System.Linq;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Shop;
using Common.Util;
using Models.Shop;

namespace Connection.Shop
{
    /// <summary>
    /// Clase encargada de proveer el acceso a la base de datos
    /// al objeto Proveedor.
    /// </summary>
    internal class ProveedorDao : BaseDao<Proveedor>, IProveedorDao
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
        public ProveedorDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Proveedor Create(Proveedor model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.ProveedorCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion }                
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Proveedor Delete(Proveedor model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.ProveedorDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IProveedorDao.FindById(int)"/>
        public Proveedor FindById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ProveedorRead, new Dictionary<string, object>
            {
                {"Id", id},
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Proveedor> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IProveedorDao.Read(string)"/>
        public IEnumerable<Proveedor> Read(string value)
        {
            return Read(StoredProcedures.ProveedorRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Telefono", value },
                {"Direccion", value },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Proveedor Update(Proveedor model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.ProveedorUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion }
            }).FirstOrDefault() ?? null;
        }
    }
}
