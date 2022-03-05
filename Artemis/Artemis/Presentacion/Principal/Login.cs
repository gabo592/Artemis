using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artemis.Properties;

namespace Artemis.Presentacion.Principal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar.Equals('*'))
            {
                txtContraseña.PasswordChar = '\0';
                pbContraseña.Image = Resources.eye_crossed_free_icon_font;
            }
            else
            {
                txtContraseña.PasswordChar = '*';
                pbContraseña.Image = Resources.eye_free_icon_font;
            }
        }
    }
}
