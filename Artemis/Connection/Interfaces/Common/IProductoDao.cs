using System.Collections.Generic;
using Connection.Base;
using Models.Common;

namespace Connection.Interfaces.Common
{
    /// <summary>
    /// DAO del objeto Producto.
    /// </summary>
    public interface IProductoDao : IDao<Producto>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Producto en
        /// base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del producto.</param>
        /// <returns>Objeto de tipo Producto que coincida con la búsqueda.</returns>
        Producto GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Producto en
        /// base a la descripción proporcionada.
        /// </summary>
        /// <param name="descripcion">Descripción del producto</param>
        /// <returns>Colección de objetos de tipo Producto que coincidan con la búsqueda.</returns>
        IEnumerable<Producto> Read(string descripcion);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Producto en
        /// base al precio proporcionado.
        /// </summary>
        /// <param name="precio">Precio del producto.</param>
        /// <returns>Colección de objetos de tipo Producto que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Producto> Read(decimal precio);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Producto en
        /// base al intervalo de precios proporcionado.
        /// </summary>
        /// <param name="precioBajo">Precio más bajo del producto.</param>
        /// <param name="precioAlto">Precio más alto del producto.</param>
        /// <returns>Colección de objetos de tipo Producto que coincidan con el intervalo de búsqueda.</returns>
        IEnumerable<Producto> Read(decimal precioBajo, decimal precioAlto);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Producto
        /// en base a la cantidad de stock en inventario.
        /// </summary>
        /// <param name="stock">Cantidad de artículos en el inventario.</param>
        /// <returns>Colección de objetos de tipo Producto que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Producto> Read(int stock);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Producto
        /// en base al ID de la categoría proporcionado.
        /// </summary>
        /// <param name="idCategoria">Identificador único de la categoría.</param>
        /// <returns>Colección de objetos de tipo Producto que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Producto> GetByIdCategoria(int idCategoria);
    }
}
