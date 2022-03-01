using System;

namespace Models.Interfaces
{
    /// <summary>
    /// Indica que un registro es responsable del movimiento transaccional
    /// dentro del sistema.
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// Fecha en que se realizó el registro.
        /// </summary>
        DateTime Fecha { get; set; }
    }
}
