using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreParcial2
{
    public partial class FormularioNotas : Form
    {
        GestorNotas gestorNotas = new GestorNotas();
        public FormularioNotas()
        {
            InitializeComponent();
            LimpiarDataGridView();
        }

        private void LimpiarDataGridView()
        {
            this.dgvNotas.DataSource = null;
            this.dgvNotas.DataSource = gestorNotas.LlenarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActualizarNota actualizarNota = new ActualizarNota();
            actualizarNota.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = inputFecha.Value.ToString("yyyy-mm-dd");
                string materia = inputMateria.Text;
                int legajo = Convert.ToInt32(inputLegajo.Value);
                int nota = Convert.ToInt32(inputNota.Text);

                Nota nuevaNota = new Nota(legajo)
                {
                    Fecha = fecha,
                    Materia = materia,
                    ValorNota = nota
                };
                gestorNotas.Alta(nuevaNota);
                LimpiarDataGridView();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos. Por favor vuelva a ingresarlos.", "Datos incorrectos");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count == 1)
            {
                Nota notaSeleccionada = (Nota)dgvNotas.SelectedRows[0].DataBoundItem;
                gestorNotas.Baja(notaSeleccionada.Legajo);
                LimpiarDataGridView();
            }
        }

    }
}
