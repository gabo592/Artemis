using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Artemis.Servicios.Common;
using Artemis.Servicios.Interfaces;
using Artemis.Properties;
using Models.Common;

namespace Artemis.Presentacion.Common
{
    public partial class EditarCategoria : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Objeto simple de tipo Categoría.
        /// </summary>
        private readonly Categoria Categoria;

        /// <summary>
        /// Proveedor de servicios para las Categorías.
        /// </summary>
        private readonly CategoriasService Service;

        /// <summary>
        /// Lista de objetos observadores.
        /// </summary>
        private readonly List<IObservador> Observadores;

        #endregion

        public EditarCategoria(Categoria categoria)
        {
            InitializeComponent();
            Categoria = categoria;
            Service = new CategoriasService();
            Observadores = new List<IObservador>();
        }

        private void FrmEditarCategoria_Load(object sender, EventArgs e)
        {
            if (Categoria is null) return;

            pbCategoria.Image = Categoria.Imagen;
            txtNombreCategoria.Text = Categoria.Nombre;
        }

        private void PbCategoria_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JPG|*.jpg|PNG|*.png"
            };

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbCategoria.Image = new Bitmap(openFileDialog.OpenFile());
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                MessageBox.Show(this, "Ingrese un nombre para la categoría", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Image image = pbCategoria.Image;
            string nombre = txtNombreCategoria.Text;

            Dictionary<string, object> values = new Dictionary<string, object>
            {
                {"Nombre", nombre },
                {"Imagen", image }
            };

            if (Categoria is null)
            {
                Service.Create(values);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();

                Limpiar();
            }
            else
            {
                Service.Update(Categoria, values);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();

                Close();
            }
        }

        private void Limpiar()
        {
            pbCategoria.Image = Resources.picture;
            txtNombreCategoria.Text = string.Empty;
        }

        /// <inheritdoc cref="ISujeto.AgregarObservador(IObservador)"/>
        public void AgregarObservador(IObservador observador)
        {
            Observadores.Add(observador);
        }

        /// <inheritdoc cref="ISujeto.Notificar"/>
        public void Notificar()
        {
            Observadores.ForEach(observador => observador.Actualizar());
        }
    }
}
