using System;
using Models.Interfaces;

namespace Models.Sales
{
    /// <summary>
    /// Objeto simple de tipo Venta.
    /// </summary>
    public class Venta : IIdentity, ITransaction, IActivable, IEmpleable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="ITransaction.Fecha"/>
        public DateTime Fecha { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único del cliente asociado al registro de Venta.
        /// </summary>
        public int IdCliente { get; set; }

        /// <inheritdoc cref="IEmpleable.IdEmpleado"/>
        public int IdEmpleado { get; set; }
    }
}
