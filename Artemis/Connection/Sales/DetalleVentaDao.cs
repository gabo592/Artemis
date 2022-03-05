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
    /// al objeto Detalle de Venta.
    /// </summary>
    internal class DetalleVentaDao : BaseDao<DetalleVenta>, IDetalleVentaDao
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
        public DetalleVentaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override DetalleVenta Create(DetalleVenta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.DetalleVentaCreate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento },
                {"CostoEnvio", model.CostoEnvio }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override DetalleVenta Delete(DetalleVenta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.DetalleVentaDelete, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IDetalleVentaDao.FindByCantidad(int)"/>
        public IEnumerable<DetalleVenta> FindByCantidad(int cantidad)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleVentaDao.FindByCostoEnvio(decimal)"/>
        public IEnumerable<DetalleVenta> FindByCostoEnvio(decimal constoEnvio)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleVentaDao.FindByDescuento(float)"/>
        public IEnumerable<DetalleVenta> FindByDescuento(float descuento)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleVentaDao.FindByIdProducto(int)"/>
        public IEnumerable<DetalleVenta> FindByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default) || idProducto < 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleVentaDao.FindByIdVenta(int)"/>
        public IEnumerable<DetalleVenta> FindByIdVenta(int idVenta)
        {
            if (idVenta.Equals(default) || idVenta < 0)
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleVentaDao.FindByPrecio(decimal)"/>
        public IEnumerable<DetalleVenta> FindByPrecio(decimal precio)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleVentaDao.FindByPrecio(decimal, decimal)"/>
        public IEnumerable<DetalleVenta> FindByPrecio(decimal precioBajo, decimal precioAlto)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<DetalleVenta> Read()
        {
            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleVentaDao.Read(int, int)"/>
        public DetalleVenta Read(int idVenta, int idProducto)
        {
            if (idVenta.Equals(default) || idVenta < 0)
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return null;
            }

            if (idProducto.Equals(default) || idProducto < 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta },
                {"IdProducto", idProducto },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override DetalleVenta Update(DetalleVenta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.DetalleVentaUpdate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento },
                {"CostoEnvio", model.CostoEnvio }
            }).FirstOrDefault() ?? null;
        }
    }
}
