using System;
using System.Collections.Generic;
using System.Linq;
using Artemis.Servicios.Base;
using Artemis.ViewModels.Common;
using Common.Util;
using Connection.Interfaces.Common;
using Models.Common;

namespace Artemis.Servicios.Common
{
    /// <summary>
    /// Clase encargada de proveer los servicios de ubicación
    /// para los demás catálogos.
    /// </summary>
    internal class UbicacionService : IServicioBase
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto Departamento.
        /// </summary>
        private readonly IDepartamentoDao DepartamentoDao;

        /// <summary>
        /// DAO del objeto Municipio.
        /// </summary>
        private readonly IMunicipioDao MunicipioDao;

        #endregion

        public UbicacionService()
        {
            Handler = new ErrorHandler();
            DepartamentoDao = DaoFactory.Get<IDepartamentoDao>(Handler);
            MunicipioDao = DaoFactory.Get<IMunicipioDao>(Handler);
        }

        /// <inheritdoc cref="IDepartamentoDao.Read(string)"/>
        public IEnumerable<Departamento> GetDepartamentos(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) nombre = null;

            return DepartamentoDao.Read(nombre);
        }

        /// <inheritdoc cref="IMunicipioDao.GetByIdDepartamento(int)"/>
        public IEnumerable<Municipio> GetMunicipios(int idDepartamento)
        {
            if (idDepartamento.Equals(default))
            {
                Handler.Add("ID_DEPARTAMENTO_DEFAULT");
                return Enumerable.Empty<Municipio>();
            }

            return MunicipioDao.GetByIdDepartamento(idDepartamento);
        }

        /// <summary>
        /// Obtiene un registro de tipo Departamento en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del Departamento.</param>
        /// <returns>Objeto de tipo Departamento que coincida con el filtro de búsqueda.</returns>
        public Departamento GetDepartamento(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return DepartamentoDao.GetById(id);
        }

        /// <summary>
        /// Obtiene un registro de tipo Municipio en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del Municipio.</param>
        /// <returns>Objeto de tipo Municipio que coincida con el filtro de búsqueda.</returns>
        public Municipio GetMunicipio(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return MunicipioDao.GetById(id);
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
