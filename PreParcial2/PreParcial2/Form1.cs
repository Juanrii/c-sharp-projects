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
    public partial class Form1 : Form
    {
        FormularioAlumnos formAlumnos = null;
        GestorAlumnos gestorAlumnos = null;
        GestorNotas gestorNotas = null;
        public Form1()
        {
            InitializeComponent();
            InstanciarGeneradores();
        }

        private void InstanciarGeneradores()
        {
            this.gestorAlumnos = new GestorAlumnos();
            this.gestorNotas = new GestorNotas();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.formAlumnos = new FormularioAlumnos(gestorAlumnos);
            formAlumnos.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            FormularioNotas formNotas = new FormularioNotas(gestorNotas);
            formNotas.Show();
        }

        private void btnPromedios_Click(object sender, EventArgs e)
        {
            InstanciarGeneradores();
            List<Alumno> listaAlumnos = ObtenerAlumnosOrdenados();
            List<Nota> listaNotas = ObtenerNotasOrdenadas();
            FormularioPromedios formPromedios = new FormularioPromedios(listaAlumnos, listaNotas);

            formPromedios.Show();
        }

        private List<Nota> ObtenerNotasOrdenadas()
        {
            List<Nota> notas = gestorNotas.LlenarLista();

            for (int i = 0; i < notas.Count; i++)
            {
                for (int j = 0; j < notas.Count; j++)
                {
                    if (notas[i].Legajo < notas[j].Legajo)
                    {
                        Nota aux = notas[i];
                        notas[i] = notas[j];
                        notas[j] = aux;
                    }
                }
            }

            return notas;
        }

        private List<Alumno> ObtenerAlumnosOrdenados()
        {
            List<Alumno> alumnos = gestorAlumnos.Listar();

            for (int i = 0; i < alumnos.Count; i++)
            {
                for (int j = 0; j < alumnos.Count; j++)
                {
                    if (alumnos[i].Legajo < alumnos[j].Legajo)
                    {
                        Alumno aux = alumnos[i];
                        alumnos[i] = alumnos[j];
                        alumnos[j] = aux;
                    }
                }
            }

            return alumnos;        
        }
    }
}
