using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Artemis.Presentacion.Principal
{
    public partial class Principal : KryptonForm
    {
        private Form ChildForm;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "¿Desea cerrar el programa? Se perderán los datos no guardados", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            e.Cancel = false;
            Application.Exit();
        }

        private void AddForm(Form form)
        {
            if (ChildForm != null) ChildForm.Close();

            ChildForm = form;

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            pnlPrincipal.Controls.Add(ChildForm);
            pnlPrincipal.Tag = ChildForm;

            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            AddForm(new Common.BuscadorCategorias());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AddForm(new Sales.BuscadorClientes());
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            AddForm(new Shop.BuscadorProveedores());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AddForm(new Identity.BuscadorUsuarios());
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AddForm(new Common.BuscadorEmpleados());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AddForm(new Common.BuscadorProductos());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AddForm(new Sales.BuscadorVentas());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            AddForm(new Shop.BuscadorCompras());
        }
    }
}
