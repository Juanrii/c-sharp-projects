using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECanal
    {
        public Guid Codigo { get; set; }
        public string Serie { get; set; }
        public int Temporadas { get; set; }
        public int Episodio { get; set; }
        public int Duracion { get; set; }
        public float Ranking { get; set; }
            
        public enum TipoGenero
        {
            Terror,
            Comedia,
            Accion,
            Amor
        }

        public TipoGenero Genero { get; set; }

        public string Director { get; set; }

        public BEPaquete paquete;

        public BECanal()
        {
            Codigo = Guid.NewGuid();
        }

        public BECanal(string serie, int temporadas, int episodio, int duracion, float ranking, TipoGenero genero, string director, BEPaquete paquete = null)
        {
            Serie = serie;
            Temporadas = temporadas;
            Episodio = episodio;
            Duracion = duracion;
            Ranking = ranking;
            Genero = genero;
            Director = director;
            this.paquete = paquete;
            Codigo = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"Seria: {Serie} - Temporada: {Temporadas} - Episodio: {Episodio} - Ranking: {Ranking}";
        }
    }
}
