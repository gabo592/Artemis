using System;
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
    /// al objeto Venta.
    /// </summary>
    internal class VentaDao : BaseDao<Venta>, IVentaDao
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
        public VentaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Venta Create(Venta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.VentaCreate, new Dictionary<string, object>
            {
                {"Fecha", model.Fecha },
                {"IdCliente", model.IdCliente },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Venta Delete(Venta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.VentaDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IVentaDao.FindById(int)"/>
        public Venta FindById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IVentaDao.FindByIdCliente(int)"/>
        public IEnumerable<Venta> FindByIdCliente(int idCliente)
        {
            if (idCliente.Equals(default) || idCliente < 0)
            {
                Handler.Add("ID_CLIENTE_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"IdCliente", idCliente },
                {"Estado", 1}
            });
        }

        /// <inheritdoc cref="IVentaDao.FindByIdEmpleado(int)"/>
        public IEnumerable<Venta> FindByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado < 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Venta> Read()
        {
            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IVentaDao.Read(DateTime)"/>
        public IEnumerable<Venta> Read(DateTime fecha)
        {
            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Fecha", fecha }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Venta Update(Venta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.VentaUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdCliente", model.IdCliente },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
