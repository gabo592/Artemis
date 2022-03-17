﻿using System;
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
            pnlSideBar.Visible = false;
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

        private void PbMenu_Click(object sender, EventArgs e)
        {
            if (!pnlSideBar.Visible)
            {
                sideBarTransition.Show(pnlSideBar);
                pnlSideBar.Visible = true;
            }
            else
            {
                pnlSideBar.Visible = false;
            }
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            AddForm(new Common.FrmCategorias());
        }
    }
}
