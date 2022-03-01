namespace Models.Interfaces
{
    /// <summary>
    /// Indica que un registro posee un identificador único.
    /// </summary>
    public interface IIdentity
    {
        /// <summary>
        /// Identificador único del registro.
        /// </summary>
        int Id { get; set; }
    }
}
