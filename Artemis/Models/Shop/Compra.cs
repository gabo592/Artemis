using System;
using Models.Interfaces;

namespace Models.Shop
{
    /// <summary>
    /// Objeto simple de tipo Compra.
    /// </summary>
    public class Compra : IIdentity, ITransaction, IActivable, IEmpleable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="ITransaction.Fecha"/>
        public DateTime Fecha { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único del proveedor asociado a la Compra.
        /// </summary>
        public int IdProveedor { get; set; }

        /// <inheritdoc cref="IEmpleable.IdEmpleado"/>
        public int IdEmpleado { get; set; }
    }
}
