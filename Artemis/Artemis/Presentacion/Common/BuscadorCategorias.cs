using System;
using System.Linq;
using System.Windows.Forms;
using Artemis.Servicios.Common;
using Artemis.Servicios.Interfaces;
using Artemis.ViewModels.Common;

namespace Artemis.Presentacion.Common
{
    public partial class BuscadorCategorias : Form, IObservador
    {
        #region Private Fields

        /// <summary>
        /// Proveedor de servicios para las Categorías.
        /// </summary>
        private readonly CategoriasService Service;

        /// <summary>
        /// Última búsqueda ingresada en el TextBox
        /// </summary>
        private string LastQuery = string.Empty;

        #endregion

        public BuscadorCategorias()
        {
            InitializeComponent();
            Service = new CategoriasService();
            LoadDataGrid(string.Empty);
        }

        private void LoadDataGrid(string nombre)
        {
            dgvCategorias.DataSource = Service.GetCategorias(nombre).ToArray();
        }

        private CategoriaView GetSelected()
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                return null;
            }

            var categorias = (CategoriaView[])dgvCategorias.DataSource;

            return categorias[dgvCategorias.SelectedRows[0].Index];
        }

        private void DgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriaView selected = GetSelected();

            if (selected is null) return;

            var categoria = Service.GetById(selected.Id);

            pbCategoria.Image = categoria.Imagen;
        }

        public void Actualizar()
        {
            LoadDataGrid(LastQuery);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EditarCategoria editarCategoria = new EditarCategoria(null);
            editarCategoria.AgregarObservador(this);
            editarCategoria.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            CategoriaView selected = GetSelected();

            if (selected is null)
            {
                MessageBox.Show(this, "No se encontró la Categoría a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var categoria = Service.GetById(selected.Id);

            if (categoria is null || categoria.Equals(default)) return;

            EditarCategoria editarCategoria = new EditarCategoria(categoria);
            editarCategoria.AgregarObservador(this);
            editarCategoria.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaView selected = GetSelected();
            
            if (selected is null)
            {
                MessageBox.Show(this, "No se encontró la Categoría a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el registro con ID: {selected.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            Service.Delete(selected.Id);

            if (Service.HasError())
            {
                MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Actualizar();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadDataGrid(txtBuscar.Text);
        }
    }
}
