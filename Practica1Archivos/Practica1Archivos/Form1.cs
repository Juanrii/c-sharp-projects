using System;
using System.Windows.Forms;

namespace Practica1Archivos
{
    public partial class Form1 : Form
    {

        GestorAlumnos alumnos = new GestorAlumnos();

        public Form1()
        {
            InitializeComponent();
            this.dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LlenarGrilla();
        }

        public void LlenarGrilla()
        {
            this.dgvAlumnos.DataSource = null;
            this.dgvAlumnos.DataSource = alumnos.Lista();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            bool dniExistente = alumnos.BuscarDNI((long)this.inputDNI.Value);

            if (dniExistente)
            {
                MessageBox.Show($"DNI existente. Por favor ingrese otro DNI valido", $"El DNI {this.inputDNI.Value} ya existe.");
            } else
            {
                if (CamposInvalidos())
                {
                    MessageBox.Show($"Datos incorrectos, por favor vuelva a ingresar", "Error.");
                } else
                {
                    Alumno alumno = new Alumno((long)this.inputDNI.Value)
                    {
                        Apellido = this.inputApellido.Text,
                        Nombre = this.inputNombre.Text
                    };
                    alumnos.Alta(alumno);
                    LlenarGrilla();
                }
            }

        }

        private bool CamposInvalidos()
        {
            return String.IsNullOrEmpty(this.inputApellido.Text) || String.IsNullOrEmpty(this.inputNombre.Text) ? true : false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnos.SelectedRows.Count == 1)
            {
                Alumno seleccionado = (Alumno)this.dgvAlumnos.SelectedRows[0].DataBoundItem;
                alumnos.Baja(seleccionado.DNI);
                LlenarGrilla();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnos.SelectedRows.Count == 1)
            {
                ActualizarForm actualizar = new ActualizarForm();
                actualizar.alumnoSeleccionado = (Alumno)this.dgvAlumnos.SelectedRows[0].DataBoundItem;
                actualizar.alumnos = alumnos;
                actualizar.form1 = this;
                actualizar.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
