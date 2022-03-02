using System;
using System.Collections.Generic;
using Connection.Base;
using Models.Sales;

namespace Connection.Interfaces.Sales
{
    /// <summary>
    /// DAO del objeto Venta.
    /// </summary>
    public interface IVentaDao : IDao<Venta>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Venta en base
        /// al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único de la venta.</param>
        /// <returns>Objeto de tipo Venta que coincida con el parámetro de búsqueda.</returns>
        Venta FindById(int id);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Venta en base
        /// a la fecha proporcionada.
        /// </summary>
        /// <param name="fecha">Fecha de la venta.</param>
        /// <returns>Colección de objetos de tipo Venta que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Venta> Read(DateTime fecha);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Venta en base
        /// al ID del cliente proporcionado.
        /// </summary>
        /// <param name="idCliente">Identificador único del cliente.</param>
        /// <returns>Colección de objetos de tipo Venta que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Venta> FindByIdCliente(int idCliente);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Venta en base
        /// al ID del empleado proporcionado.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del empleado.</param>
        /// <returns>Colección de objetos de tipo Venta que coincidan con el parámetro de búsqueda.</returns>
        IEnumerable<Venta> FindByIdEmpleado(int idEmpleado);
    }
}
