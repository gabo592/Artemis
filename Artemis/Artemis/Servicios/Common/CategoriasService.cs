using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Common.Util;
using Connection.Interfaces.Common;
using Models.Common;
using Artemis.Servicios.Base;
using Artemis.ViewModels.Common;

namespace Artemis.Servicios.Common
{
    /// <summary>
    /// Clase encargada de proveer los servicios
    /// a los objetos de tipo Categoría.
    /// </summary>
    internal class CategoriasService : IServicioBase
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto Categoría
        /// </summary>
        private readonly ICategoriaDao CategoriaDao;

        #endregion

        public CategoriasService()
        {
            Handler = new ErrorHandler();
            CategoriaDao = DaoFactory.Get<ICategoriaDao>(Handler);
        }

        /// <summary>
        /// Crea un registro de objeto de tipo Categoría en base a los valores
        /// proporcionados.
        /// </summary>
        /// <param name="values">Valores o propiedades de la Categoría.</param>
        public void Create(IDictionary<string, object> values)
        {
            string nombre = values["Nombre"].ToString();
            Image imagen = (Image)values["Imagen"];

            if (string.IsNullOrEmpty(nombre))
            {
                Handler.Add("NOMBRE_DEFAULT");
                return;
            }

            Categoria categoria = CategoriaDao.Create(new Categoria
            {
                Nombre = nombre,
                Imagen = imagen
            });

            if (categoria is null || categoria.Equals(default)) Handler.Add("CATEGORIA_DEFAULT");
        }

        /// <inheritdoc cref="ICategoriaDao.Read(string)"/>
        public IEnumerable<CategoriaView> GetCategorias(string name)
        {
            IEnumerable<Categoria> categorias = CategoriaDao.Read(name);

            return categorias.Select(categoria =>
            {
                return new CategoriaView
                {
                    Id = categoria.Id,
                    Nombre = categoria.Nombre
                };
            });
        }

        /// <inheritdoc cref="ICategoriaDao.GetById(int)"/>
        public Categoria GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return CategoriaDao.GetById(id);
        }

        /// <summary>
        /// Actualiza la información de un registro de la base de datos
        /// en base al modelo ya existente y una colección de nuevos valores.
        /// </summary>
        /// <param name="model">Modelo a actualizar.</param>
        /// <param name="values">Valores a actualizar.</param>
        public void Update(Categoria model, IDictionary<string, object> values)
        {
            if (model is null || model.Equals(default))
            {
                Handler.Add("CATEGORIA_DEFAULT");
                return;
            }

            string nombre = values["Nombre"].ToString();
            Image imagen = (Image)values["Imagen"];

            if (string.IsNullOrEmpty(nombre))
            {
                Handler.Add("NOMBRE_DEFAULT");
                return;
            }

            Categoria categoria = CategoriaDao.Update(new Categoria
            {
                Id = model.Id,
                Nombre = nombre,
                Imagen = imagen,
                Estado = model.Estado
            });

            if (categoria is null || categoria.Equals(default)) Handler.Add("CATEGORIA_DEFAULT");
        }

        /// <summary>
        /// Elimina un registro de la base de datos en base al identificador
        /// proporcionado.
        /// </summary>
        /// <param name="id">Identificador único de la Categoría.</param>
        public void Delete(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return;
            }

            Categoria categoria = GetById(id);

            if (categoria is null || categoria.Equals(default))
            {
                Handler.Add("CATEGORIA_DEFAULT");
                return;
            }

            Categoria result = CategoriaDao.Delete(categoria);

            if (result is null || result.Equals(default)) Handler.Add("CATEGORIA_DEFAULT");
        }

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            Handler.Clear();
        }

        /// <inheritdoc cref="IServicioBase.GetErrorMessage"/>
        public string GetErrorMessage() => Handler.GetErrorMessage();

        /// <inheritdoc cref="IServicioBase.HasError"/>
        public bool HasError() => Handler.HasError();
    }
}
