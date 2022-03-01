namespace Models.Interfaces
{
    /// <summary>
    /// Indica que un registro contiene atributos de una persona natural.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Primer nombre de la persona.
        /// </summary>
        string PrimerNombre { get; set; }

        /// <summary>
        /// Segundo nombre de la persona.
        /// </summary>
        string SegundoNombre { get; set; }

        /// <summary>
        /// Primer apellido de la persona.
        /// </summary>
        string PrimerApellido { get; set; }

        /// <summary>
        /// Segundo apellido de la persona.
        /// </summary>
        string SegundoApellido { get; set; }

        /// <summary>
        /// Correo electrónico de la persona.
        /// </summary>
        string Correo { get; set; }
    }
}
