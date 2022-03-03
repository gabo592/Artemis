using System;
using System.Collections.Generic;
using System.Linq;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Common;
using Common.Util;
using Models.Common;

namespace Connection.Common
{
    /// <summary>
    /// Clase encargada de proveer el acceso a la base de datos
    /// al objeto Producto.
    /// </summary>
    internal class ProductoDao : BaseDao<Producto>, IProductoDao
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
        public ProductoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Producto Create(Producto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.ProductoCreate, new Dictionary<string, object>
            {
                {"Descripcion", model.Descripcion },
                {"Imagen", model.Imagen },
                {"Precio", model.Precio },
                {"Stock", model.Stock },
                {"IdCategoria", model.IdCategoria }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Producto Delete(Producto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.ProductoDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IProductoDao.GetById(int)"/>
        public Producto GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IProductoDao.GetByIdCategoria(int)"/>
        public IEnumerable<Producto> GetByIdCategoria(int idCategoria)
        {
            if (idCategoria.Equals(default) || idCategoria < 0)
            {
                Handler.Add("ID_CATEGORIA_DEFAULT");
                return Enumerable.Empty<Producto>();
            }

            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Estado", 1 },
                {"IdCategoria", idCategoria }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Producto> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IProductoDao.Read(string)"/>
        public IEnumerable<Producto> Read(string descripcion)
        {
            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Descripcion", descripcion },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IProductoDao.Read(decimal)"/>
        public IEnumerable<Producto> Read(decimal precio)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IProductoDao.Read(decimal, decimal)"/>
        public IEnumerable<Producto> Read(decimal precioBajo, decimal precioAlto)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IProductoDao.Read(int)"/>
        public IEnumerable<Producto> Read(int stock)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Producto Update(Producto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.ProductoUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Descripcion", model.Descripcion },
                {"Imagen", model.Imagen },
                {"Precio", model.Precio },
                {"Stock", model.Stock },
                {"IdCategoria", model.IdCategoria }
            }).FirstOrDefault() ?? null;
        }
    }
}
