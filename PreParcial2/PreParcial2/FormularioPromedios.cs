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
    public partial class FormularioPromedios : Form
    {
        List<Alumno> listaAlumnos = null;
        List<Nota> listaNotas = null;
        List<Promedio> listaPromedios = null;

        public FormularioPromedios(List<Alumno> alumnos, List<Nota> notas)
        {
            InitializeComponent();
            listaAlumnos = alumnos;
            listaNotas= notas;
            dgvPromedios.DataSource = null;
            dgvPromedios.DataSource = ObtenerDatos();
            labelPromedio.Text = "Mejor Promedio: " + ObtenerMejorPromedio();
        }

        private string ObtenerMejorPromedio()
        {
            int mayor = 0;
            string legajo = string.Empty;
            
            for (int i = 0; i < listaPromedios.Count; i++)
            {
                if (i == 0)
                {
                    mayor = Convert.ToInt32(listaPromedios[i].ValorPromedio);
                    legajo = listaPromedios[i].Legajo.ToString();
                }
                else if (Convert.ToInt32(listaPromedios[i].ValorPromedio) > mayor)
                {
                    mayor = Convert.ToInt32(listaPromedios[i].ValorPromedio);
                    legajo = listaPromedios[i].Legajo.ToString();
                }
                    

            }
            return $"{mayor} (Legajo: {legajo})";
        }

        private object ObtenerDatos()
        {

            List<Promedio> promedios = new List<Promedio>();
            int contador, acc;


            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                Promedio p = new Promedio(listaAlumnos[i].Legajo)
                {
                    Nombre = listaAlumnos[i].Nombre,
                    Apellido = listaAlumnos[i].Apellido
                };
                contador = 0;
                acc = 0;

                for (int j = 0; j < listaNotas.Count; j++)
                {
                    if (listaNotas[j].ValorNota >= 4)
                    {
                        if (listaNotas[j].Legajo == listaAlumnos[i].Legajo)
                        {
                            contador++;
                            acc += listaNotas[j].ValorNota;
                        }
                    }
                }
                p.ValorPromedio = contador == 0 ? 0 : acc / contador;
                promedios.Add(p);
            }

            listaPromedios = promedios;

            return promedios;
        }
    }
}
