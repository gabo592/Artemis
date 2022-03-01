using Models.Interfaces;

namespace Models.Common
{
    /// <summary>
    /// Objeto simple de tipo Empleado.
    /// </summary>
    public class Empleado : IIdentity, IPerson, IActivable, IUbicable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="IPerson.PrimerNombre"/>
        public string PrimerNombre { get; set; }

        /// <inheritdoc cref="IPerson.SegundoNombre"/>
        public string SegundoNombre { get; set; }

        /// <inheritdoc cref="IPerson.PrimerApellido"/>
        public string PrimerApellido { get; set; }

        /// <inheritdoc cref="IPerson.SegundoApellido"/>
        public string SegundoApellido { get; set; }

        /// <inheritdoc cref="IPerson.Correo"/>
        public string Correo { get; set; }

        /// <summary>
        /// Documento de identidad de un ciudadano nicaragüense.
        /// </summary>
        public string Cedula { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <inheritdoc cref="IUbicable.IdMunicipio"/>
        public int IdMunicipio { get; set; }
    }
}
