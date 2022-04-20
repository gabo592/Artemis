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
    /// Proveedor de servicios para las ventas.
    /// </summary>
    internal class VentaService : IServicioBase
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto Venta.
        /// </summary>
        private readonly IVentaDao ventaDao;

        /// <summary>
        /// Proveedor de servicios para los clientes.
        /// </summary>
        private readonly ClienteService clienteService;

        /// <summary>
        /// Proveedor de servicios para los empleados.
        /// </summary>
        private readonly EmpleadoService empleadoService;

        #endregion

        public VentaService()
        {
            Handler = new ErrorHandler();
            ventaDao = DaoFactory.Get<IVentaDao>(Handler);
            clienteService = new ClienteService();
            empleadoService = new EmpleadoService();
        }

        #region CRUD Ventas

        /// <summary>
        /// Crea un nuevo registro de tipo Venta en la base de datos tomando en cuenta
        /// la colección de valores o propiedades de la misma.
        /// </summary>
        /// <param name="values">Valores o propiedades de la venta.</param>
        /// <returns>Objeto de tipo Venta que acaba de ser creado en la base de datos.</returns>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de valores o propiedades no son proporcionados.</exception>
        public Venta Create(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "La colección de valores o propiedades de la venta no puede ser nula.");

            Venta venta = ventaDao.Create(new Venta
            {
                Fecha = (DateTime)values["Fecha"],
                IdCliente = (int)values["IdCliente"],
                IdEmpleado = (int)values["IdEmpleado"]
            });

            if (venta is null)
            {
                Handler.Add("MODELO_NULO");
                return null;
            }

            return venta;
        }

        /// <summary>
        /// Obtiene una colección de objetos de tipo Venta desde una vista personalizada.
        /// </summary>
        /// <returns>Colección de objetos de tipo Venta registrados en la base de datos.</returns>
        public IEnumerable<VentaView> GetVentas()
        {
            IEnumerable<Venta> ventas = ventaDao.Read();

            return ventas.Select(venta =>
            {
                var cliente = clienteService.GetById(venta.IdCliente);
                var empleado = empleadoService.GetById(venta.IdEmpleado);

                return new VentaView
                {
                    Id = venta.Id,
                    Fecha = venta.Fecha,
                    Cliente = $"{cliente.PrimerNombre} {cliente.PrimerApellido}",
                    Empleado = $"{empleado.PrimerNombre} {empleado.PrimerApellido}"
                };
            });
        }

        /// <inheritdoc cref="IVentaDao.Read(DateTime)"/>
        public IEnumerable<VentaView> GetVentas(DateTime fecha)
        {
            IEnumerable<Venta> ventas = ventaDao.Read(fecha);

            return ventas.Select(venta =>
            {
                var cliente = clienteService.GetById(venta.IdCliente);
                var empleado = empleadoService.GetById(venta.IdEmpleado);

                return new VentaView
                {
                    Id = venta.Id,
                    Fecha = venta.Fecha,
                    Cliente = $"{cliente.PrimerNombre} {cliente.PrimerApellido}",
                    Empleado = $"{empleado.PrimerNombre} {empleado.PrimerApellido}"
                };
            });
        }

        /// <inheritdoc cref="IVentaDao.FindById(int)"/>
        public Venta GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return ventaDao.FindById(id);
        }

        /// <summary>
        /// Actualiza la información de un registro de tipo Venta en la base de datos tomando en cuenta
        /// la colección de valores o propiedades de la misma.
        /// </summary>
        /// <param name="values">Valores o propiedades de la venta.</param>
        /// <returns>Objeto de tipo Venta que acaba de ser actualizado en la base de datos.</returns>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de valores o propiedades no son proporcionados.</exception>
        public void Update(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "La colección de valores o propiedades de la venta no puede ser nula.");

            Venta venta = ventaDao.Update(new Venta
            {
                Id = (int)values["Id"],
                Fecha = (DateTime)values["Fecha"],
                IdCliente = (int)values["IdCliente"],
                IdEmpleado = (int)values["IdEmpleado"]
            });

            if (venta is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina la información de un registro de tipo Venta de la base de datos
        /// en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único de la Venta.</param>
        public void Delete(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return;
            }

            Venta venta = ventaDao.Delete(GetById(id));

            if (venta is null) Handler.Add("MODELO_NULO");
        }

        #endregion

        #region IServicioBase Members

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            Handler.Clear();
            clienteService.Dispose();
            empleadoService.Dispose();
        }

        /// <inheritdoc cref="IServicioBase.GetErrorMessage"/>
        public string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (clienteService != null && clienteService.HasError())
            {
                builder.AppendLine(clienteService.GetErrorMessage());
            }

            if (empleadoService != null && empleadoService.HasError())
            {
                builder.AppendLine(empleadoService.GetErrorMessage());
            }

            return builder.ToString();
        }

        /// <inheritdoc cref="IServicioBase.HasError"/>
        public bool HasError() => Handler.HasError() || clienteService.HasError() || empleadoService.HasError();

        #endregion
    }
}
