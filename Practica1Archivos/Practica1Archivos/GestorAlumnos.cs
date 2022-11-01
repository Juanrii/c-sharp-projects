using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Archivos
{
    public class GestorAlumnos
    {

        string archivo = "alumnos.txt";
        private List<Alumno> listaAlumnos;

        public List<Alumno> Lista()
        {
            // instancio una lista de tipo alumnos
            List<Alumno> lista = new List<Alumno>();

            // instancio el filestream en modo lectura
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            // instancio el stream reader con using y le paso el filestream como parametro
            using (StreamReader reader = new StreamReader(fs))
            {
                // guardo en un string linea el ReadLine
                string linea = reader.ReadLine();

                // mientras la linea no sea null, creo un alumno(linea) y lo agrego a la lista con .Add()
                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);
                    lista.Add(unAlumno);
                    linea = reader.ReadLine();
                }
            }
            // cierro el archivo
            fs.Close();

            // retorno la lista
            this.listaAlumnos = lista;
            return lista;
        }

        public void Actualizar(Alumno alumnoSeleccionado, Alumno alumnoActualizado)
        {
            string output = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);
                    if (unAlumno.DNI == alumnoSeleccionado.DNI)
                    {
                        unAlumno = alumnoActualizado;
                        output += unAlumno.GenerarRegistro() + Environment.NewLine;
                    }
                    else
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            // se pone en 0 bytes el archivo (truncate) y se lo reescribe con lo almacenado en output
            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }

        public bool BuscarDNI(long DNI)
        {
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (listaAlumnos[i].DNI == DNI)
                    return true;
            }
            return false;
        }

        public void Alta(Alumno alumno)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(alumno.GenerarRegistro());
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
                    Alumno unAlumno = new Alumno(linea);
                    if (unAlumno.DNI != DNI)
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            // se pone en 0 bytes el archivo (truncate) y se lo reescribe con lo almacenado en output
            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }
    }
}
