using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BLL
{
    public class BLCanal
    {
        private float _ranking = 3.5f;

        public List<BECanal> ObtenerRanking(List<BECanal> canales)
        {
            List<BECanal> rankingList = new List<BECanal>();
            foreach (BECanal canal in canales)
            {
                if (canal.Ranking > _ranking)
                {
                    rankingList.Add(canal);
                }
            }
            return rankingList;
        }
    }
}
