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
                    Codigo = Convert.ToInt32(inputCodigo.Text),
                    FechaNacimiento = Convert.ToDateTime(inputFecha.Text)
                };
                Form1.clientes.Add(c);
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
            dgvClientes.DataSource = Form1.clientes;
        }
    }
}
