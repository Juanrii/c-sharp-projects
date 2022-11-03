using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Archivos
{
    public class GestorAlumnos
    {

        string archivo = "alumnos.txt";

        // Guardar la lista para luego poder recorrerla
        List<Alumno> listaAlumnos = null;

        public void Alta(Alumno nuevoAlumno)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(nuevoAlumno.GenerarRegistro());
            }
            fs.Close();
        }

        public void Baja(long DNI)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno alumno = new Alumno(linea);
                    if (alumno.DNI != DNI)
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

        internal void Actualizar(Alumno alumnoActualizado, Alumno alumnoSeleccionado)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno alumno = new Alumno(linea);
                    if (alumnoSeleccionado.DNI == alumno.DNI)
                    {
                        alumno = alumnoActualizado;

                        output += alumnoActualizado.GenerarRegistro() + Environment.NewLine;
                    } else
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

        internal bool BuscarDniExistente(long DNI)
        {
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (listaAlumnos[i].DNI == DNI)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Alumno> Listar()
        {
            List<Alumno> lista = new List<Alumno>();

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno alumno = new Alumno(linea);
                    lista.Add(alumno);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            // Guardo en una variable global la lista para depues recorrerla
            listaAlumnos = lista;

            return lista;
        }
    }
}
