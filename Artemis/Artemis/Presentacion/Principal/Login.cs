using Artemis.Properties;
using Artemis.Servicios.Base;
using Artemis.Servicios.Identity;
using System;
using System.Windows.Forms;

namespace Artemis.Presentacion.Principal
{
    public partial class Login : Form
    {
        /// <summary>
        /// Proveedor de servicios de usuario.
        /// </summary>
        private readonly UsuarioService Service;

        public Login()
        {
            InitializeComponent();
            Service = new UsuarioService();
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

        /// <summary>
        /// Realiza el inicio de sesión.
        /// </summary>
        private void DoLogin()
        {
            try
            {
                string nombre = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                Service.Login(nombre, contraseña);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Sesion.IsActive)
                {
                    MessageBox.Show(this, "No se logró establecer el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Principal principal = new Principal();
                principal.Show();
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) DoLogin();
        }
    }
}
