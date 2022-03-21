namespace Artemis.Servicios.Interfaces
{
    /// <summary>
    /// Indica que un objeto estará siendo visualizado por otros objetos
    /// Observadores ante cualquier cambio que éste indique.
    /// </summary>
    public interface ISujeto
    {
        /// <summary>
        /// Agrega un objeto de tipo Observador a la colección de observadores.
        /// </summary>
        /// <param name="observador">Observador a agregar.</param>
        void AgregarObservador(IObservador observador);

        /// <summary>
        /// Notifica a todos los objetos de tipo Observador que actualicen su
        /// estado.
        /// </summary>
        void Notificar();
    }
}
