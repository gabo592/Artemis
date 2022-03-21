namespace Artemis.Servicios.Interfaces
{
    /// <summary>
    /// Indica que un objeto estará al pendiente de cualquier
    /// cambio que realice el objeto Sujeto.
    /// </summary>
    public interface IObservador
    {
        /// <summary>
        /// Actualiza el estado del objeto de tipo Observador en base a los cambios
        /// realizados por el Sujeto.
        /// </summary>
        void Actualizar();
    }
}
