using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialModelo
{
    public partial class ForumularioNotas : Form
    {
        GestorNotas gestorNotas = new GestorNotas();

        public ForumularioNotas()
        {
            InitializeComponent();
            LlenarDataGridView();
        }

        private void LlenarDataGridView()
        {
            this.dgvNotas.DataSource = null;
            this.dgvNotas.DataSource = gestorNotas.Listar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Nota nuevaNota = new Nota(Convert.ToInt32(inputAltaLegajo.Value))
                {

                    Materia = inputAltaMateria.Text,
                    ValorNota = Convert.ToDouble(inputAltaNota.Text),
                    Fecha = inputAltaFecha.Value
                };
                gestorNotas.Alta(nuevaNota);
                LimpiarInputs();
                LlenarDataGridView();
            }
        }

        private void LimpiarInputs()
        {
            this.inputAltaLegajo.Value = 0;
            this.inputAltaMateria.Text = string.Empty;
            this.inputAltaNota.Text = string.Empty;
        }

        private bool ValidarDatos()
        {
            try
            {
                int nota = Convert.ToInt32(inputAltaNota.Text);
                string materia = inputAltaMateria.Text;
                if (nota <= 0 || nota > 10 || String.IsNullOrEmpty(materia))
                {
                    MostrarErrorDeCarga();
                    return false;
                }
            }
            catch (Exception)
            {
                MostrarErrorDeCarga();
                return false;
            }
            return true;
        }


        private void MostrarErrorDeCarga()
        {
            MessageBox.Show("Datos incorrectos. Por favor vuelva a ingresarlos.", "Error");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count == 1)
            {
                if (ValidarDatosModificados())
                {
                    Nota notaSeleccionada = (Nota)dgvNotas.SelectedRows[0].DataBoundItem;
                    string materiaActualizada = this.inputModificarMateria.Text;
                    double valorNotaActualizada = Convert.ToDouble(this.inputModificarNota.Text);
                    DateTime fechaActualizada = Convert.ToDateTime(this.inputModificarFecha.Text);
                    gestorNotas.Modificar(notaSeleccionada.Legajo, materiaActualizada, valorNotaActualizada, fechaActualizada);
                    LlenarDataGridView();
                }

            }
        }

        private bool ValidarDatosModificados()
        {
            return (String.IsNullOrEmpty(this.inputModificarMateria.Text) || 
                Convert.ToInt32(this.inputModificarNota.Text) < 1 || Convert.ToInt32(this.inputModificarNota.Text) > 10) ? false : true;
        }

        private void dgvNotas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count == 1)
            {
                Nota notaSeleccionada = (Nota)dgvNotas.SelectedRows[0].DataBoundItem;
                this.inputModificarLegajo.Value = notaSeleccionada.Legajo;
                this.inputModificarMateria.Text = notaSeleccionada.Materia;
                this.inputModificarNota.Text = notaSeleccionada.ValorNota.ToString();
                this.inputModificarFecha.Text = notaSeleccionada.Fecha.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionado())
            {
                Nota notaSeleccionada = (Nota)dgvNotas.SelectedRows[0].DataBoundItem;
                gestorNotas.Baja(notaSeleccionada.Legajo);
                LlenarDataGridView();
            }
        }

        private bool ValidarSeleccionado()
        {
            bool seleccionado = dgvNotas.SelectedRows.Count == 1 ? true : false;

            if (seleccionado)
            {
                DialogResult op = MessageBox.Show("Esta seguro que desa elimnar la nota seleccionada?", "Alerta", MessageBoxButtons.YesNo);
                if (op == DialogResult.Yes) return true;
            }
            return false;
        }
    }
}
