using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis.Servicios.Base;
using Artemis.ViewModels.Shop;
using Connection.Interfaces.Shop;
using Common.Util;
using Models.Shop;

namespace Artemis.Servicios.Shop
{
    /// <summary>
    /// Clase encargada de proveer los servicios necesarios
    /// para los modelos Proveedores.
    /// </summary>
    internal class ProveedorService : IServicioBase
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto Proveedor.
        /// </summary>
        private readonly IProveedorDao ProveedorDao;

        public ProveedorService()
        {
            Handler = new ErrorHandler();
            ProveedorDao = DaoFactory.Get<IProveedorDao>(Handler);
        }

        /// <summary>
        /// Crea un nuevo registro de un objeto de tipo Proveedor en la base de datos
        /// en base a la colección de valores o propiedades específicas para dicho
        /// objeto.
        /// </summary>
        /// <param name="values">Valores o propiedades del objeto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se proporcionan los valores.</exception>
        /// <exception cref="NullReferenceException">Se dispara cuando no se logró crear el objeto.</exception>
        public void Create(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "No se reconocen los valores para crear el modelo.");

            Proveedor proveedor = ProveedorDao.Create(new Proveedor
            {
                Nombre = values["Nombre"].ToString(),
                Telefono = values["Telefono"].ToString(),
                Direccion = values["Direccion"].ToString()
            });

            if (proveedor is null) throw new NullReferenceException("No se logró establecer el modelo con los valores brindados.");
        }

        /// <inheritdoc cref="IProveedorDao.Read(string)"/>
        public IEnumerable<ProveedorView> GetProveedores(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) value = null;

            IEnumerable<Proveedor> proveedores = ProveedorDao.Read(value);

            return proveedores.Select(proveedor =>
            {
                return new ProveedorView
                {
                    Id = proveedor.Id,
                    Nombre = proveedor.Nombre,
                    Telefono = proveedor.Telefono,
                    Direccion = proveedor.Direccion
                };
            });
        }

        /// <inheritdoc cref="IProveedorDao.FindById(int)"/>
        public Proveedor GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return ProveedorDao.FindById(id);
        }

        /// <summary>
        /// Actualiza la información de un registro de tipo Proveedor en la base de datos
        /// en base a la colección de valores o propiedades específicas para dicho
        /// objeto.
        /// </summary>
        /// <param name="values">Valores o propiedades del objeto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se proporcionan los valores.</exception>
        /// <exception cref="NullReferenceException">Se dispara cuando no se logró crear el objeto.</exception>
        public void Update(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "No se reconocen los valores para crear el modelo.");

            Proveedor proveedor = ProveedorDao.Update(new Proveedor
            {
                Id = (int)values["Id"],
                Nombre = values["Nombre"].ToString(),
                Telefono = values["Telefono"].ToString(),
                Direccion = values["Direccion"].ToString()
            });

            if (proveedor is null) throw new NullReferenceException("No se logró establecer el modelo con los valores brindados.");
        }

        /// <summary>
        /// Elimina la información de un registro de tipo Proveedor de la
        /// base de datos en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del Proveedor.</param>
        public void Delete(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return;
            }

            Proveedor proveedor = ProveedorDao.Delete(ProveedorDao.FindById(id));

            if (proveedor is null) Handler.Add("MODELO_NULO");
        }

        #region IServicioBase Members

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            Handler.Clear();
        }

        /// <inheritdoc cref="IServicioBase.GetErrorMessage"/>
        public string GetErrorMessage() => Handler.GetErrorMessage();

        /// <inheritdoc cref="IServicioBase.HasError"/>
        public bool HasError() => Handler.HasError();

        #endregion
    }
}
