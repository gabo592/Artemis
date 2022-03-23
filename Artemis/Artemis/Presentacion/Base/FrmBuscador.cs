using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Artemis.Presentacion.Base
{
    public abstract partial class FrmBuscador : Form
    {
        public FrmBuscador(string titulo)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
        }

        #region Protected Methods

        protected abstract void OnTxtBuscar_Keypress(object sender, KeyPressEventArgs args, string text);
        protected abstract void OnBtnAgregar_Click(object sender, EventArgs args);
        protected abstract void OnBtnModificar_Click(object sender, EventArgs args);
        protected abstract void OnBtnEliminar_Click(object sender, EventArgs args);

        /// <summary>
        /// Carga el DataGridView del buscador en base a la colección de
        /// modelos del tipo especificado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a cargar.</typeparam>
        /// <param name="models">Modelos a cargar.</param>
        protected void LoadDataGrid<TModel>(IEnumerable<TModel> models) where TModel : new ()
        {
            if (models is null) return;

            dgvCatalogo.DataSource = models.ToArray();
        }

        /// <summary>
        /// Busca y obtiene el primer elemento seleccionado del DataGridView del
        /// tipo de modelo especificado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo que contiene el DataGridView.</typeparam>
        /// <returns>Primer modelo seleccionado.</returns>
        protected TModel GetSelected<TModel>() where TModel : new ()
        {
            var models = (TModel[])dgvCatalogo.DataSource;

            if (models is null || models.Length == 0) return default;

            return models[dgvCatalogo.SelectedRows[0].Index];
        }


        #endregion

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnTxtBuscar_Keypress(sender, e, txtBuscar.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            OnBtnAgregar_Click(sender, e);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            OnBtnModificar_Click(sender, e);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            OnBtnEliminar_Click(sender, e);
        }
    }
}
