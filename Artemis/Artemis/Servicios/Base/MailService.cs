using System;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Artemis.Properties;
using Common.Util;

namespace Artemis.Servicios.Base
{
    /// <summary>
    /// Clase encargada de proveer los servicios de mensajería
    /// por correo electrónico.
    /// </summary>
    internal class MailService : IServicioBase
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// Cuenta de correo electrónico del negocio.
        /// </summary>
        private readonly string correo;

        /// <summary>
        /// Contraseña de la cuenta de correo.
        /// </summary>
        private readonly string correoPassword;

        public MailService()
        {
            Handler = new ErrorHandler();
            correo = Settings.Default.Correo;
            correoPassword = Settings.Default.CorreoPassword;
        }

        /// <summary>
        /// Envía un correo electrónico hacia el correo destino proporcionado, junto
        /// con el asunto y el mensaje a mandar.
        /// </summary>
        /// <param name="correoDestino">Correo del destinatario.</param>
        /// <param name="asunto">Asunto del correo.</param>
        /// <param name="mensaje">Mensaje del correo.</param>
        public void Send(string correoDestino, string asunto, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(correoDestino))
            {
                Handler.Add("CORREO_DESTINO_DEFAULT");
                return;
            }

            if (string.IsNullOrWhiteSpace(asunto))
            {
                Handler.Add("CORREO_ASUNTO_DEFAULT");
                return;
            }

            if (string.IsNullOrWhiteSpace(mensaje))
            {
                Handler.Add("CORREO_MENSAJE_DEFAULT");
                return;
            }

            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress(correo, "Artemis", Encoding.UTF8),
                Subject = asunto,
                Body = mensaje,
                IsBodyHtml = true,
                Priority = MailPriority.Normal
            };

            mailMessage.To.Add(correoDestino);

            SmtpClient smtpClient = new SmtpClient()
            {
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com",
                Port = 25,
                Credentials = new NetworkCredential(correo, correoPassword)
            };

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
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
