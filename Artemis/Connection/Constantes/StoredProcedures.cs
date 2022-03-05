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

        #region Identity

        public const string UsuarioCreate = "USUARIO_CREATE";
        public const string UsuarioRead = "USUARIO_READ";
        public const string UsuarioUpdate = "USUARIO_UPDATE";
        public const string UsuarioDelete = "USUARIO_DELETE";
        public const string UsuarioLogin = "USUARIO_LOGIN";

        #endregion

        #region Sales

        public const string ClienteCreate = "CLIENTE_CREATE";
        public const string ClienteRead = "CLIENTE_READ";
        public const string ClienteUpdate = "CLIENTE_UPDATE";
        public const string ClienteDelete = "CLIENTE_DELETE";

        public const string DetalleVentaCreate = "DETALLE_VENTA_CREATE";
        public const string DetalleVentaRead = "DETALLE_VENTA_READ";
        public const string DetalleVentaUpdate = "DETALLE_VENTA_UPDATE";
        public const string DetalleVentaDelete = "DETALLE_VENTA_DELETE";

        public const string VentaCreate = "VENTA_CREATE";
        public const string VentaRead = "VENTA_READ";
        public const string VentaUpdate = "VENTA_UPDATE";
        public const string VentaDelete = "VENTA_DELETE";

        #endregion

        #region Shop

        public const string CompraCreate = "COMPRA_CREATE";
        public const string CompraRead = "COMPRA_READ";
        public const string CompraUpdate = "COMPRA_UPDATE";
        public const string CompraDelete = "COMPRA_DELETE";

        public const string DetalleCompraCreate = "DETALLE_COMPRA_CREATE";
        public const string DetalleCompraRead = "DETALLE_COMPRA_READ";
        public const string DetalleCompraUpdate = "DETALLE_COMPRA_UPDATE";
        public const string DetalleCompraDelete = "DETALLE_COMPRA_DELETE";

        public const string ProveedorCreate = "PROVEEDOR_CREATE";
        public const string ProveedorRead = "PROVEEDOR_READ";
        public const string ProveedorUpdate = "PROVEEDOR_UPDATE";
        public const string ProveedorDelete = "PROVEEDOR_DELETE";

        #endregion
    }
}
