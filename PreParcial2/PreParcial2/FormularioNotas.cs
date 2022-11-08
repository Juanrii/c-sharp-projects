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
        GestorNotas gestorNotas = null;
        public FormularioNotas(GestorNotas gestorNotas)
        {
            InitializeComponent();
            this.gestorNotas = gestorNotas;
            LimpiarDataGridView();
        }

        private void LimpiarDataGridView()
        {
            this.dgvNotas.DataSource = null;
            this.dgvNotas.DataSource = gestorNotas.LlenarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count == 1)
            {
                Nota notaSelect = (Nota)dgvNotas.SelectedRows[0].DataBoundItem;
                ActualizarNota actualizarNota = new ActualizarNota(notaSelect, gestorNotas);
                actualizarNota.Show();
                // cuando se cierra el formulario actualizar, se ejecuta este evento
                actualizarNota.FormClosed += HandleEventActualiarFormClosed;
            }
        }

        private void HandleEventActualiarFormClosed(object sender, FormClosedEventArgs e)
        {
            LimpiarDataGridView();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = inputFecha.Value.ToString("yyyy-MM-dd");
                string materia = inputMateria.Text;
                int legajo = Convert.ToInt32(inputLegajo.Value);
                int nota = Convert.ToInt32(inputNota.Text);

                if (string.IsNullOrEmpty(fecha) || string.IsNullOrEmpty(materia) || nota < 0 || nota > 10)
                {
                    MessageBox.Show("Datos Incorrectos.", "Error");
                    return;
                }


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
