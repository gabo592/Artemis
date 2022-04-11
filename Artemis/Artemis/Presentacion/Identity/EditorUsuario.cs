using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artemis.Servicios.Base;
using Artemis.Servicios.Common;
using Artemis.Servicios.Identity;
using Artemis.Servicios.Interfaces;
using Models.Identity;
using Microsoft.VisualBasic;

namespace Artemis.Presentacion.Identity
{
    public partial class EditorUsuario : Form, ISujeto
    {
        /// <summary>
        /// Objeto simple de tipo Usuario.
        /// </summary>
        private readonly Usuario usuario;

        /// <summary>
        /// Proveedor de servicios para los empleados.
        /// </summary>
        private readonly EmpleadoService empleadoService;

        /// <summary>
        /// Proveedor de servicios para los usuarios.
        /// </summary>
        private readonly UsuarioService service;

        /// <summary>
        /// Lista de observadores asociados a esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        /// <summary>
        /// Proveedor de servicios de correos.
        /// </summary>
        private readonly MailService mailService;

        public EditorUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            empleadoService = new EmpleadoService();
            service = new UsuarioService();
            mailService = new MailService();
            observadores = new List<IObservador>();
            LoadInformation();
        }

        #region Private Methods

        /// <summary>
        /// Carga la información del formulario con los valores a editar
        /// del Usuario. En caso de no existir, se carga el formulario por
        /// defecto.
        /// </summary>
        private void LoadInformation()
        {
            dgvEmpleados.DataSource = empleadoService.GetEmpleados(string.Empty).ToArray();

            if (usuario is null) return;

            txtNombreUsuario.Text = usuario.Nombre;
            txtRolUsuairo.Text = usuario.Rol;

            SelectEmpleado();
            HidePasswordOptions();
        }

        /// <summary>
        /// Esconde los campos para digitar y confirmar la contraseña.
        /// Esto solo ocurre cuando se va a modificar un usuario existente.
        /// </summary>
        private void HidePasswordOptions()
        {
            lblContraseña.Visible = false;
            pnlContraseña.Visible = false;
        }

        /// <summary>
        /// Selecciona el empleado correspondiente al usuario dentro del
        /// DataGridView de empleados.
        /// </summary>
        private void SelectEmpleado()
        {
            for (int i = 0; i < dgvEmpleados.Rows.Count - 1; i++)
            {
                int id = (int)dgvEmpleados.Rows[i].Cells["Id"].Value;

                if (id == usuario.IdEmpleado)
                {
                    dgvEmpleados.CurrentCell = dgvEmpleados.Rows[i].Cells[0];
                    dgvEmpleados.Rows[i].Selected = true;
                    break;
                }
            }
        }

        /// <summary>
        /// Método encargado de limpiar la información de todos los TextBox.
        /// </summary>
        private void Limpiar()
        {
            txtNombreUsuario.Text = string.Empty;
            txtRolUsuairo.Text = string.Empty;
            txtBuscarEmpleado.Text = string.Empty;
        }

        /// <summary>
        /// Método genérico encargado de obtener el valor seleccionado del DataGridView
        /// de los empleados.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo contenido en el DataGridView.</typeparam>
        /// <returns>Primer coincidencia de la lista de filas seleccionadas del DataGridView de los empleados.</returns>
        private TModel GetSelected<TModel>() where TModel : new()
        {
            if (dgvEmpleados.SelectedRows.Count == 0) return default;

            TModel[] models = (TModel[])dgvEmpleados.DataSource;

            return models[dgvEmpleados.SelectedRows[0].Index];
        }

        #endregion

        #region Events

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = GetSelected<ViewModels.Common.EmpleadoView>();

                IDictionary<string, object> values = new Dictionary<string, object>
                {
                    {"Nombre", txtNombreUsuario.Text },
                    {"Rol", txtNombreUsuario.Text },
                    {"IdEmpleado", empleado.Id }
                };

                if (usuario is null)
                {
                    if (string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtConfirmarContraseña.Text))
                    {
                        MessageBox.Show(this, "Digite la contraseña y confirme la misma.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!txtContraseña.Text.Equals(txtConfirmarContraseña.Text))
                    {
                        MessageBox.Show(this, "Las contraseñas no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    values.Add("Contraseña", txtContraseña.Text);

                    service.Create(values);

                    if (service.HasError())
                    {
                        MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Notificar();
                }
                else
                {
                    values.Add("Id", usuario.Id);
                    values.Add("Contraseña", usuario.Contraseña);

                    service.Update(values);

                    if (service.HasError())
                    {
                        MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Notificar();
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

        private void TxtBuscarEmpleado_TextChange(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = empleadoService.GetEmpleados(txtBuscarEmpleado.Text).ToArray();
        }

        #endregion

        #region ISujeto Members

        /// <inheritdoc cref="ISujeto.AgregarObservador(IObservador)"/>
        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        /// <inheritdoc cref="ISujeto.Notificar"/>
        public void Notificar()
        {
            observadores.ForEach(observador => observador.Actualizar());
        }

        #endregion
    }
}
