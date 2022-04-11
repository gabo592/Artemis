using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artemis.Presentacion.Base;
using Artemis.Servicios.Identity;
using Artemis.Servicios.Interfaces;

namespace Artemis.Presentacion.Identity
{
    public partial class BuscadorUsuarios : Buscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los Usuarios.
        /// </summary>
        private readonly UsuarioService Service;

        public BuscadorUsuarios() : base("Usuarios")
        {
            InitializeComponent();
            Service = new UsuarioService();
            Actualizar();
        }

        /// <inheritdoc cref="IObservador.Actualizar"/>
        public void Actualizar()
        {
            LoadDataGrid(Service.GetUsuarios(LastQuery));
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs args)
        {
            EditorUsuario editorUsuario = new EditorUsuario(null);
            editorUsuario.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            throw new NotImplementedException();
        }
    }
}
