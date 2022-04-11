using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artemis.Servicios.Common;
using Artemis.Servicios.Interfaces;
using Models.Common;
using Models.Interfaces;

namespace Artemis.Presentacion.Common
{
    public partial class EditorEmpleado : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Lista de observadores asociados a esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        /// <summary>
        /// Proveedor de servicios para los empleados.
        /// </summary>
        private readonly EmpleadoService service;

        /// <summary>
        /// Proveedor de servicios de ubicaciones.
        /// </summary>
        private readonly UbicacionService ubicacionService;

        /// <summary>
        /// Objeto simple de tipo Empleado.
        /// </summary>
        private readonly Empleado empleado;

        #endregion

        public EditorEmpleado(Empleado empleado)
        {
            InitializeComponent();
            observadores = new List<IObservador>();
            service = new EmpleadoService();
            ubicacionService = new UbicacionService();
            this.empleado = empleado;
            LoadInformation();
        }

        #region Private Methods

        /// <summary>
        /// Carga la información del empleado a editar. En caso de no existir,
        /// se carga el editor por default.
        /// </summary>
        private void LoadInformation()
        {
            LoadLocation();

            if (empleado is null) return;

            txtPrimerNombre.Text = empleado.PrimerNombre;
            txtSegundoNombre.Text = empleado.SegundoNombre;
            txtPrimerApellido.Text = empleado.PrimerApellido;
            txtSegundoApellido.Text = empleado.SegundoApellido;
            txtCorreo.Text = empleado.Correo;
            txtCedula.Text = empleado.Cedula;

            Municipio municipio = ubicacionService.GetMunicipio(empleado.IdMunicipio);

            if (municipio is null) return;

            Departamento departamento = ubicacionService.GetDepartamento(municipio.IdDepartamento);

            if (departamento is null) return;

            Departamento[] departamentos = (Departamento[])cmbDepartamentos.DataSource;
            cmbDepartamentos.SelectedItem = departamentos.FirstOrDefault(value => value.Id == departamento.Id);

            Municipio[] municipios = (Municipio[])cmbMunicipios.DataSource;
            cmbMunicipios.SelectedItem = municipios.FirstOrDefault(value => value.Id == municipio.Id);
        }

        /// <summary>
        /// Carga toda la información de los ComboBox de ubicaciones.
        /// </summary>
        private void LoadLocation()
        {
            cmbDepartamentos.DataSource = ubicacionService.GetDepartamentos(string.Empty).ToArray();
            cmbDepartamentos.DisplayMember = nameof(INameable.Nombre);

            Departamento departamento = (Departamento)cmbDepartamentos.SelectedItem;

            cmbMunicipios.DataSource = ubicacionService.GetMunicipios(departamento.Id).ToArray();
            cmbMunicipios.DisplayMember = nameof(INameable.Nombre);
        }

        /// <summary>
        /// Carga toda la información de los ComboBox de municipios en base el ID del departamento
        /// seleccionado en el ComboBox Departamentos.
        /// </summary>
        /// <param name="idDepartamento"></param>
        private void LoadMunicipios(int idDepartamento)
        {
            if (idDepartamento.Equals(default)) return;

            cmbMunicipios.DataSource = ubicacionService.GetMunicipios(idDepartamento).ToArray();
        }

        /// <summary>
        /// Limpia la información de los controles del formulario
        /// a su estado inicial.
        /// </summary>
        private void Limpiar()
        {
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCedula.Text = string.Empty;
            cmbDepartamentos.SelectedIndex = 0;
        }

        #endregion

        #region Events

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Municipio municipio = (Municipio)cmbMunicipios.SelectedItem;

            IDictionary<string, object> values = new Dictionary<string, object>
            {
                {"PrimerNombre", txtPrimerNombre.Text },
                {"SegundoNombre", txtSegundoNombre.Text },
                {"PrimerApellido", txtPrimerApellido.Text },
                {"SegundoApellido", txtSegundoApellido.Text },
                {"Correo", txtCorreo.Text },
                {"Cedula", txtCedula.Text },
                {"IdMunicipio", municipio.Id }
            };

            try
            {
                if (empleado is null)
                {
                    service.Create(values);

                    if (service.HasError())
                    {
                        MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Notificar();
                    Limpiar();
                }
                else
                {
                    values.Add("Id", empleado.Id);

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamento departamento = (Departamento)cmbDepartamentos.SelectedItem;

            LoadMunicipios(departamento.Id);
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
