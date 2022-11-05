using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreParcial2
{
    public class GestorNotas
    {
        private string archivo = "Notas.txt";

        public List<Nota> LlenarLista()
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

        public void Alta(Nota nuevaNota)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(nuevaNota.GenerarRegistro());
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
