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
    public partial class BuscadorProveedores : Buscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los modelos de tipo Proveedor.
        /// </summary>
        private readonly ProveedorService Service;

        public BuscadorProveedores() : base("Proveedores")
        {
            InitializeComponent();
            Service = new ProveedorService();
            Actualizar();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            Actualizar();
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs args)
        {
            EditorProveedores editorProveedores = new EditorProveedores(null);
            editorProveedores.AgregarObservador(this);
            editorProveedores.ShowDialog();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            ProveedorView proveedorView = GetSelected<ProveedorView>();

            if (proveedorView is null)
            {
                MessageBox.Show(this, "Antes de modificar un registro, primero debe seleccionarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var proveedor = Service.GetById(proveedorView.Id);

            if (proveedor is null)
            {
                MessageBox.Show(this, $"No se logró encontrar el modelo con ID:{proveedor.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorProveedores editorProveedores = new EditorProveedores(proveedor);
            editorProveedores.AgregarObservador(this);
            editorProveedores.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            ProveedorView proveedorView = GetSelected<ProveedorView>();

            if (proveedorView is null)
            {
                MessageBox.Show(this, "Antes de eliminar un registro, primero debe seleccionarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el proveedor con ID {proveedorView.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                Service.Delete(proveedorView.Id);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoadDataGrid(Service.GetProveedores(LastQuery));
        }
    }
}
