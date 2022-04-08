using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Artemis.Servicios.Interfaces;
using Artemis.Servicios.Shop;
using Models.Shop;

namespace Artemis.Presentacion.Shop
{
    public partial class EditorProveedores : Form, ISujeto
    {
        /// <summary>
        /// Objeto simple de tipo Proveedor.
        /// </summary>
        private readonly Proveedor Proveedor;

        /// <summary>
        /// Lista de observadores que contiene esta clase.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Proveedor de servicios para los objetos de tipo Proveedor.
        /// </summary>
        private readonly ProveedorService Service;

        public EditorProveedores(Proveedor proveedor)
        {
            InitializeComponent();
            Proveedor = proveedor;
            LoadInformation();
            Observadores = new List<IObservador>();
            Service = new ProveedorService();
        }

        /// <summary>
        /// Carga la información del Proveedor para editar. En caso de ser nulo,
        /// se carga el frame por predeterminado.
        /// </summary>
        private void LoadInformation()
        {
            if (Proveedor is null) return;

            txtNombre.Text = Proveedor.Nombre;
            txtTelefono.Text = Proveedor.Telefono;
            txtDireccion.Text = Proveedor.Direccion;
        }

        /// <summary>
        /// Despeja la información ingresada en los controles del Frame.
        /// </summary>
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region ISujeto Members

        /// <inheritdoc cref="ISujeto.AgregarObservador(IObservador)"/>
        public void AgregarObservador(IObservador observador)
        {
            Observadores.Add(observador);
        }

        /// <inheritdoc cref="ISujeto.Notificar"/>
        public void Notificar()
        {
            Observadores.ForEach(observador => observador.Actualizar());
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> values = new Dictionary<string, object>
            {
                {"Nombre", txtNombre.Text },
                {"Telefono", txtTelefono.Text },
                {"Direccion", txtDireccion.Text }
            };

            try
            {
                if (Proveedor is null)
                {
                    Service.Create(values);

                    if (Service.HasError())
                    {
                        MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Notificar();
                    Limpiar();
                }
                else
                {
                    values.Add("Id", Proveedor.Id);

                    Service.Update(values);

                    if (Service.HasError())
                    {
                        MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Notificar();
                    Close();
                }
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
    }
}
