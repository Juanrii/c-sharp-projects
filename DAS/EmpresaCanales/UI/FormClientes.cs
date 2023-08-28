using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;   

namespace UI
{
    public partial class FormClientes : Form
    {
        BECliente _clienteSeleccionado;

        public FormClientes()
        {
            InitializeComponent();
            ActualizarDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BECliente c = new BECliente()
                {
                    Nombre = inputNombre.Text,
                    Apellido = inputApellido.Text,
                    DNI = Convert.ToInt32(inputDNI.Text),
                    FechaNacimiento = Convert.ToDateTime(inputFecha.Text)
                };

                FormInicial.clientes.Add(c);
                ActualizarDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos. Vuelva a ingresarlos por favor.");
                return;
            }
        }

        private void ActualizarDGV()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = FormInicial.clientes;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente a eliminar.");
                return;
            }

            DialogResult opcion = MessageBox.Show($"Esta seguro que desea eliminar el cliente: {_clienteSeleccionado.Nombre}?", 
                "Aviso", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                foreach (BEPaquete paquete in FormInicial.paquetes)
                {
                    if (paquete.Cliente.Codigo == _clienteSeleccionado.Codigo)
                    {
                        MessageBox.Show($"No es posible eliminar el cliente porque posee un paquete. Codigo de paquete: {paquete.Codigo}.");
                        return;
                    }
                }

                FormInicial.clientes.Remove(_clienteSeleccionado);
                ActualizarDGV();
            }

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                _clienteSeleccionado = (BECliente)dgvClientes.SelectedRows[0].DataBoundItem;
                inputNombre.Text = _clienteSeleccionado.Nombre;
                inputApellido.Text = _clienteSeleccionado.Apellido;
                inputDNI.Text = _clienteSeleccionado.DNI.ToString();
                inputFecha.Text = _clienteSeleccionado.FechaNacimiento.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                if (_clienteSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente a actualizar.");
                    return;
                }

                // Actualizar lista clientes
                foreach (BECliente cliente in FormInicial.clientes)
                {
                    if (cliente.Codigo == _clienteSeleccionado.Codigo)
                    {
                        cliente.Nombre = inputNombre.Text;
                        cliente.Apellido = inputApellido.Text;
                        cliente.DNI = Convert.ToInt32(inputDNI.Text);
                        cliente.FechaNacimiento = Convert.ToDateTime(inputFecha.Text);
                    }
                }

                // Actualizar paquete del cliente
                foreach (BEPaquete paquete in FormInicial.paquetes)
                {
                    if (paquete.Cliente.Codigo == _clienteSeleccionado.Codigo)
                    {
                        paquete.Cliente = _clienteSeleccionado;
                    }
                }
                ActualizarDGV();
                MessageBox.Show("Cliente actualizado correctamente.", "Actualizado");

            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos. Vuelva a ingresarlos.");
                return;
            }
            


        }
    }
}
