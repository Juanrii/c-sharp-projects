using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_Ejer3
{
    public partial class Actualizar : Form
    {
        public NodoCliente clienteSeleccionado;
        public CineForm cineForm;

        public Actualizar()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.clienteSeleccionado != null)
                {
                    clienteSeleccionado.edad = Convert.ToInt32(this.inputEdad.Text);
                    cineForm.clienteSeleccionado.edad = clienteSeleccionado.edad;
                    cineForm.ActualizarLista();
                    MessageBox.Show($"Cliente actualizado", "Actualizado");
                    this.Close();
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show($"Debe ingresar una edad valida", "Datos invalidos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
