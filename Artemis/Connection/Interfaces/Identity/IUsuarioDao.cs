using System.Collections.Generic;
using Connection.Base;
using Models.Identity;

namespace Connection.Interfaces.Identity
{
    /// <summary>
    /// DAO del objeto Usuario.
    /// </summary>
    public interface IUsuarioDao : IDao<Usuario>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Usuario en base
        /// al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del usuario.</param>
        /// <returns>Objeto de tipo Usuario que coincida con el parámetro de búsqueda.</returns>
        Usuario FindById(int id);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Usuario en base
        /// al rol proporcionado.
        /// </summary>
        /// <param name="rol">Rol o papel que juega el usuario dentro del sistema.</param>
        /// <returns>Colección de objetos de tipo Empleado que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Usuario> FindByRol(string rol);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Usuario en base
        /// al nombre proporcionado.
        /// </summary>
        /// <param name="name">Nombre de usuario.</param>
        /// <returns>Colección de objetos de tipo Usuario que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Usuario> FindByName(string name);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Usuario en base
        /// al ID del empleado proporcionado.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del empleado asociado al usuario.</param>
        /// <returns>Objeto de tipo Usuario que coincida con el parámetro de búsqueda.</returns>
        Usuario FindByIdEmpleado(int idEmpleado);
    }
}
