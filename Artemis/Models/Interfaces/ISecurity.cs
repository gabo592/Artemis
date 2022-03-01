namespace Models.Interfaces
{
    /// <summary>
    /// Indica que un registro posee un campo de seguridad como una contraseña.
    /// </summary>
    public interface ISecurity
    {
        /// <summary>
        /// Contraseña que protege al registro.
        /// </summary>
        string Contraseña { get; set; }
    }
}
