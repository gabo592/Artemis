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
    /// al objeto Categoria.
    /// </summary>
    internal class CategoriaDao : BaseDao<Categoria>, ICategoriaDao
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor de la clase. Toma en cuenta la cadena de conexión
        /// a la base de datos y una instancia del administrador de errores.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión.</param>
        /// <param name="handler">Administrador de errores.</param>
        public CategoriaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Categoria Create(Categoria model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.CategoriaCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Imagen", model.Imagen }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Categoria Delete(Categoria model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.CategoriaDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="ICategoriaDao.GetById(int)"/>
        public Categoria GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CategoriaRead, new Dictionary<string, object>
            {
                {"Id", id}
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Categoria> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="ICategoriaDao.Read(string)"/>
        public IEnumerable<Categoria> Read(string nombre)
        {
            return Read(StoredProcedures.CategoriaRead, new Dictionary<string, object>
            {
                {"Nombre", nombre },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Categoria Update(Categoria model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.CategoriaUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Imagen", model.Imagen }
            }).FirstOrDefault() ?? null;
        }
    }
}
