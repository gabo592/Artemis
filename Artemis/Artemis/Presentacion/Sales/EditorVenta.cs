using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Artemis.Servicios.Base;
using Artemis.Servicios.Common;
using Artemis.Servicios.Interfaces;
using Artemis.Servicios.Sales;
using Artemis.ViewModels.Common;
using Artemis.ViewModels.Sales;
using Models.Common;
using Models.Sales;

namespace Artemis.Presentacion.Sales
{
    public partial class EditorVenta : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Objeto simple de tipo Venta
        /// </summary>
        private readonly Venta Venta;

        /// <summary>
        /// Lista de registros de Detalle de Venta asociados a la venta
        /// a editar.
        /// </summary>
        private List<DetalleVentaView> Detalles;

        /// <summary>
        /// Proveedor de servicios para las ventas.
        /// </summary>
        private VentaService VentaService;

        /// <summary>
        /// Proveedor de servicios para los Detalles de Ventas.
        /// </summary>
        private DetalleVentaService DetalleVentaService;

        /// <summary>
        /// Proveedor de servicios para los empleados.
        /// </summary>
        private EmpleadoService EmpleadoService;

        /// <summary>
        /// Proveedor de servicios para los clientes.
        /// </summary>
        private ClienteService ClienteService;

        /// <summary>
        /// Proveedor de servicios para los productos.
        /// </summary>
        private ProductoService ProductoService;

        /// <summary>
        /// Objeto simple de tipo Empleado relacionado a esta venta.
        /// </summary>
        private Empleado Empleado;

        /// <summary>
        /// Lista de observadores asociados a esta clase.
        /// </summary>
        private List<IObservador> Observadores;

        #endregion

        public EditorVenta(Venta venta)
        {
            InitializeComponent();
            Venta = venta;
            InitComponents();
            LoadInformation();
        }

        private void InitComponents()
        {
            VentaService = new VentaService();
            DetalleVentaService = new DetalleVentaService();
            EmpleadoService = new EmpleadoService();
            ClienteService = new ClienteService();
            ProductoService = new ProductoService();
            Empleado = EmpleadoService.GetById(Sesion.Usuario.IdEmpleado);
            Observadores = new List<IObservador>();

            dtVenta.Enabled = !(Venta is null);
        }

        #region Events

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteView cliente = GetSelected<ClienteView>(dgvClientes);
            DetalleVentaView[] detalleVentaViews = (DetalleVentaView[])dgvCarrito.DataSource;

            IDictionary<string, object> values = new Dictionary<string, object>
            {
                {"Fecha", dtVenta.Value },
                {"IdCliente", cliente.Id },
                {"IdEmpleado", Empleado.Id }
            };

            try
            {
                if (Venta is null)
                {
                    Venta result = VentaService.Create(values);

                    if (VentaService.HasError())
                    {
                        MessageBox.Show(this, VentaService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    } 

                    DetalleVentaService.Create(result.Id, detalleVentaViews);

                    if (DetalleVentaService.HasError())
                    {
                        MessageBox.Show(this, DetalleVentaService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Notificar();
                    Limpiar();

                    return;
                }

                values.Add("Id", Venta.Id);

                VentaService.Update(values);

                if (VentaService.HasError())
                {
                    MessageBox.Show(this, VentaService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DetalleVentaService.Update(Venta.Id, detalleVentaViews);

                if (DetalleVentaService.HasError())
                {
                    MessageBox.Show(this, DetalleVentaService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBuscarCliente_TextChange(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ClienteService.GetClientes(txtBuscarCliente.Text).ToArray();
        }

        private void TxtBuscarProducto_TextChange(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ProductoService.GetProductos(txtBuscarProducto.Text).ToArray();
        }

        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            ProductoView productoView = GetSelected<ProductoView>(dgvProductos);

            if (productoView is null)
            {
                MessageBox.Show(this, $"No se logró encontrar el producto con ID: {productoView.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetalleVentaView detalleVentaView = new DetalleVentaView
            {
                Id = productoView.Id,
                Producto = productoView.Descripcion,
                Precio = productoView.Precio,
                Cantidad = (int)numCantidadProducto.Value,
                Descuento = (float)(numDescuentoProducto.Value / 100),
                Envio = numCostoEnvio.Value
            };

            AddToCarrito(detalleVentaView);

            LoadDgvCarrito();

            LoadTxtToPay();
        }

        private void BtnEliminarCarrito_Click(object sender, EventArgs e)
        {
            DetalleVentaView detalleVentaView = GetSelected<DetalleVentaView>(dgvCarrito);

            if (detalleVentaView is null)
            {
                MessageBox.Show(this, $"No se logró encontrar el Detalle de Venta con ID de producto: {detalleVentaView.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el Detalle de Venta con ID de producto: {detalleVentaView.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            if (Venta is null)
            {
                Detalles.Remove(detalleVentaView);
                LoadDgvCarrito();
                LoadTxtToPay();
                return;
            }

            try
            {
                DetalleVentaService.Delete(Venta.Id, detalleVentaView.Id);

                if (DetalleVentaService.HasError())
                {
                    MessageBox.Show(this, DetalleVentaService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadDetalles();
                LoadDgvCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoView productoView = GetSelected<ProductoView>(dgvProductos);

            if (productoView is null)
            {
                MessageBox.Show(this, $"No se logró encontrar el producto con ID: {productoView.Id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = ProductoService.GetById(productoView.Id);

            if (producto is null) return;

            txtPrecioProducto.Text = $"C$ {producto.Precio}";
            numCantidadProducto.Maximum = Convert.ToDecimal(producto.Stock);
        }

        #endregion

        #region Generic Methods

        /// <summary>
        /// Obtiene el modelo de tipo especificado seleccionado del DataGridView indicado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo contenido en el DataGridView.</typeparam>
        /// <param name="dataGridView">DataGridView en donde se encontrará el seleccionado.</param>
        /// <returns>Primer modelo seleccionado del DataGridView especificado.</returns>
        private TModel GetSelected<TModel>(DataGridView dataGridView) where TModel : new()
        {
            if (dataGridView.SelectedRows.Count == 0) return default;

            TModel[] models = (TModel[])dataGridView.DataSource;

            return models[dataGridView.SelectedRows[0].Index];
        }

        #endregion

        #region Load Methods

        /// <summary>
        /// Carga la información de la venta a editar en el formulario. En caso
        /// de no existir, carga el formulario por defecto.
        /// </summary>
        private void LoadInformation()
        {
            txtNombreEmpleado.Text = $"{Empleado.PrimerNombre} {Empleado.PrimerApellido}";
            dgvClientes.DataSource = ClienteService.GetClientes(string.Empty).ToArray();
            dgvProductos.DataSource = ProductoService.GetProductos(string.Empty).ToArray();
            LoadDetalles();
            dgvCarrito.DataSource = Detalles.ToArray();
            LoadTxtToPay();
        }

        /// <summary>
        /// Carga la lista de objetos de tipo Detalle de Venta en dependencia si el objeto
        /// Venta a editar existe o no.
        /// </summary>
        private void LoadDetalles()
        {
            if (Venta is null)
            {
                Detalles = new List<DetalleVentaView>();
                return;
            }

            Detalles = DetalleVentaService.GetDetalleVentas(Venta.Id).ToList();
        }

        /// <summary>
        /// Carga la información del DataGridView Carrito con los elementos de la lista de
        /// detalles de venta contenidos en el editor.
        /// </summary>
        private void LoadDgvCarrito()
        {
            dgvCarrito.DataSource = Detalles.ToArray();
        }

        /// <summary>
        /// Carga la información a mostrar en los txt de subtotal, iva, y total.
        /// </summary>
        private void LoadTxtToPay()
        {
            double subtotal = Convert.ToDouble(CalculateSubTotal());
            double iva = Convert.ToDouble(CalculateIva(Convert.ToDecimal(subtotal)));
            double total = subtotal + iva;

            txtSubTotal.Text = $"Subtotal: C$ {subtotal}";
            txtIva.Text = $"IVA (15%): C$ {iva}";
            txtTotal.Text = $"Total: C$ {total}";
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// Agrega o modifica un objeto de tipo DetalleVentaView al carrito de compras del cliente.
        /// </summary>
        /// <param name="detalleVentaView">Modelo a agregar o modificar.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando el modelo no es proporcionado.</exception>
        private void AddToCarrito(DetalleVentaView detalleVentaView)
        {
            if (detalleVentaView is null) throw new ArgumentNullException(nameof(detalleVentaView), "El modelo a agregar al carrito no puede ser nulo.");

            foreach (DetalleVentaView view in Detalles)
            {
                if (view.Id == detalleVentaView.Id)
                {
                    view.Precio = detalleVentaView.Precio;
                    view.Cantidad += detalleVentaView.Cantidad;
                    view.Descuento = detalleVentaView.Descuento;
                    view.Envio = detalleVentaView.Envio;
                    return;
                }
            }

            Detalles.Add(detalleVentaView);
        }

        /// <summary>
        /// Calcula el subtotal a pagar por parte del cliente del carrito de compras.
        /// </summary>
        /// <returns>Subtotal a pagar por el cliente.</returns>
        private decimal CalculateSubTotal()
        {
            decimal subTotal = 0;

            foreach (DetalleVentaView value in Detalles)
            {
                subTotal += (value.Precio * value.Cantidad) - (value.Precio * value.Cantidad * Convert.ToDecimal(value.Descuento));
            }

            return subTotal;
        }

        /// <summary>
        /// Calcula el IVA (15%) del subtotal a pagar por parte del cliente.
        /// </summary>
        /// <param name="subTotal">Subtotal a pagar por el cliente.</param>
        /// <returns>Cantidad del IVA a pagar por parte del cliente.</returns>
        private decimal CalculateIva(decimal subTotal)
        {
            return subTotal * Convert.ToDecimal(0.15);
        }

        /// <summary>
        /// Establece la configuración por default del editor.
        /// </summary>
        private void Limpiar()
        {
            if (dtVenta.Enabled)
            {
                dtVenta.Value = DateTime.Now;
            }

            txtBuscarCliente.Text = string.Empty;
            txtBuscarProducto.Text = string.Empty;
            Detalles.Clear();
            LoadDgvCarrito();

            txtSubTotal.Text = "Subtotal:";
            txtIva.Text = "IVA (15%):";
            txtTotal.Text = "Total:";
        }

        #endregion

        #region ISujeto Members

        public void AgregarObservador(IObservador observador)
        {
            Observadores.Add(observador);
        }

        public void Notificar()
        {
            Observadores.ForEach(observador => observador.Actualizar());
        }

        #endregion
    }
}
