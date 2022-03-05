using System;
using System.Collections.Generic;
using System.Reflection;
using Connection.Common;
using Connection.Identity;
using Connection.Interfaces.Common;
using Connection.Interfaces.Identity;
using Connection.Interfaces.Sales;
using Connection.Interfaces.Shop;
using Connection.Sales;
using Connection.Shop;
using Common.Util;

namespace Connection
{
    /// <summary>
    /// Clase encargada de fabricar el DAO del tipo
    /// esepcificado.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Mapping de todos los DAO reconocidos y administrados por el sistema.
        /// </summary>
        private static readonly IDictionary<Type, Type> Dao = new Dictionary<Type, Type>
        {
            //Common
            {typeof(ICategoriaDao), typeof(CategoriaDao) },
            {typeof(IDepartamentoDao), typeof(DepartamentoDao) },
            {typeof(IEmpleadoDao), typeof(EmpleadoDao) },
            {typeof(IMunicipioDao), typeof(MunicipioDao) },
            {typeof(IProductoDao), typeof(ProductoDao) },

            //Identity
            {typeof(IUsuarioDao), typeof(UsuarioDao) },

            //Sales
            {typeof(IClienteDao), typeof(ClienteDao) },
            {typeof(IDetalleVentaDao), typeof(DetalleVentaDao) },
            {typeof(IVentaDao), typeof(VentaDao) },

            //Shop
            {typeof(ICompraDao), typeof(CompraDao) },
            {typeof(IDetalleCompraDao), typeof(DetalleCompraDao) },
            {typeof(IProveedorDao), typeof(ProveedorDao) }
        };

        /// <summary>
        /// Realiza la invocación de un DAO en base al mapping ya configurado.
        /// </summary>
        /// <typeparam name="TDao">Tipo de DAO a invocar.</typeparam>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <param name="handler">Administrador de errores.</param>
        /// <returns>El tipo de DAO a invocar.</returns>
        /// <exception cref="ArgumentException">Se dispara cuando el DAO no se encuentra mapeado.</exception>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se logra obtener un constructor que cumpla con los requisitos del DAO.</exception>
        public static TDao Invoke<TDao>(string connectionString, ErrorHandler handler)
        {
            if (!Dao.TryGetValue(typeof(TDao), out Type type)) throw new ArgumentException("El DAO a invocar no se encuentra mapeado.");

            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string), typeof(ErrorHandler) });

            if (constructor is null) throw new ArgumentNullException("El DAO a invocar no tiene configurado un constructor que admita la cadena de conexión y una instancia del administrador de errores.");

            return (TDao)constructor.Invoke(new object[] { connectionString, handler });
        }
    }
}
