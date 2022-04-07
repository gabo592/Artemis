using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using Artemis.Servicios.Base;
using Artemis.Servicios.Common;
using Artemis.ViewModels.Sales;
using Common.Util;
using Connection.Interfaces.Sales;
using Models.Sales;

namespace Artemis.Servicios.Sales
{
    /// <summary>
    /// Clase encargada de proveer los servicios para
    /// los clientes.
    /// </summary>
    internal class ClienteService : IServicioBase
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// DAO del objeto Cliente.
        /// </summary>
        private readonly IClienteDao ClienteDao;

        /// <summary>
        /// Servico de ubicaciones.
        /// </summary>
        private readonly UbicacionService UbicacionService;

        #endregion

        public ClienteService()
        {
            Handler = new ErrorHandler();
            ClienteDao = DaoFactory.Get<IClienteDao>(Handler);
            UbicacionService = new UbicacionService();
        }

        /// <summary>
        /// Inserta un nuevo registro de tipo Cliente en la base de datos, tomando
        /// en cuenta los valores proporcionados que componen al objeto.
        /// </summary>
        /// <param name="values">Valores o propiedades del objeto.</param>
        public void Create(IDictionary<string, object> values)
        {
            if (values is null)
            {
                Handler.Add("VALUES_DEFAULT");
                return;
            }

            Cliente model = new Cliente
            {
                PrimerNombre = values["PrimerNombre"].ToString(),
                SegundoNombre = values["SegundoNombre"].ToString(),
                PrimerApellido = values["PrimerApellido"].ToString(),
                SegundoApellido = values["SegundoApellido"].ToString(),
                FechaNacimiento = (DateTime)values["FechaNacimiento"],
                Correo = values["Correo"].ToString(),
                Telefono = values["Telefono"].ToString(),
                IdMunicipio = (int)values["IdMunicipio"]
            };

            if (!string.IsNullOrWhiteSpace(model.Correo))
            {
                MailAddress mailAddress = new MailAddress(model.Correo);

                if (mailAddress.Address != model.Correo)
                {
                    Handler.Add("CORREO_INCORRECTO");
                    return;
                }
            }


            model = ClienteDao.Create(model);

            if (model is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IClienteDao.Read(string)"/>
        public IEnumerable<ClienteView> GetClientes(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) value = null;

            IEnumerable<Cliente> clientes = ClienteDao.Read(value);

            return clientes.Select(cliente =>
            {
                var municipio = UbicacionService.GetMunicipio(cliente.IdMunicipio);
                var departamento = UbicacionService.GetDepartamento(municipio.IdDepartamento);

                return new ClienteView
                {
                    Id = cliente.Id,
                    Nombres = $"{cliente.PrimerNombre} {cliente.SegundoNombre}",
                    Apellidos = $"{cliente.PrimerApellido} {cliente.SegundoApellido}",
                    Nacimiento = cliente.FechaNacimiento,
                    Correo = cliente.Correo,
                    Telefono = cliente.Telefono,
                    Municipio = municipio.Nombre,
                    Departamento = departamento.Nombre
                };
            });
        }

        /// <inheritdoc cref="IClienteDao.GetById(int)"/>
        public Cliente GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return ClienteDao.GetById(id);
        }

        /// <summary>
        /// Método encargado de actualizar la información del modelo dentro de
        /// las base de datos.
        /// </summary>
        /// <param name="values">Colección de valores que conforman las propiedades del modelo.</param>
        public void Update(IDictionary<string, object> values)
        {
            if (values is null)
            {
                Handler.Add("VALUES_DEFAULT");
                return;
            }

            Cliente model = new Cliente
            {
                Id = (int)values["Id"],
                PrimerNombre = values["PrimerNombre"].ToString(),
                SegundoNombre = values["SegundoNombre"].ToString(),
                PrimerApellido = values["PrimerApellido"].ToString(),
                SegundoApellido = values["SegundoApellido"].ToString(),
                FechaNacimiento = (DateTime)values["FechaNacimiento"],
                Correo = values["Correo"].ToString(),
                Telefono = values["Telefono"].ToString(),
                IdMunicipio = (int)values["IdMunicipio"]
            };

            if (!string.IsNullOrWhiteSpace(model.Correo))
            {
                MailAddress mailAddress = new MailAddress(model.Correo);

                if (mailAddress.Address != model.Correo)
                {
                    Handler.Add("CORREO_INCORRECTO");
                    return;
                }
            }

            model = ClienteDao.Update(model);

            if (model is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Eliminar la información de un registro de la base de datos
        /// de un modelo de tipo Cliente en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del cliente.</param>
        public void Delete(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return;
            }

            Cliente cliente = ClienteDao.Delete(ClienteDao.GetById(id));

            if (cliente is null) Handler.Add("MODELO_NULO");
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

            if (UbicacionService != null && UbicacionService.HasError())
            {
                builder.AppendLine(UbicacionService.GetErrorMessage());
            }

            return builder.ToString();
        }

        /// <inheritdoc cref="IServicioBase.HasError"/>
        public bool HasError() => Handler.HasError() || UbicacionService.HasError();

        #endregion
    }
}
