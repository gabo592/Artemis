using System;
using System.Linq;
using System.Windows.Forms;
using Artemis.Servicios.Interfaces;
using Artemis.Servicios.Sales;

namespace Artemis.Presentacion.Sales
{
    public partial class BuscadorVentas : Form, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para las ventas.
        /// </summary>
        private readonly VentaService service;

        public BuscadorVentas()
        {
            InitializeComponent();
            service = new VentaService();
            Actualizar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EditorVenta editor = new EditorVenta(null);
            editor.AgregarObservador(this);
            editor.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            var ventaView = GetSelected<ViewModels.Sales.VentaView>();

            if (ventaView is null)
            {
                MessageBox.Show(this, "Antes de modificar una venta, primero debe seleccionarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venta = service.GetById(ventaView.Id);

            if (venta is null)
            {
                MessageBox.Show(this, $"No se logró identificar la venta con ID: {venta.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorVenta editorVenta = new EditorVenta(venta);
            editorVenta.AgregarObservador(this);
            editorVenta.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var ventaView = GetSelected<ViewModels.Sales.VentaView>();

            if (ventaView is null)
            {
                MessageBox.Show(this, "Antes de eliminar una venta, primero debe seleccionarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venta = service.GetById(ventaView.Id);

            if (venta is null)
            {
                MessageBox.Show(this, $"No se logró identificar la venta con ID: {venta.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar la venta con ID: {ventaView.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(venta.Id);

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

        private void DtBuscar_ValueChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void CheckBuscarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Enabled = checkBuscarFecha.Checked;
            Actualizar();
        }

        /// <summary>
        /// Obtiene el primer modelo seleccionado del DataGridView.
        /// </summary>
        /// <typeparam name="TModel">Modelo a seleccionar.</typeparam>
        /// <returns>Primer modelo seleccionado.</returns>
        private TModel GetSelected<TModel>() where TModel : new ()
        {
            if (dgvVentas.SelectedRows.Count == 0) return default;

            TModel[] models = (TModel[])dgvVentas.DataSource;

            return models[dgvVentas.SelectedRows[0].Index];
        }

        /// <inheritdoc cref="IObservador.Actualizar"/>
        public void Actualizar()
        {
            if (!checkBuscarFecha.Checked)
            {
                dgvVentas.DataSource = service.GetVentas().ToArray();
                return;
            }

            DateTime fecha = dtBuscar.Value;

            dgvVentas.DataSource = service.GetVentas(fecha).ToArray();
        }
    }
}
