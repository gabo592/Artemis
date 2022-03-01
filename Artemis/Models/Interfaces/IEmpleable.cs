namespace Models.Interfaces
{
    /// <summary>
    /// Indica que a un registro se le pueden asignar Empleados.
    /// </summary>
    public interface IEmpleable
    {
        /// <summary>
        /// Identificador único del empleado que está relacionado al registro.
        /// </summary>
        int IdEmpleado { get; set; }
    }
}
