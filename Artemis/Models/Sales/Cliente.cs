using System;
using Models.Interfaces;

namespace Models.Sales
{
    /// <summary>
    /// Objeto simple de tipo Cliente.
    /// </summary>
    public class Cliente : IIdentity, IPerson, IActivable, IUbicable
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

        /// <summary>
        /// Fecha de nacimiento del cliente.
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <inheritdoc cref="IPerson.Correo"/>
        public string Correo { get; set; }

        /// <summary>
        /// Número telefónico del cliente.
        /// </summary>
        public string Telefono { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <inheritdoc cref="IUbicable.IdMunicipio"/>
        public int IdMunicipio { get; set; }
    }
}
