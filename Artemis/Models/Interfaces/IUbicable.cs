namespace Models.Interfaces
{
    /// <summary>
    /// Indica que un registro posee una relación con un registro de ubicación.
    /// </summary>
    public interface IUbicable
    {
        /// <summary>
        /// Identificador único del municipio al que está ligado el registro.
        /// </summary>
        int IdMunicipio { get; set; }
    }
}
