using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreParcial2
{
    public class GestorAlumnos
    {
        private string archivo = "Alumnos.txt";
        private List<Alumno> listaAlumnoTotales;

        internal List<Alumno> Listar()
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

            this.listaAlumnoTotales = listaAlumnos;

            return listaAlumnos;
        }

        internal void Agregar(Alumno nuevoAlumno)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(nuevoAlumno.GenerarRegistro());
            }
            fs.Close();
        }

        internal void Baja(int legajo)
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
                        output += linea + Environment.NewLine;
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

        internal bool BuscarLegajo(int legajo)
        {
            for (int i = 0; i < listaAlumnoTotales.Count; i++)
            {
                if (listaAlumnoTotales[i].Legajo == legajo)
                    return true;
            }
            return false;
        }
    }
}
