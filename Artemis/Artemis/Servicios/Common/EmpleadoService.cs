using System;
using System.Collections.Generic;
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
    /// Empleados.
    /// </summary>
    internal class EmpleadoService : IServicioBase
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto Empleado.
        /// </summary>
        private readonly IEmpleadoDao EmpleadoDao;

        /// <summary>
        /// Servicio de ubicación.
        /// </summary>
        private readonly UbicacionService ubicacionService;

        public EmpleadoService()
        {
            Handler = new ErrorHandler();
            EmpleadoDao = DaoFactory.Get<IEmpleadoDao>(Handler);
            ubicacionService = new UbicacionService();
        }

        /// <summary>
        /// Crea un nuevo registro de tipo Empleado en la base de datos en base
        /// a la colección de valores o propiedades del mismo.
        /// </summary>
        /// <param name="values">Valores o propiedades del modelo.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de valores o propiedades del empleado no se especifican.</exception>
        public void Create(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "La colección de valores o propiedades del modelo no puede ser nula.");

            Empleado empleado = EmpleadoDao.Create(new Empleado
            {
                PrimerNombre = values["PrimerNombre"].ToString(),
                SegundoNombre = values["SegundoNombre"].ToString(),
                PrimerApellido = values["PrimerApellido"].ToString(),
                SegundoApellido = values["SegundoApellido"].ToString(),
                Correo = values["Correo"].ToString(),
                Cedula = values["Cedula"].ToString(),
                IdMunicipio = (int)values["IdMunicipio"]
            });

            if (empleado is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IEmpleadoDao.GetById(int)"/>
        public Empleado GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return EmpleadoDao.GetById(id);
        }

        /// <inheritdoc cref="IEmpleadoDao.Read(string)"/>
        public IEnumerable<EmpleadoView> GetEmpleados(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) value = null;

            IEnumerable<Empleado> empleados = EmpleadoDao.Read(value);

            return empleados.Select(empleado =>
            {
                var municipio = ubicacionService.GetMunicipio(empleado.IdMunicipio);
                var departamento = ubicacionService.GetDepartamento(municipio.IdDepartamento);

                return new EmpleadoView
                {
                    Id = empleado.Id,
                    Nombres = $"{empleado.PrimerNombre} {empleado.SegundoNombre}",
                    Apellidos = $"{empleado.PrimerApellido} {empleado.SegundoApellido}",
                    Correo = empleado.Correo,
                    Cedula = empleado.Cedula,
                    Municipio = municipio.Nombre,
                    Departamento = departamento.Nombre
                };
            });
        }

        /// <summary>
        /// Actualiza un registro de tipo Empleado de la base de datos en base
        /// a la colección de valores o propiedades del mismo.
        /// </summary>
        /// <param name="values">Valores o propiedades del modelo.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de valores o propiedades del empleado no se especifican.</exception>
        public void Update(IDictionary<string, object> values)
        {
            if (values is null) throw new ArgumentNullException(nameof(values), "La colección de valores o propiedades del modelo no puede ser nula.");

            Empleado empleado = EmpleadoDao.Update(new Empleado
            {
                Id = (int)values["Id"],
                PrimerNombre = values["PrimerNombre"].ToString(),
                SegundoNombre = values["SegundoNombre"].ToString(),
                PrimerApellido = values["PrimerApellido"].ToString(),
                SegundoApellido = values["SegundoApellido"].ToString(),
                Correo = values["Correo"].ToString(),
                Cedula = values["Cedula"].ToString(),
                IdMunicipio = (int)values["IdMunicipio"]
            });

            if (empleado is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina toda la información de un modelo dentro de la base de datos
        /// en base al ID del empleado a eliminar.
        /// </summary>
        /// <param name="id">Identificador único del empleado a eliminar.</param>
        public void Delete(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return;
            }

            Empleado empleado = EmpleadoDao.Delete(GetById(id));

            if (empleado is null) Handler.Add("MODELO_NULO");
        }

        #region IServicioBase Members

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            Handler.Clear();
        }

        /// <inheritdoc cref="IServicioBase.GetErrorMessage"/>
        public string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (ubicacionService != null && ubicacionService.HasError())
            {
                builder.AppendLine(ubicacionService.GetErrorMessage());
            }

            return builder.ToString();
        }

        /// <inheritdoc cref="IServicioBase.HasError"/>
        public bool HasError() => Handler.HasError() || ubicacionService.HasError();

        #endregion
    }
}
