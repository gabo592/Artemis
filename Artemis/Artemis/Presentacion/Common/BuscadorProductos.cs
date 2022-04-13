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
    public partial class BuscadorProductos : Buscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los productos.
        /// </summary>
        private readonly ProductoService service;

        public BuscadorProductos() : base("Productos")
        {
            InitializeComponent();
            service = new ProductoService();
            Actualizar();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            Actualizar();
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs args)
        {
            EditorProductos editor = new EditorProductos(null);
            editor.AgregarObservador(this);
            editor.ShowDialog();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            ProductoView productoView = GetSelected<ProductoView>();

            if (productoView is null)
            {
                MessageBox.Show(this, "Antes de modificar un producto, primero debe seleccionarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = service.GetById(productoView.Id);

            if (producto is null)
            {
                MessageBox.Show(this, $"No se encontró el producto con ID: {producto.Id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorProductos editor = new EditorProductos(producto);
            editor.AgregarObservador(this);
            editor.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            ProductoView productoView = GetSelected<ProductoView>();

            if (productoView is null)
            {
                MessageBox.Show(this, "Antes de eliminar un producto, primero debe seleccionarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = service.GetById(productoView.Id);

            if (producto is null)
            {
                MessageBox.Show(this, $"No se encontró el producto con ID: {producto.Id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el producto con ID: {producto.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(producto.Id);

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
            LoadDataGrid(service.GetProductos(LastQuery));
        }
    }
}
