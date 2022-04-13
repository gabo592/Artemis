using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis.Servicios.Base;
using Artemis.ViewModels.Common;
using Connection.Interfaces.Common;
using Common.Util;
using Models.Common;

namespace Artemis.Servicios.Common
{
    /// <summary>
    /// Clase encargada de proveer los servicios para los
    /// productos.
    /// </summary>
    internal class ProductoService : IServicioBase
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto producto.
        /// </summary>
        private readonly IProductoDao productoDao;

        /// <summary>
        /// Proveedor de servicios para las categorías.
        /// </summary>
        private readonly CategoriasService categoriasService;

        #endregion

        public ProductoService()
        {
            Handler = new ErrorHandler();
            productoDao = DaoFactory.Get<IProductoDao>(Handler);
            categoriasService = new CategoriasService();
        }

        /// <summary>
        /// Crea un nuevo registro de tipo Producto en la base de datos tomando
        /// en cuenta la colección de valores o propiedades de dicho objeto.
        /// </summary>
        /// <param name="values">Valores o propiedades del objeto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se especifican los valores o propiedades del objeto.</exception>
        public void Create(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "Los valores o propiedades del objeto no son válidos.");

            Producto producto = productoDao.Create(new Producto
            {
                Descripcion = values["Descripcion"].ToString(),
                Imagen = (Image)values["Imagen"],
                Precio = Convert.ToDecimal(values["Precio"]),
                Stock = Convert.ToInt32(values["Stock"]),
                IdCategoria = (int)values["IdCategoria"]
            });

            if (producto is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IProductoDao.Read(string)"/>
        public IEnumerable<ProductoView> GetProductos(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion)) descripcion = null;

            IEnumerable<Producto> productos = productoDao.Read(descripcion);

            return productos.Select(producto =>
            {
                var categoria = categoriasService.GetById(producto.IdCategoria);

                return new ProductoView
                {
                    Id = producto.Id,
                    Descripcion = producto.Descripcion,
                    Precio = producto.Precio,
                    Stock = producto.Stock,
                    Categoria = categoria.Nombre
                };
            });
        }

        /// <inheritdoc cref="IProductoDao.GetById(int)"/>
        public Producto GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return productoDao.GetById(id);
        }

        /// <summary>
        /// Crea un nuevo registro de tipo Producto en la base de datos tomando
        /// en cuenta la colección de valores o propiedades de dicho objeto.
        /// </summary>
        /// <param name="values">Valores o propiedades del objeto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se especifican los valores o propiedades del objeto.</exception>
        public void Update(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "Los valores o propiedades del objeto no son válidos.");

            Producto producto = productoDao.Update(new Producto
            {
                Id = (int)values["Id"],
                Descripcion = values["Descripcion"].ToString(),
                Imagen = (Image)values["Imagen"],
                Precio = (decimal)values["Precio"],
                Stock = (int)values["Stock"],
                IdCategoria = (int)values["IdCategoria"]
            });

            if (producto is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina un registro de la base de datos dado el ID de dicho registro.
        /// </summary>
        /// <param name="id">Identificador único del registro a eliminar.</param>
        public void Delete(int id)
        {
            Producto producto = productoDao.Delete(GetById(id));

            if (producto is null) Handler.Add("MODELO_NULO");
        }

        #region IServicioBase Members

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            Handler.Clear();
            categoriasService.Dispose();
        }

        /// <inheritdoc cref="IServicioBase.GetErrorMessage"/>
        public string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (categoriasService != null && categoriasService.HasError())
            {
                builder.AppendLine(categoriasService.GetErrorMessage());
            }

            return builder.ToString();
        }

        /// <inheritdoc cref="IServicioBase.HasError"/>
        public bool HasError() => Handler.HasError() || categoriasService.HasError();

        #endregion
    }
}
