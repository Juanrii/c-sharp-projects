using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialModelo
{
    public class GestorAlumnos
    {
        private string archivo = "Alumnos.txt";

        public void Alta(Alumno unAlumno)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(unAlumno.GenerarRegistro());
            }
            fs.Close();
        }

        public List<Alumno> Listar()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Alumno alumno = new Alumno(linea);
                    listaAlumnos.Add(alumno);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            return listaAlumnos;
        }

        internal List<Alumno> Ordernar(List<Alumno> alumnos)
        {
            for (int i = 0; i < alumnos.Count - 1; i++)
            {
                for (int j = i + 1; j < alumnos.Count; j++)
                {
                    if (alumnos[i].Legajo > alumnos[j].Legajo)
                    {
                        var aux = alumnos[i];
                        alumnos[i] = alumnos[j];
                        alumnos[j] = aux;
                    }
                }
            }
            return alumnos;
        }

        internal bool BuscarLegajo(int legajo)
        {
            bool resultado = false;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno alumno = new Alumno(linea);
                    if (alumno.Legajo == legajo)
                    {
                        resultado = true;
                    }
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            return resultado;
        }

        public void Baja(int legajo)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Alumno alumno = new Alumno(linea);
                    if (alumno.Legajo != legajo)
                    {
                        output += alumno.GenerarRegistro() + Environment.NewLine;
                    }
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }

        internal void Modificar(int legajo, string nombreActualizado, string apellidoActualizado)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Alumno alumno = new Alumno(linea);
                    if (alumno.Legajo == legajo)
                    {
                        alumno.Nombre = nombreActualizado;
                        alumno.Apellido = apellidoActualizado;
                    }
                    output += alumno.GenerarRegistro() + Environment.NewLine;
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }
    }
}
