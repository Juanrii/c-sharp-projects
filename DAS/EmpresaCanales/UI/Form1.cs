using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;


namespace UI
{
    public partial class Form1 : Form
    {
        public static List<BECliente> clientes = new List<BECliente>();
        public static List<BECanal> canales = new List<BECanal>();
        public static List<BEPaquete> paquetes = new List<BEPaquete>();

        public Form1()
        {
            InitializeComponent();

            BECliente c1 = new BECliente()
            {
                DNI = 1,
                Nombre = "Juan",
                Apellido = "Rios",
                Codigo = 1,
                FechaNacimiento = DateTime.Now,
            };
            clientes.Add(c1);
            BECliente c2 = new BECliente()
            {
                DNI = 2,
                Nombre = "Pepe",
                Apellido = "Peposo",
                Codigo = 2,
                FechaNacimiento = DateTime.Now,
            };
            clientes.Add(c2);
            BECliente c3 = new BECliente()
            {
                DNI = 3,
                Nombre = "Juli",
                Apellido = "Delconte",
                Codigo = 3,
                FechaNacimiento = DateTime.Now,
            };
            clientes.Add(c3);

            BECanal cc1 = new BECanal("serie1", 1, 1, 100, 4, "terror", "juan");
            canales.Add(cc1);
            canales.Add(new BECanal("serie2", 1, 1, 140, 5, "aventura", "el pipi"));
            canales.Add(new BECanal("serie3", 1, 1, 200, 1, "amor", "adam bareiro"));

            BEPaquete s = new BESilver();
            s.Canales.Add(cc1);
            s.Cliente = c1;
            paquetes.Add(s);
        }


        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormClientes formCliente = new FormClientes();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaquetes formPaquetes = new FormPaquetes();
            formPaquetes.MdiParent = this;
            formPaquetes.Show();
        }

        private void rankingSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingSeries formRanking = new RankingSeries();
            formRanking.MdiParent = this;
            formRanking.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
