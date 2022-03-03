namespace Connection.Constantes
{
    /// <summary>
    /// Clase encargada de contener los procedimientos almacenados
    /// a realizar dentro de la base de datos. Esta clase no puede
    /// heredarse.
    /// </summary>
    internal sealed class StoredProcedures
    {
        #region Common

        public const string CategoriaCreate = "CATEGORIA_CREATE";
        public const string CategoriaRead = "CATEGORIA_READ";
        public const string CategoriaUpdate = "CATEGORIA_UPDATE";
        public const string CategoriaDelete = "CATEGORIA_DELETE";

        public const string DepartamentoRead = "DEPARTAMENTO_READ";

        public const string EmpleadoCreate = "EMPLEADO_CREATE";
        public const string EmpleadoRead = "EMPLEADO_READ";
        public const string EmpleadoUpdate = "EMPLEADO_UPDATE";
        public const string EmpleadoDelete = "EMPLEADO_DELETE";

        public const string MunicipioRead = "MUNICIPIO_READ";

        public const string ProductoCreate = "PRODUCTO_CREATE";
        public const string ProductoRead = "PRODUCTO_READ";
        public const string ProductoUpdate = "PRODUCTO_UPDATE";
        public const string ProductoDelete = "PRODUCTO_DELETE";

        #endregion
    }
}
