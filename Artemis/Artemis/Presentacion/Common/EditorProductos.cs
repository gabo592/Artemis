using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artemis.Servicios.Common;
using Artemis.Servicios.Interfaces;
using Artemis.Properties;
using Artemis.ViewModels.Common;
using Models.Common;
using Models.Interfaces;

namespace Artemis.Presentacion.Common
{
    public partial class EditorProductos : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Proveedor de servicios para los productos.
        /// </summary>
        private readonly ProductoService service;

        /// <summary>
        /// Proveedor de servicios para las categorías de los
        /// productos.
        /// </summary>
        private readonly CategoriasService categoriasService;

        /// <summary>
        /// Objeto simple de tipo producto.
        /// </summary>
        private readonly Producto producto;

        /// <summary>
        /// Imagen del producto;
        /// </summary>
        private Image Image;

        /// <summary>
        /// Lista de observadores relacionados a esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        #endregion

        public EditorProductos(Producto producto)
        {
            InitializeComponent();
            service = new ProductoService();
            categoriasService = new CategoriasService();
            observadores = new List<IObservador>();
            this.producto = producto;
            LoadInformation();
        }

        #region Private Methods

        /// <summary>
        /// Carga la información del producto al formulario. En caso de no existir,
        /// se carga el formulario por defecto.
        /// </summary>
        private void LoadInformation()
        {
            var categorias = categoriasService.GetCategorias(string.Empty).ToArray();

            cmbCategorias.DataSource = categorias;
            cmbCategorias.DisplayMember = nameof(INameable.Nombre);

            if (producto is null) return;

            txtDescripcion.Text = producto.Descripcion;
            numPrecio.Value = producto.Precio;
            numStock.Value = producto.Stock;
            Image = producto.Imagen;
            pbProducto.Image = Image;
            cmbCategorias.SelectedItem = categorias.FirstOrDefault(x => x.Id == producto.IdCategoria);
        }

        /// <summary>
        /// Establece los controles del editor a sus estado inicial.
        /// </summary>
        private void Limpiar()
        {
            txtDescripcion.Text = string.Empty;
            numPrecio.Value = numPrecio.Minimum;
            numStock.Value = numStock.Minimum;
            Image = null;
            pbProducto.Image = Resources.picture;
            cmbCategorias.SelectedIndex = 0;
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CategoriaView categoria = (CategoriaView)cmbCategorias.SelectedItem;

            IDictionary<string, object> values = new Dictionary<string, object>
            {
                {"Descripcion", txtDescripcion.Text },
                {"Precio", numPrecio.Value },
                {"Stock", numStock.Value },
                {"Imagen", Image },
                {"IdCategoria", categoria.Id }
            };

            try
            {
                if (producto is null)
                {
                    service.Create(values);

                    if (service.HasError())
                    {
                        MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Notificar();
                    Limpiar();
                }
                else
                {
                    values.Add("Id", producto.Id);
                    service.Update(values);

                    if (service.HasError())
                    {
                        MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Notificar();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();   
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PbProducto_Click(object sender, EventArgs e)
        {
            Image = OpenImage();

            if (Image is null)
            {
                pbProducto.Image = Resources.picture;
                return;
            }

            pbProducto.Image = Image;
        }

        /// <summary>
        /// Ejecuta un OpenFileDialog en donde el usuario selecciona la imagen que desee
        /// y así cargar al sistema dicha imagen.
        /// </summary>
        /// <returns>Imagen seleccionada por el usuario.</returns>
        private Image OpenImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "JPG|*.jpg|PNG|*.png",
                RestoreDirectory = true
            };

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.Cancel) return null;

            return new Bitmap(openFileDialog.OpenFile());
        }

        #region ISujeto Members

        /// <inheritdoc cref="ISujeto.AgregarObservador(IObservador)"/>
        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        /// <inheritdoc cref="ISujeto.Notificar"/>
        public void Notificar()
        {
            observadores.ForEach(observador => observador.Actualizar());
        }

        #endregion
    }
}
