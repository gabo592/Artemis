using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artemis.Presentacion.Common;
using Models.Shop;

namespace Artemis.Presentacion.Shop
{
    public partial class EditorCompra : Form
    {
        public EditorCompra(Compra compra)
        {
            InitializeComponent();
        }

        private void PnlDatosProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonNuevoProducto_Click(object sender, EventArgs e)
        {
            EditorProductos editorProductos = new EditorProductos(null);
            editorProductos.ShowDialog();
        }
    }
}
