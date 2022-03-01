namespace Models.Interfaces
{
    /// <summary>
    /// Indica que un registro puede ser activado o desactivado.
    /// </summary>
    public interface IActivable
    {
        /// <summary>
        /// Estado del registro. Puede alternar entre activo e inactivo.
        /// </summary>
        bool Estado { get; set; }
    }
}
