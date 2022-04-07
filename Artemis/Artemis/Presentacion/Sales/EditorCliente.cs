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
using Artemis.Servicios.Sales;
using Artemis.Servicios.Interfaces;
using Models.Common;
using Models.Sales;
using Models.Interfaces;

namespace Artemis.Presentacion.Sales
{
    public partial class EditorCliente : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Objeto simple de tipo Cliente.
        /// </summary>
        private readonly Cliente Cliente;

        /// <summary>
        /// Servicio de ubicaciones.
        /// </summary>
        private readonly UbicacionService UbicacionService;

        /// <summary>
        /// Servicios para los Clientes
        /// </summary>
        private readonly ClienteService Service;

        /// <summary>
        /// Lista de observadores.
        /// </summary>
        private readonly List<IObservador> Observadores;

        #endregion

        /// <summary>
        /// Constructor del editor. Requiere de un objeto cliente para ser editado,
        /// en caso de ser nulo, se cargará el editor en limpio.
        /// </summary>
        /// <param name="cliente">Cliente a editar.</param>
        public EditorCliente(Cliente cliente)
        {
            InitializeComponent();
            Cliente = cliente;
            UbicacionService = new UbicacionService();
            Service = new ClienteService();
            Observadores = new List<IObservador>();
            LoadInformation();
        }

        /// <summary>
        /// Carga toda la información del cliente, en caso de no existir, carga los
        /// componentes por default.
        /// </summary>
        private void LoadInformation()
        {
            LoadLocation();

            if (Cliente is null) return;

            txtPrimerNombre.Text = Cliente.PrimerNombre;
            txtSegundoNombre.Text = Cliente.SegundoNombre;
            txtPrimerApellido.Text = Cliente.PrimerApellido;
            txtSegundoApellido.Text = Cliente.SegundoApellido;
            dtNacimiento.Value = Cliente.FechaNacimiento;
            txtCorreo.Text = Cliente.Correo;
            txtTeléfono.Text = Cliente.Telefono;

            Municipio municipio = UbicacionService.GetMunicipio(Cliente.IdMunicipio);

            if (municipio is null) return;

            Departamento departamento = UbicacionService.GetDepartamento(municipio.IdDepartamento);

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
            cmbDepartamentos.DataSource = UbicacionService.GetDepartamentos(string.Empty).ToArray();
            cmbDepartamentos.DisplayMember = nameof(INameable.Nombre);

            Departamento departamento = (Departamento)cmbDepartamentos.SelectedItem;

            cmbMunicipios.DataSource = UbicacionService.GetMunicipios(departamento.Id).ToArray();
            cmbMunicipios.DisplayMember = nameof(INameable.Nombre);
        }

        /// <summary>
        /// Carga toda la información de los ComboBox de ubicaciones en base el ID del departamento
        /// seleccionado en el ComboBox Departamentos.
        /// </summary>
        /// <param name="idDepartamento"></param>
        private void LoadLocation(int idDepartamento)
        {
            if (idDepartamento.Equals(default)) return;

            cmbMunicipios.DataSource = UbicacionService.GetMunicipios(idDepartamento).ToArray();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamento departamento = (Departamento)cmbDepartamentos.SelectedItem;
            LoadLocation(departamento.Id);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            dtNacimiento.Value = DateTime.Now;
            txtCorreo.Text = string.Empty;
            txtTeléfono.Text = string.Empty;
            cmbDepartamentos.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Municipio municipio = (Municipio)cmbMunicipios.SelectedItem;

                Dictionary<string, object> values = new Dictionary<string, object>
                {
                    {"PrimerNombre", txtPrimerNombre.Text },
                    {"SegundoNombre", txtSegundoNombre.Text },
                    {"PrimerApellido", txtPrimerApellido.Text },
                    {"SegundoApellido", txtSegundoApellido.Text },
                    {"FechaNacimiento", dtNacimiento.Value },
                    {"Correo", txtCorreo.Text },
                    {"Telefono", txtTeléfono.Text },
                    {"IdMunicipio", municipio.Id }
                };

                if (Cliente is null)
                {
                    Service.Create(values);
                }
                else
                {
                    values.Add("Id", Cliente.Id);
                    Service.Update(values);
                }

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();

                if (Cliente is null)
                {
                    Limpiar();
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AgregarObservador(IObservador observador)
        {
            Observadores.Add(observador);
        }

        public void Notificar()
        {
            Observadores.ForEach(observador => observador.Actualizar());
        }
    }
}
