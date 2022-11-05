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
    public partial class FormularioAlumnos : Form
    {
        GestorAlumnos gestorAlumnos = new GestorAlumnos();

        public FormularioAlumnos()
        {
            InitializeComponent();
            LlenarDataGridView();
        }

        private void LlenarDataGridView()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = gestorAlumnos.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActualizarAlumno actualizarAlumno = new ActualizarAlumno();
            actualizarAlumno.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo = Convert.ToInt32(inputLegajo.Value);
                string nombre = inputNombre.Text;
                string apellido = inputApellido.Text;

                if (LegajoInexistente(legajo))
                {
                    Alumno nuevoAlumno = new Alumno(legajo)
                    {
                        Nombre = nombre,
                        Apellido = apellido
                    };

                    gestorAlumnos.Agregar(nuevoAlumno);
                    LlenarDataGridView();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos. Por favor vuelva a ingresarlos.", "Datos incorrectos");
            }
        }

        private bool LegajoInexistente(int legajo)
        {
            bool existe = gestorAlumnos.BuscarLegajo(legajo);
            if (existe)
            {
                MessageBox.Show($"El Legajo ingresado: {legajo} ya existe. Vuelva a ingresar por favor.", "Legajo existente");
                return false;
            }
            return true;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 1)
            {
                Alumno alumnoSeleccionado = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;
                gestorAlumnos.Baja(alumnoSeleccionado.Legajo);
                LlenarDataGridView();
            }
        }
    }
}
