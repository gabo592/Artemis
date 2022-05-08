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
using Artemis.Servicios.Interfaces;
using Artemis.Servicios.Shop;
using Artemis.ViewModels.Shop;

namespace Artemis.Presentacion.Shop
{
    public partial class BuscadorCompras : BuscadorTransacciones, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para las Compras.
        /// </summary>
        private readonly CompraService service;

        public BuscadorCompras() : base("Compras")
        {
            InitializeComponent();
            service = new CompraService();
            Actualizar();
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs args)
        {
            EditorCompra editorCompra = new EditorCompra(null);
            editorCompra.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            CompraView compraView = GetSelected<CompraView>();

            if (compraView is null)
            {
                MessageBox.Show(this, "Para eliminar un registro, primero debe seleccionarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var compra = service.GetById(compraView.Id);

            if (compra is null)
            {
                MessageBox.Show(this, $"No se encontró la compra con ID: {compra.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar la compra con ID: {compra.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(compra.Id);

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
            CompraView compraView = GetSelected<CompraView>();

            if (compraView is null)
            {
                MessageBox.Show(this, "Para modificar un registro, primero debe seleccionarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var compra = service.GetById(compraView.Id);

            if (compra is null)
            {
                MessageBox.Show(this, $"No se encontró la compra con ID: {compra.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                LoadDataGrid(service.GetCompras(dtBuscar.Value));
            }
            else
            {
                LoadDataGrid(service.GetCompras());
            }
        }

        #endregion
    }
}
