using System.Collections.Generic;

namespace Connection.Base
{
    /// <summary>
    /// Indica que una clase implementará los métodos para realizar un CRUD
    /// en una base de datos.
    /// </summary>
    /// <typeparam name="TModel">Tipo de modelo que interactúa con la base de datos.</typeparam>
    public interface IDao<TModel> where TModel : new()
    {
        /// <summary>
        /// Crea un nuevo registro en la base de datos del tipo de modelo especificado.
        /// </summary>
        /// <param name="model">Modelo a insertar en la base de datos.</param>
        /// <returns>Modelo ya registrado dentro de la base de datos.</returns>
        TModel Create(TModel model);

        /// <summary>
        /// Obtiene una colección de modelos del tipo especificado.
        /// </summary>
        /// <returns>Colección de modelos del tipo especificado que se encuentren en la base de datos.</returns>
        IEnumerable<TModel> Read();

        /// <summary>
        /// Actualiza un registro en la base de datos del tipo de modelo especificado.
        /// </summary>
        /// <param name="model">Modelo a actualizar en la base de datos.</param>
        /// <returns>Modelo ya actualizado en la base de datos.</returns>
        TModel Update(TModel model);

        /// <summary>
        /// Elimina un registro en la base de datos del tipo de modelo especificado.
        /// </summary>
        /// <param name="model">Modelo a eliminar en la base de datos.</param>
        /// <returns>Modelo ya eliminado de la base de datos.</returns>
        TModel Delete(TModel model);
    }
}
