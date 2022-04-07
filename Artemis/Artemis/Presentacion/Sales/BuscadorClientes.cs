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
using Artemis.Servicios.Interfaces;
using Artemis.Servicios.Sales;
using Artemis.ViewModels.Sales;

namespace Artemis.Presentacion.Sales
{
    public partial class BuscadorClientes : Buscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los clientes.
        /// </summary>
        private readonly ClienteService Service;

        public BuscadorClientes() : base("Clientes")
        {
            InitializeComponent();
            Service = new ClienteService();
            Actualizar();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            Actualizar();
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs args)
        {
            EditorCliente editorCliente = new EditorCliente(null);
            editorCliente.AgregarObservador(this);
            editorCliente.ShowDialog();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            ClienteView clienteView = GetSelected<ClienteView>();

            if (clienteView is null)
            {
                MessageBox.Show(this, "Antes de modificar, se necesita seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cliente = Service.GetById(clienteView.Id);

            if (cliente is null)
            {
                MessageBox.Show(this, "No se logró encontrar al cliente para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorCliente editorCliente = new EditorCliente(cliente);
            editorCliente.AgregarObservador(this);
            editorCliente.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            ClienteView clienteView = GetSelected<ClienteView>();

            if (clienteView is null)
            {
                MessageBox.Show(this, "Antes de eliminar, se necesita seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Service.Delete(clienteView.Id);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <inheritdoc cref="IObservador.Actualizar"/>
        public void Actualizar()
        {
            LoadDataGrid(Service.GetClientes(LastQuery));
        }
    }
}
