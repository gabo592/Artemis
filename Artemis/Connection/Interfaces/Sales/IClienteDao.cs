using System.Collections.Generic;
using Connection.Base;
using Models.Sales;

namespace Connection.Interfaces.Sales
{
    /// <summary>
    /// DAO del objeto Cliente.
    /// </summary>
    public interface IClienteDao : IDao<Cliente>
    {
        /// <summary>
        /// Realiza la búsqueda de los registros de tipo Cliente
        /// en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del registro.</param>
        /// <returns>Objeto de tipo Cliente que coincida con el parámetro de búsqueda.</returns>
        Cliente GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de los registros de tipo Cliente
        /// en base al valor proporcionado. Pueden ser: nombres, apellidos,
        /// teléfono, correo, etc.
        /// </summary>
        /// <param name="value">Valor a filtrar.</param>
        /// <returns>Colección de objetos de tipo Cliente que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Cliente> Read(string value);

        /// <summary>
        /// Realiza la búsqueda de los registros de tipo Cliente
        /// en base al ID del municipio proporcionado.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del municipio.</param>
        /// <returns>Colección de objetos de tipo Cliente que coincidan con la búsqueda.</returns>
        IEnumerable<Cliente> FindByIdMunicipio(int idMunicipio);
    }
}
