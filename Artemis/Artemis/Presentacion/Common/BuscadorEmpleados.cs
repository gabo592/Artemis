using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artemis.Presentacion.Base;
using Artemis.Servicios.Common;
using Artemis.Servicios.Interfaces;
using Artemis.ViewModels.Common;

namespace Artemis.Presentacion.Common
{
    public partial class BuscadorEmpleados : Buscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los empleados.
        /// </summary>
        private readonly EmpleadoService service;

        public BuscadorEmpleados() : base("Empleados")
        {
            InitializeComponent();
            service = new EmpleadoService();
            Actualizar();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            Actualizar();
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs args)
        {
            EditorEmpleado editorEmpleado = new EditorEmpleado(null);
            editorEmpleado.AgregarObservador(this);
            editorEmpleado.ShowDialog();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            EmpleadoView empleadoView = GetSelected<EmpleadoView>();

            if (empleadoView is null)
            {
                MessageBox.Show(this, "Para editar un empleado, primero debe seleccionar uno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = service.GetById(empleadoView.Id);

            if (empleado is null)
            {
                MessageBox.Show(this, "No se logró encontrar el empleado a editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorEmpleado editorEmpleado = new EditorEmpleado(empleado);
            editorEmpleado.AgregarObservador(this);
            editorEmpleado.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            EmpleadoView empleadoView = GetSelected<EmpleadoView>();

            if (empleadoView is null)
            {
                MessageBox.Show(this, "Para eliminar a un empleado, primero debe seleccionar uno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = service.GetById(empleadoView.Id);

            if (empleado is null)
            {
                MessageBox.Show(this, "No se logró encontrar el empleado a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el empleado con ID: {empleado.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(empleado.Id);

                if (service.HasError())
                {
                    MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <inheritdoc cref="IObservador.Actualizar"/>
        public void Actualizar()
        {
            LoadDataGrid(service.GetEmpleados(LastQuery));
        }
    }
}
