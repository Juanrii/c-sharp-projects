using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialModelo
{
    public class GestorNotas
    {
        private string archivo = "Notas.txt";

        public List<Nota> Listar()
        {
            List<Nota> listaNotas = new List<Nota>();

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Nota nota = new Nota(linea);
                    listaNotas.Add(nota);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            return listaNotas;
        }

        internal List<Nota> Ordernar(List<Nota> notas)
        {
            for (int i = 0; i < notas.Count - 1; i++)
            {
                for (int j = i + 1; j < notas.Count; j++)
                {
                    if (notas[i].Legajo > notas[j].Legajo)
                    {
                        var aux = notas[i];
                        notas[i] = notas[j];
                        notas[j] = aux;
                    }
                }
            }
            return notas;
        }

        public void Alta(Nota nuevaNota)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(nuevaNota.GenerarRegistro());
            }
            fs.Close();
        }

        internal void Modificar(int legajo, string materiaActualizada, double valorNotaActualizada, DateTime fechaActualizada)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Nota nota = new Nota(linea);
                    if (nota.Legajo == legajo)
                    {
                        nota.Materia = materiaActualizada;
                        nota.ValorNota = valorNotaActualizada;
                        nota.Fecha = fechaActualizada;
                    }
                    output += nota.GenerarRegistro() + Environment.NewLine;
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

        internal void Baja(int legajo)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Nota nota = new Nota(linea);
                    if (nota.Legajo != legajo)
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
    }
}
