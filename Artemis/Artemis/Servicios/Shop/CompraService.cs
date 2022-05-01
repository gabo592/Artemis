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
    /// Clase encargada de proveer los servicios para las Compras.
    /// </summary>
    internal class CompraService : IServicioBase
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto Compra.
        /// </summary>
        private readonly ICompraDao compraDao;

        /// <summary>
        /// Proveedor de servicios para los objetos de tipo Proveedor.
        /// </summary>
        private readonly ProveedorService proveedorService;

        /// <summary>
        /// Proveedor de servicios para los objetos de tipo Empleado.
        /// </summary>
        private readonly EmpleadoService empleadoService;

        #endregion

        public CompraService()
        {
            Handler = new ErrorHandler();
            compraDao = DaoFactory.Get<ICompraDao>(Handler);
            proveedorService = new ProveedorService();
            empleadoService = new EmpleadoService();
        }

        /// <summary>
        /// Crea un registro de tipo Compra en la base de datos con la colección de valores o propiedades
        /// de la misma.
        /// </summary>
        /// <param name="values">Valores o propiedades de la Compra.</param>
        /// <returns>Objeto simple de tipo Compra.</returns>
        /// <exception cref="ArgumentNullException">Se dispara cuando los valores o propiedades son nulos.</exception>
        public Compra Create(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "La colección de valores o propiedades de la Compra no son válidos.");

            Compra compra = compraDao.Create(new Compra
            {
                Fecha = (DateTime)values["Fecha"],
                IdProveedor = (int)values["IdProveedor"],
                IdEmpleado = (int)values["IdEmpleado"]
            });

            if (compra is null) Handler.Add("MODELO_NULO");

            return compra;
        }

        /// <inheritdoc cref="ICompraDao.FindById(int)"/>
        public Compra GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return compraDao.FindById(id);
        }

        /// <summary>
        /// Realiza la búsqueda de todos los objetos de tipo Compra dentro de la base de datos.
        /// </summary>
        /// <returns>Colección de objetos de tipo Compra desde una vista personalizada.</returns>
        public IEnumerable<CompraView> GetCompras()
        {
            IEnumerable<Compra> compras = compraDao.Read();

            return compras.Select(compra =>
            {
                var proveedor = proveedorService.GetById(compra.IdProveedor);
                var empleado = empleadoService.GetById(compra.IdEmpleado);

                return new CompraView
                {
                    Id = compra.Id,
                    Fecha = compra.Fecha,
                    Proveedor = proveedor.Nombre,
                    Empleado = $"{empleado.PrimerNombre} {empleado.PrimerApellido}"
                };
            });
        }

        /// <inheritdoc cref="ICompraDao.Read(DateTime)"/>
        public IEnumerable<CompraView> GetCompras(DateTime fecha)
        {
            IEnumerable<Compra> compras = compraDao.Read(fecha);

            return compras.Select(compra =>
            {
                var proveedor = proveedorService.GetById(compra.IdProveedor);
                var empleado = empleadoService.GetById(compra.IdEmpleado);

                return new CompraView
                {
                    Id = compra.Id,
                    Fecha = compra.Fecha,
                    Proveedor = proveedor.Nombre,
                    Empleado = $"{empleado.PrimerNombre} {empleado.PrimerApellido}"
                };
            });
        }

        /// <summary>
        /// Actualiza un registro de tipo Compra en la base de datos con la colección de valores o propiedades
        /// de la misma.
        /// </summary>
        /// <param name="values">Valores o propiedades de la Compra.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando los valores o propiedades son nulos.</exception>
        public void Update(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "La colección de valores o propiedades de la Compra no son válidos.");

            Compra compra = compraDao.Update(new Compra
            {
                Id = (int)values["Id"],
                Fecha = (DateTime)values["Fecha"],
                IdProveedor = (int)values["IdProveedor"],
                IdEmpleado = (int)values["IdEmpleado"]
            });

            if (compra is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina la información de un registro de tipo Compra de la base de datos, tomando como referencia
        /// el ID del registro.
        /// </summary>
        /// <param name="id">Identificador único de la Compra.</param>
        public void Delete(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return;
            }

            Compra compra = compraDao.Delete(GetById(id));

            if (compra is null) Handler.Add("MODELO_NULO");
        }

        #region IServicioBase Members

        public void Dispose()
        {
            Handler.Clear();
            proveedorService.Dispose();
            empleadoService.Dispose();
        }

        public string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (proveedorService != null && proveedorService.HasError())
            {
                builder.AppendLine(proveedorService.GetErrorMessage());
            }

            if (empleadoService != null && empleadoService.HasError())
            {
                builder.AppendLine(empleadoService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public bool HasError() => Handler.HasError() || proveedorService.HasError() || empleadoService.HasError();

        #endregion

    }
}
