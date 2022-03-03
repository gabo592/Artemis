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
    /// al objeto Municipio.
    /// </summary>
    internal class MunicipioDao : BaseDao<Municipio>, IMunicipioDao
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
        public MunicipioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        #endregion

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Municipio Create(Municipio model)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Municipio Delete(Municipio model)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IMunicipioDao.GetById(int)"/>
        public Municipio GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"Id", id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IMunicipioDao.GetByIdDepartamento(int)"/>
        public IEnumerable<Municipio> GetByIdDepartamento(int idDepartamento)
        {
            if (idDepartamento.Equals(default) || idDepartamento < 0)
            {
                Handler.Add("ID_DEPARTAMENTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"IdDepartamento", idDepartamento }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Municipio> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IMunicipioDao.Read(string)"/>
        public IEnumerable<Municipio> Read(string nombre)
        {
            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"Nombre", nombre }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Municipio Update(Municipio model)
        {
            throw new NotImplementedException();
        }
    }
}
