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
using BLL;

namespace UI
{
    public partial class FormCliente : Form
    {
        private BLLCliente _bllCliente;

        public FormCliente()
        {
            InitializeComponent();
            _bllCliente = new BLLCliente();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            MostrarMesajeRequerido(false);
        }

        private void MostrarMesajeRequerido(bool mostrar = true)
        {
            if (mostrar)
            {
                campoRequerido1.Show();
                campoRequerido2.Show();
            } 
            else
            {
                campoRequerido1.Hide();
                campoRequerido2.Hide();
            }
            
        }

        private void ActualizarDGV()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = _bllCliente.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BECliente cliente = ObtenerCliente();

                if (cliente is null) return;

                bool guardado = _bllCliente.Guardar(cliente);

                if (guardado)
                {
                    ActualizarDGV();
                    LimpiarCampos();
                    MostrarMesajeRequerido(false);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LimpiarCampos()
        {
            inputNombre.Text = inputApellido.Text = inputTel.Text = inputDir.Text = "";
        }

        private BECliente ObtenerCliente()
        {
            try
            {
                if (CamposInvalidos())
                {
                    MostrarMesajeRequerido(true);
                    throw new Exception("Campos incorrectos.Vuelva a ingresarlos por favor.");
                }
                    
                return new BECliente()
                {
                    Nombre      = inputNombre.Text,
                    Apellido    = inputApellido.Text,
                    Telefono    = inputTel.Text,
                    Direccion   = inputDir.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(inputNombre.Text.Trim()) || String.IsNullOrEmpty(inputApellido.Text.Trim());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposInvalidos())
                {
                    MostrarMesajeRequerido(true);
                    throw new Exception("Campos incorrectos.Vuelva a ingresarlos por favor.");
                }

                BECliente cliente   = (BECliente)dgvClientes.CurrentRow.DataBoundItem;
                cliente.Nombre      = inputNombre.Text;
                cliente.Apellido    = inputApellido.Text;
                cliente.Telefono    = inputTel.Text;
                cliente.Direccion   = inputDir.Text;

                bool guardado = _bllCliente.Guardar(cliente);

                if (guardado)
                {
                    ActualizarDGV();
                    LimpiarCampos();
                    MostrarMesajeRequerido(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            BECliente cliente   = (BECliente)dgvClientes.CurrentRow.DataBoundItem;
            inputNombre.Text    = cliente.Nombre;
            inputApellido.Text  = cliente.Apellido;
            inputTel.Text       = cliente.Telefono;
            inputDir.Text       = cliente.Direccion;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BECliente cliente = (BECliente)dgvClientes.CurrentRow.DataBoundItem;

                DialogResult res = MessageBox.Show($"Esta seguro que desea eliminar el cliente {cliente.Nombre} {cliente.Apellido}?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    bool baja = _bllCliente.Baja(cliente);
                    
                    if (baja)
                    {
                        ActualizarDGV();
                        LimpiarCampos();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
