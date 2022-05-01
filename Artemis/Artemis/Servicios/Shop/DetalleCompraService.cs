using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artemis.Servicios.Base;
using Artemis.Servicios.Common;
using Artemis.ViewModels.Shop;
using Common.Util;
using Connection.Interfaces.Shop;
using Models.Shop;

namespace Artemis.Servicios.Shop
{
    /// <summary>
    /// Clase encargada de proveer los servicios para los Detalles de Compras.
    /// </summary>
    internal class DetalleCompraService : IServicioBase
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto DetalleCompra.
        /// </summary>
        private readonly IDetalleCompraDao detalleCompraDao;

        /// <summary>
        /// Proveedor de servicios para los Productos.
        /// </summary>
        private readonly ProductoService productoService;

        public DetalleCompraService()
        {
            Handler = new ErrorHandler();
            detalleCompraDao = DaoFactory.Get<IDetalleCompraDao>(Handler);
            productoService = new ProductoService();
        }

        /// <summary>
        /// Crea un registro de tipo DetalleCompra dentro de la base de datos tomando en cuenta la colección
        /// de valores o propiedades de dicho objeto.
        /// </summary>
        /// <param name="values">Valores o propiedades del DetalleCompra.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de valores o propiedades no es válida.</exception>
        public void Create(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "La colección de valores o propiedades del Detalle de Compra no son válidos.");

            DetalleCompra detalleCompra = detalleCompraDao.Create(new DetalleCompra
            {
                IdCompra = (int)values["IdCompra"],
                IdProducto = (int)values["IdProducto"],
                Costo = Convert.ToDecimal(values["Costo"]),
                Cantidad = (int)values["Cantidad"],
                Descuento = Convert.ToSingle(values["Descuento"]),
                CostoEnvio = Convert.ToDecimal(values["CostoEnvio"])
            });

            if (detalleCompra is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IDetalleCompraDao.Read(int, int)"/>
        public DetalleCompra GetDetalleCompra(int idCompra, int idProducto)
        {
            if (idCompra.Equals(default))
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return null;
            }

            if (idProducto.Equals(default))
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return detalleCompraDao.Read(idCompra, idProducto);
        }

        /// <summary>
        /// Realiza la búsqueda de todos los registros de tipo DetalleCompra de la base de datos.
        /// </summary>
        /// <returns>Colección de objetos de tipo DetalleCompra desde una vista personalizada.</returns>
        public IEnumerable<DetalleCompraView> GetDetalleCompras()
        {
            IEnumerable<DetalleCompra> detalleCompras = detalleCompraDao.Read();

            return detalleCompras.Select(detalleCompra =>
            {
                var producto = productoService.GetById(detalleCompra.IdProducto);

                return new DetalleCompraView
                {
                    Id = producto.Id,
                    Producto = producto.Descripcion,
                    Costo = detalleCompra.Costo,
                    Cantidad = detalleCompra.Cantidad,
                    Descuento = detalleCompra.Descuento,
                    Envio = detalleCompra.CostoEnvio
                };
            });
        }

        /// <inheritdoc cref="IDetalleCompraDao.FindByIdCompra(int)"/>
        public IEnumerable<DetalleCompraView> GetDetalleCompras(int idCompra)
        {
            if (idCompra.Equals(default)) return null;

            IEnumerable<DetalleCompra> detalleCompras = detalleCompraDao.FindByIdCompra(idCompra);

            return detalleCompras.Select(detalleCompra =>
            {
                var producto = productoService.GetById(detalleCompra.IdProducto);

                return new DetalleCompraView
                {
                    Id = producto.Id,
                    Producto = producto.Descripcion,
                    Costo = detalleCompra.Costo,
                    Cantidad = detalleCompra.Cantidad,
                    Descuento = detalleCompra.Descuento,
                    Envio = detalleCompra.CostoEnvio
                };
            });
        }

        /// <summary>
        /// Actualiza un registro de tipo DetalleCompra dentro de la base de datos tomando en cuenta la colección
        /// de valores o propiedades de dicho objeto.
        /// </summary>
        /// <param name="values">Valores o propiedades del DetalleCompra.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de valores o propiedades no es válida.</exception>
        public void Update(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "La colección de valores o propiedades del Detalle de Compra no son válidos.");

            DetalleCompra detalleCompra = detalleCompraDao.Update(new DetalleCompra
            {
                IdCompra = (int)values["IdCompra"],
                IdProducto = (int)values["IdProducto"],
                Costo = Convert.ToDecimal(values["Costo"]),
                Cantidad = (int)values["Cantidad"],
                Descuento = Convert.ToSingle(values["Descuento"]),
                CostoEnvio = Convert.ToDecimal(values["CostoEnvio"])
            });

            if (detalleCompra is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina la información de un registro de tipo DetalleCompra de la base de datos tomando en cuenta
        /// el ID de la compra asociada y el ID del producto asociado.
        /// </summary>
        /// <param name="idCompra">Identificador único de la compra.</param>
        /// <param name="idProducto">Identificador único del producto.</param>
        public void Delete(int idCompra, int idProducto)
        {
            if (idCompra.Equals(default))
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return;
            }

            if (idProducto.Equals(default))
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return;
            }

            DetalleCompra detalleCompra = detalleCompraDao.Delete(GetDetalleCompra(idCompra, idProducto));

            if (detalleCompra is null) Handler.Add("MODELO_NULO");
        }

        #region IServicioBase Members

        public void Dispose()
        {
            Handler.Clear();
            productoService.Dispose();
        }

        public string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (productoService != null && productoService.HasError())
            {
                builder.AppendLine(productoService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public bool HasError() => Handler.HasError() || productoService.HasError();

        #endregion

    }
}
