using System;
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
    /// al objeto Compra.
    /// </summary>
    internal class CompraDao : BaseDao<Compra>, ICompraDao
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
        public CompraDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Compra Create(Compra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.CompraCreate, new Dictionary<string, object>
            {
                {"Fecha", model.Fecha },
                {"IdProveedor", model.IdProveedor },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Compra Delete(Compra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.CompraDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="ICompraDao.FindById(int)"/>
        public Compra FindById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Id", id},
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="ICompraDao.FindByIdEmpleado(int)"/>
        public IEnumerable<Compra> FindByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado < 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="ICompraDao.FindByIdProveedor(int)"/>
        public IEnumerable<Compra> FindByIdProveedor(int idProveedor)
        {
            if (idProveedor.Equals(default) || idProveedor < 0)
            {
                Handler.Add("ID_PROVEEDOR_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"IdProveedor", idProveedor },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Compra> Read()
        {
            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="ICompraDao.Read(DateTime)"/>
        public IEnumerable<Compra> Read(DateTime fecha)
        {
            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Fecha", fecha },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Compra Update(Compra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.CompraUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdProveedor", model.IdProveedor },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
