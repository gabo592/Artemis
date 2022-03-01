using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;

namespace Common.Util
{
    /// <summary>
    /// Clase encargada de administrar los errores que pueden surgir
    /// durante la ejecución del programa.
    /// </summary>
    public class ErrorHandler : List<string>
    {
        /// <summary>
        /// Añade el mensaje de error de una excepción.
        /// </summary>
        /// <param name="exception">Excepción producida en el sistema.</param>
        public void Add(Exception exception)
        {
            if (exception is null) return;

            if (exception.InnerException != null)
            {
                Add(exception.InnerException);
                return;
            }

            Add(exception.Message);
        }

        /// <summary>
        /// Verifica si el administrador contiene errores almacenados.
        /// </summary>
        /// <returns>Verdadero si contiene errores; de lo contrario, Falso.</returns>
        public bool HasError() => Count > 0;

        /// <summary>
        /// Obtiene los mensajes de los errores almacenados en el administrador.
        /// Dichos mensajes son agrupados como uno solo.
        /// </summary>
        /// <returns>Mensaje de error almacenado.</returns>
        public string GetErrorMessage()
        {
            if (Count == 0) return string.Empty;

            ResourceManager resourceManager = new ResourceManager(typeof(Resources.Messages));
            StringBuilder builder = new StringBuilder();

            foreach (string code in this)
            {
                string message = resourceManager.GetString(code);

                if (message is null) message = $"_{code}";

                builder.AppendLine(message);
            }

            Clear();

            return builder.ToString();
        }
    }
}
