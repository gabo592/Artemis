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
        /// al valor proporcionado. Puede ser por nombre de usuario o rol.
        /// </summary>
        /// <param name="value">Valor a filtrar</param>
        /// <returns>Colección de objetos de tipo Usuario que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Usuario> Read(string value);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Usuario en base
        /// al ID del empleado proporcionado.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del empleado asociado al usuario.</param>
        /// <returns>Objeto de tipo Usuario que coincida con el parámetro de búsqueda.</returns>
        Usuario FindByIdEmpleado(int idEmpleado);

        /// <summary>
        /// Verifica en la base de datos si existe un usuario en base
        /// a las credenciales proporcionadas para realizar el login
        /// al sistema.
        /// </summary>
        /// <param name="nombre">Nombre de usuario.</param>
        /// <param name="contraseña">Contraseña del usuario.</param>
        /// <returns>Objeto de tipo usuario que coincida con las credenciales.</returns>
        Usuario Login(string nombre, string contraseña);
    }
}
