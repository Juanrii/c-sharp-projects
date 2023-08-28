using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace UI
{
    public partial class RankingSeries : Form
    {
        public RankingSeries()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RankingSeries_Load(object sender, EventArgs e)
        {
            List<BECanal> ranking = new List<BECanal>();

            foreach (BECanal canal in FormInicial.canales)
            {
                if (canal.Ranking > 3.5)
                {
                    ranking.Add(canal);
                }
            }

            comboRanking.DataSource = ranking;

        }
    }
}
