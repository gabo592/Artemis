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
    /// al objeto Detalle de Compra.
    /// </summary>
    internal class DetalleCompraDao : BaseDao<DetalleCompra>, IDetalleCompraDao
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
        public DetalleCompraDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override DetalleCompra Create(DetalleCompra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.DetalleCompraCreate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdProducto", model.IdProducto },
                {"Costo", model.Costo },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento },
                {"CostoEnvio", model.CostoEnvio }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override DetalleCompra Delete(DetalleCompra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.DetalleCompraDelete, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdProducto", model.IdProducto }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IDetalleCompraDao.FindByCantidad(int)"/>
        public IEnumerable<DetalleCompra> FindByCantidad(int cantidad)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleCompraDao.FindByCosto(decimal)"/>
        public IEnumerable<DetalleCompra> FindByCosto(decimal costo)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleCompraDao.FindByCosto(decimal, decimal)"/>
        public IEnumerable<DetalleCompra> FindByCosto(decimal costoBajo, decimal costoAlto)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleCompraDao.FindByCostoEnvio(decimal)"/>
        public IEnumerable<DetalleCompra> FindByCostoEnvio(decimal constoEnvio)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleCompraDao.FindByDescuento(float)"/>
        public IEnumerable<DetalleCompra> FindByDescuento(float descuento)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDetalleCompraDao.FindByIdCompra(int)"/>
        public IEnumerable<DetalleCompra> FindByIdCompra(int idCompra)
        {
            if (idCompra.Equals(default) || idCompra < 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return Enumerable.Empty<DetalleCompra>();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleCompraDao.FindByIdProducto(int)"/>
        public IEnumerable<DetalleCompra> FindByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default) || idProducto < 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return Enumerable.Empty<DetalleCompra>();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<DetalleCompra> Read()
        {
            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleCompraDao.Read(int, int)"/>
        public DetalleCompra Read(int idCompra, int idProducto)
        {
            if (idCompra.Equals(default) || idCompra < 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return null;
            }

            if (idProducto.Equals(default) || idProducto < 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra },
                {"IdProducto", idProducto },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override DetalleCompra Update(DetalleCompra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdProducto", model.IdProducto },
                {"Costo", model.Costo },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento },
                {"CostoEnvio", model.CostoEnvio }
            }).FirstOrDefault() ?? null;
        }
    }
}
