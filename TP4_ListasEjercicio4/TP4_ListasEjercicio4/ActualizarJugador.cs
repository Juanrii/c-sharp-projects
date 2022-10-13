using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_ListasEjercicio4
{
    public partial class ActualizarJugador : Form
    {
        public Jugador jugadorSeleccionado = null;
        public Form1 juegoFormulario;
        public ListaCircular lista;

        public ActualizarJugador()
        {
            InitializeComponent();
        }

        private void ActualizarJugador_Load(object sender, EventArgs e)
        {
            ObtenerDatosDelJugadorSeleccionado();
        }

        private void ObtenerDatosDelJugadorSeleccionado()
        {
            this.inputNombre.Text = jugadorSeleccionado.nombre;
            this.inputApellido.Text = jugadorSeleccionado.apellido;
            this.inputEdad.Text = jugadorSeleccionado.edad.ToString();
            this.inputDNI.Text = jugadorSeleccionado.dni.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            jugadorSeleccionado.nombre = this.inputNombre.Text;
            jugadorSeleccionado.apellido = this.inputApellido.Text;
            jugadorSeleccionado.edad = Convert.ToInt32(this.inputEdad.Text);
            jugadorSeleccionado.dni = Convert.ToInt32(this.inputDNI.Text);
            juegoFormulario.jugadorSeleccionado = jugadorSeleccionado;
            juegoFormulario.LimpiarLista();
            juegoFormulario.LimpiarSeleccionado();
            juegoFormulario.ArmarLista(lista.jugadorInicial);
            MessageBox.Show("Jugador actualizado correctamente", "Actualizado");
            this.Close();
        }
    }
}
