using Common.Util;
using Models.Interfaces;

namespace Connection.Base
{
    /// <summary>
    /// Clase encargada de realizar las validaciones a los modelos que van a interactuar
    /// con la base de datos.
    /// </summary>
    internal static class Validaciones
    {
        /// <summary>
        /// Método encargado de validar los modelos que van a interactuar con la base de datos,
        /// teniendo en cuenta la operación que desean realizar dentro de la base de datos.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a validar.</typeparam>
        /// <param name="model">Modelo a validar.</param>
        /// <param name="handler">Administrador de errores.</param>
        /// <param name="operacion">Operación a realizar.</param>
        /// <returns>Verdadero si el administrador de errores contiene errores almacenados; de lo contrario, Falso.</returns>
        public static bool Validar<TModel>(TModel model, ErrorHandler handler, Operaciones operacion = Operaciones.DEFAULT)
        {
            if (model == null)
            {
                handler.Add("MODELO_NULO");
                return true;
            }

            if ((operacion.Equals(Operaciones.UPDATE) || operacion.Equals(Operaciones.DELETE)) && model is IActivable activable)
            {
                if (!activable.Estado)
                {
                    handler.Add("ESTADO_DESACTIVADO");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is IEmpleable empleable)
            {
                if (empleable.IdEmpleado.Equals(default) || empleable.IdEmpleado < 0)
                {
                    handler.Add("ID_EMPLEADO_DEFAULT");
                }
            }

            if ((operacion.Equals(Operaciones.UPDATE) || operacion.Equals(Operaciones.DELETE)) && model is IIdentity identity)
            {
                if (identity.Id.Equals(default) || identity.Id < 0)
                {
                    handler.Add("ID_DEFAULT");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is INameable nameable)
            {
                if (string.IsNullOrEmpty(nameable.Nombre))
                {
                    handler.Add("NOMBRE_DEFAULT");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is IPerson person)
            {
                if (string.IsNullOrEmpty(person.PrimerNombre))
                {
                    handler.Add("PRIMER_NOMBRE_DEFAULT");
                }

                if (person.PrimerNombre.Length > 50)
                {
                    handler.Add("PRIMER_NOMBRE_LONGITUD_EXCEDIDA");
                }

                if (person.SegundoNombre.Length > 50)
                {
                    handler.Add("SEGUNDO_NOMBRE_LONGITUD_EXCEDIDA");
                }

                if (string.IsNullOrEmpty(person.PrimerApellido))
                {
                    handler.Add("PRIMER_APELLIDO_DEFAULT");
                }

                if (person.SegundoApellido.Length > 50)
                {
                    handler.Add("SEGUNDO_APELLIDO_LONGITUD_EXCEDIDA");
                }

                if (person.Correo.Length > 70)
                {
                    handler.Add("CORREO_LONGITUD_EXCEDIDA");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is ISecurity security)
            {
                if (string.IsNullOrEmpty(security.Contraseña))
                {
                    handler.Add("CONTRASEÑA_DEFAULT");
                }

                if (security.Contraseña.Length < 5)
                {
                    handler.Add("CONTRASEÑA_CORTA");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is ITransaction transaction)
            {
                if (transaction.Fecha.Equals(default))
                {
                    handler.Add("FECHA_DEFAULT");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is ITransactionDetail transactionDetail)
            {
                if (transactionDetail.IdProducto.Equals(default) || transactionDetail.IdProducto < 0)
                {
                    handler.Add("ID_PRODUCTO_DEFAULT");
                }

                if (transactionDetail.Cantidad.Equals(default) || transactionDetail.Cantidad < 0)
                {
                    handler.Add("CANTIDAD_DEFAULT");
                }

                if (transactionDetail.Descuento < 0)
                {
                    handler.Add("DESCUENTO_NEGATIVO");
                }

                if (transactionDetail.CostoEnvio < 0)
                {
                    handler.Add("COSTO_ENVIO_NEGATIVO");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is IUbicable ubicable)
            {
                if (ubicable.IdMunicipio.Equals(default) || ubicable.IdMunicipio < 0)
                {
                    handler.Add("ID_MUNICIPIO_DEFAULT");
                }
            }

            return handler.HasError();
        }

        /// <summary>
        /// Operaciones que realizan los modelos y requieren de previa validación.
        /// </summary>
        internal enum Operaciones
        {
            DEFAULT = 0,
            CREATE = 1,
            UPDATE = 2,
            DELETE = 3
        }
    }
}
