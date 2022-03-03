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
    /// al objeto Departamento.
    /// </summary>
    internal class DepartamentoDao : BaseDao<Departamento>, IDepartamentoDao
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
        public DepartamentoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Departamento Create(Departamento model)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Departamento Delete(Departamento model)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDepartamentoDao.GetById(int)"/>
        public Departamento GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DepartamentoRead, new Dictionary<string, object>
            {
                {"Id", id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Departamento> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IDepartamentoDao.Read(string)"/>
        public IEnumerable<Departamento> Read(string nombre)
        {
            return Read(StoredProcedures.DepartamentoRead, new Dictionary<string, object>
            {
                {"Nombre", nombre }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Departamento Update(Departamento model)
        {
            throw new NotImplementedException();
        }
    }
}
