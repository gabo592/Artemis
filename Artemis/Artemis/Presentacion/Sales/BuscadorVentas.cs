using System;
using System.Windows.Forms;
using Artemis.Presentacion.Base;
using Artemis.ViewModels.Sales;
using Artemis.Servicios.Interfaces;
using Artemis.Servicios.Sales;

namespace Artemis.Presentacion.Sales
{
    public partial class BuscadorVentas : BuscadorTransacciones, IObservador
    {
        /// <summary>
        /// Proveedor de serivicios para las Ventas.
        /// </summary>
        private readonly VentaService service;

        public BuscadorVentas() : base("Ventas")
        {
            InitializeComponent();
            service = new VentaService();
            Actualizar();
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs args)
        {
            EditorVenta editorVenta = new EditorVenta(null);
            editorVenta.AgregarObservador(this);
            editorVenta.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            VentaView ventaView = GetSelected<VentaView>();

            if (ventaView is null)
            {
                MessageBox.Show(this, "Para eliminar un registro, primero debe seleccionarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venta = service.GetById(ventaView.Id);

            if (venta is null)
            {
                MessageBox.Show(this, $"No se logró encontrar la venta con ID: {venta.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar la venta con ID: {venta.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            VentaView ventaView = GetSelected<VentaView>();

            if (ventaView is null)
            {
                MessageBox.Show(this, "Para modificar un registro, primero debe seleccionarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venta = service.GetById(ventaView.Id);

            if (venta is null)
            {
                MessageBox.Show(this, $"No se logró encontrar la venta con ID: {venta.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorVenta editorVenta = new EditorVenta(venta);
            editorVenta.AgregarObservador(this);
            editorVenta.ShowDialog();
        }

        protected override void OnCheckBuscarFecha_CheckedChanged(object sender, EventArgs args)
        {
            Actualizar();
        }

        protected override void OnDtBuscar_ValueChanged(object sender, EventArgs args)
        {
            Actualizar();
        }

        #region IObservador Members

        public void Actualizar()
        {
            if (dtBuscar.Enabled)
            {
                LoadDataGrid(service.GetVentas(dtBuscar.Value));
            }
            else
            {
                LoadDataGrid(service.GetVentas());
            }
        }

        #endregion
    }
}
