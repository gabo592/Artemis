namespace Models.Interfaces
{
    /// <summary>
    /// Indica que un registro posee un nombre.
    /// </summary>
    public interface INameable
    {
        /// <summary>
        /// Nombre del registro.
        /// </summary>
        string Nombre { get; set; }
    }
}
