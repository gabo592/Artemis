using System;

namespace Artemis.Servicios.Base
{
    /// <summary>
    /// Indica que una clase proveerá servicios para la capa
    /// de presentación.
    /// </summary>
    internal interface IServicioBase : IDisposable
    {
        /// <summary>
        /// Obtiene el o los mensajes de error almacenados en el administrador de errores.
        /// </summary>
        /// <returns>Mensaje de error.</returns>
        string GetErrorMessage();

        /// <summary>
        /// Verifica si el administrador de errrores contiene errores almacenados.
        /// </summary>
        /// <returns>Verdadero si el administrador posee errores; de lo contrario, Falso.</returns>
        bool HasError();
    }
}
