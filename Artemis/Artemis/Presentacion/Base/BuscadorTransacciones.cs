using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Artemis.Presentacion.Base
{
    public abstract partial class BuscadorTransacciones : Form
    {
        public BuscadorTransacciones(string titulo)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
        }

        #region Abstract Methods

        /// <summary>
        /// Método encargado de ejecutar la lógica a implementar cuando se de click en el Botón Agregar.
        /// </summary>
        /// <param name="sender">Objeto que manda el evento.</param>
        /// <param name="args">Argumentos del evento.</param>
        protected abstract void OnBtnAgregar_Click(object sender, EventArgs args);

        /// <summary>
        /// Método encargado de ejecutar la lógica a implementar cuando se de click en el Botón Modificar.
        /// </summary>
        /// <param name="sender">Objeto que manda el evento.</param>
        /// <param name="args">Argumentos del evento.</param>
        protected abstract void OnBtnModificar_Click(object sender, EventArgs args);

        /// <summary>
        /// Método encargado de ejecutar la lógica a implementar cuando se de click en el Botón Eliminar.
        /// </summary>
        /// <param name="sender">Objeto que manda el evento.</param>
        /// <param name="args">Argumentos del evento.</param>
        protected abstract void OnBtnEliminar_Click(object sender, EventArgs args);

        /// <summary>
        /// Método encargado de ejecutar la lógica a implementar cuando el valor del DateTimePicker cambie.
        /// </summary>
        /// <param name="sender">Objeto que manda el evento.</param>
        /// <param name="args">Argumentos del evento.</param>
        protected abstract void OnDtBuscar_ValueChanged(object sender, EventArgs args);

        /// <summary>
        /// Método encargado de ejecutar la lógica a implementar cuando el estado del CheckBox cambie.
        /// </summary>
        /// <param name="sender">Objeto que manda el evento.</param>
        /// <param name="args">Argumentos del evento.</param>
        protected abstract void OnCheckBuscarFecha_CheckedChanged(object sender, EventArgs args);

        #endregion

        #region Generic Methods

        /// <summary>
        /// Obtiene el primer modelo seleccionado del DataGridView.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo contenido en el DataGridView.</typeparam>
        /// <returns>Primera coincidencia de las filas seleccionadas del DataGridView.</returns>
        protected TModel GetSelected<TModel>() where TModel : new ()
        {
            if (dgvCatalogo.SelectedRows.Count == 0) return default;

            TModel[] models = (TModel[])dgvCatalogo.DataSource;

            return models[dgvCatalogo.SelectedRows[0].Index];
        }

        /// <summary>
        /// Carga la información del DataGridView en base a la colección de modelos del tipo especificado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a cargar.</typeparam>
        /// <param name="models">Colección de modelos a cargar en el DataGridView.</param>
        protected void LoadDataGrid<TModel>(IEnumerable<TModel> models) where TModel : new ()
        {
            if (models is null) return;

            dgvCatalogo.DataSource = models.ToArray();
        }

        #endregion

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

        private void DtBuscar_ValueChanged(object sender, EventArgs e)
        {
            OnDtBuscar_ValueChanged(sender, e);
        }

        private void CheckBuscarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Enabled = checkBuscarFecha.Checked;
            OnCheckBuscarFecha_CheckedChanged(sender, e);
        }
    }
}
