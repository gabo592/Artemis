using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artemis.Servicios.Base;
using Artemis.Servicios.Common;
using Artemis.ViewModels.Sales;
using Connection.Interfaces.Sales;
using Common.Util;
using Models.Sales;

namespace Artemis.Servicios.Sales
{
    /// <summary>
    /// Clase encargada de proveer los servicios para los objetos
    /// de tipo Detalle de Ventas.
    /// </summary>
    internal class DetalleVentaService : IServicioBase
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto Detalle de Venta.
        /// </summary>
        private readonly IDetalleVentaDao detalleVentaDao;

        /// <summary>
        /// Proveedor de servicios para los productos.
        /// </summary>
        private readonly ProductoService productoService;

        #endregion

        public DetalleVentaService()
        {
            Handler = new ErrorHandler();
            detalleVentaDao = DaoFactory.Get<IDetalleVentaDao>(Handler);
            productoService = new ProductoService();
        }

        /// <summary>
        /// Crea la información de un registro de tipo Detalle de Venta en base al ID de la venta
        /// asociada y una colección de objetos de tipo DetalleVentaView que corresponden al "carrito de compras"
        /// del cliente.
        /// </summary>
        /// <param name="idVenta">Identificador único de la venta.</param>
        /// <param name="detalleVentaViews">Colección de objetos de tipo DetalleVentaView que conforman el carrito de compras.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de objetos de tipo DetalleVentaView no se proporciona.</exception>
        public void Create(int idVenta, IEnumerable<DetalleVentaView> detalleVentaViews)
        {
            if (idVenta.Equals(default))
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return;
            }

            if (detalleVentaViews is null || detalleVentaViews.Count() == 0) throw new ArgumentNullException(nameof(detalleVentaViews), "La colección de detalles de venta no puede ser nula.");

            foreach (DetalleVentaView view in detalleVentaViews)
            {
                DetalleVenta detalleVenta = detalleVentaDao.Create(new DetalleVenta
                {
                    IdVenta = idVenta,
                    IdProducto = view.Id,
                    Precio = view.Precio,
                    Cantidad = view.Cantidad,
                    Descuento = view.Descuento,
                    CostoEnvio = view.Envio
                });

                if (detalleVenta is null) Handler.Add($"No se pudo crear el Detalle de Venta con ID de producto: {view.Id}.");
            }
        }

        /// <inheritdoc cref="IDetalleVentaDao.FindByIdVenta(int)"/>
        public IEnumerable<DetalleVentaView> GetDetalleVentas(int idVenta)
        {
            if (idVenta.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            IEnumerable<DetalleVenta> detalleVentas = detalleVentaDao.FindByIdVenta(idVenta);

            return detalleVentas.Select(detalle =>
            {
                var producto = productoService.GetById(detalle.IdProducto);

                return new DetalleVentaView
                {
                    Id = producto.Id,
                    Producto = producto.Descripcion,
                    Precio = detalle.Precio,
                    Cantidad = detalle.Cantidad,
                    Descuento = detalle.Descuento,
                    Envio = detalle.CostoEnvio
                };
            });
        }

        /// <inheritdoc cref="IDetalleVentaDao.Read(int, int)"/>
        public DetalleVenta GetDetalleVenta(int idVenta, int idProducto)
        {
            if (idVenta.Equals(default))
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return null;
            }

            if (idProducto.Equals(default))
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return detalleVentaDao.Read(idVenta, idProducto);
        }

        /// <summary>
        /// Actualiza la información de un registro de tipo Detalle de Venta en base al ID de la venta
        /// asociada y una colección de objetos de tipo DetalleVentaView que corresponden al "carrito de compras"
        /// del cliente.
        /// </summary>
        /// <param name="idVenta">Identificador único de la venta.</param>
        /// <param name="detalleVentaViews">Colección de objetos de tipo DetalleVentaView que conforman el carrito de compras.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de objetos de tipo DetalleVentaView no se proporciona.</exception>
        public void Update(int idVenta, IEnumerable<DetalleVentaView> detalleVentaViews)
        {
            if (idVenta.Equals(default))
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return;
            }

            if (detalleVentaViews is null || detalleVentaViews.Count() == 0) throw new ArgumentNullException(nameof(detalleVentaViews), "La colección de detalles de venta no puede ser nula.");

            foreach (DetalleVentaView view in detalleVentaViews)
            {
                DetalleVenta detalleVenta = detalleVentaDao.Update(new DetalleVenta
                {
                    IdVenta = idVenta,
                    IdProducto = view.Id,
                    Precio = view.Precio,
                    Cantidad = view.Cantidad,
                    Descuento = view.Descuento,
                    CostoEnvio = view.Envio
                });

                if (detalleVenta is null) Handler.Add($"No se pudo crear el Detalle de Venta con ID de producto: {view.Id}.");
            }
        }

        /// <summary>
        /// Elimina la información de un registro de tipo Detalle de Venta de la base de datos,
        /// tomando en cuenta el ID de la venta y producto asociados.
        /// </summary>
        /// <param name="idVenta">Identificador único de la venta.</param>
        /// <param name="idProducto">Identificador único del producto</param>
        public void Delete(int idVenta, int idProducto)
        {
            if (idVenta.Equals(default))
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return;
            }

            if (idProducto.Equals(default))
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return;
            }

            DetalleVenta detalleVenta = detalleVentaDao.Delete(GetDetalleVenta(idVenta, idProducto));

            if (detalleVenta is null) Handler.Add("MODELO_NULO");
        }

        #region IServicioBase Members

        public void Dispose()
        {
            Handler.Clear();
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
