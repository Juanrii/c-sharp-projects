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
using BLL;

namespace UI
{
    public partial class FormPaquetes : Form
    {
        BECanal _canalSeleccionado = null;
        BEPaquete _paqueteSeleccionado = null;
        float _totalRecaudado = 0;

        public FormPaquetes()
        {
            InitializeComponent();
            ActualizarDGV();
            dropDownClientes.Items.Clear();
            dropDownClientes.DisplayMember = "Nombre";
            dropDownClientes.ValueMember = "Codigo";
            foreach (BECliente c in Form1.clientes)
            {
                dropDownClientes.Items.Add(c);
            }

            foreach (BEPaquete paquete in Form1.paquetes)
            {
                if (paquete is BEPremium) 
                { 
                    BLPremium blPremium = new BLPremium();
                    _totalRecaudado += blPremium.ObtenerAbono(paquete);

                } else
                {
                    BLSilver bLSilver = new BLSilver();
                    _totalRecaudado += bLSilver.ObtenerAbono(paquete);

                }
            }
            labelRecaudado.Text = "Total Recaudado: " + _totalRecaudado.ToString();
        }

        private void btnAgregarCanal_Click(object sender, EventArgs e)
        {
            try
            {
                BECanal canal = new BECanal()
                {
                    Serie = inputSerie.Text,
                    Temporadas = Convert.ToInt32(inputTemporada.Text),
                    Duracion = Convert.ToInt32(inputDuracion.Text),
                    Episodio = Convert.ToInt32(inputEpisodio.Text),
                    Ranking = Convert.ToInt32(inputRanking.Text),
                    Genero = inputGenero.Text,
                    Director = inputDirector.Text,
                };
                Form1.canales.Add(canal);
                ActualizarDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos. Vuelva a ingresarlos por favor.");
                return;
            }
        }

        private void ActualizarDGV()
        {
            dgvCanales.DataSource = null;
            dgvCanales.DataSource = Form1.canales;

            dgvPaquetes.DataSource = null;
            dgvPaquetes.DataSource = Form1.paquetes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dropDownClientes.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente.");
                    return;
                }


                labelRecaudado.Text = "Total Recaudado: " + _totalRecaudado.ToString();
                BEPaquete paquete;
                if (btnPremium.Checked)
                {

                    paquete = new BEPremium();
                    paquete.Cliente = (BECliente)dropDownClientes.SelectedItem;
                    Form1.paquetes.Add(paquete);
                    dgvPaquetes.DataSource = null;
                    dgvPaquetes.DataSource = Form1.paquetes;

                    BLPremium bLPremium = new BLPremium();
                    _totalRecaudado += bLPremium.ObtenerAbono(paquete);


                } else if (btnSilver.Checked) { 
                    paquete = new BESilver();
                    paquete.Cliente = (BECliente)dropDownClientes.SelectedItem;
                    Form1.paquetes.Add(paquete);
                    dgvPaquetes.DataSource = null;
                    dgvPaquetes.DataSource = Form1.paquetes;

                    BLSilver blSilver = new BLSilver();
                    _totalRecaudado += blSilver.ObtenerAbono(paquete);
                }

                dropDownClientes.Items.Remove((BECliente)dropDownClientes.SelectedItem);

                labelRecaudado.Text = "Total Recaudado: " + _totalRecaudado.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos. Vuelva a ingresarlos por favor.");
                return;
            }
        }

        private void dgvCanales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCanales.SelectedRows.Count == 1)
            {
                _canalSeleccionado = (BECanal)dgvCanales.SelectedRows[0].DataBoundItem;
            } else
            {
                _canalSeleccionado = null;
            }
        }

        private void dgvPaquetes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count == 1)
            {
                _paqueteSeleccionado = (BEPaquete)dgvPaquetes.SelectedRows[0].DataBoundItem;
                dgvPaqueteCanales.DataSource = null;
                dgvPaqueteCanales.DataSource = _paqueteSeleccionado.Canales;
            } else
            {
                _paqueteSeleccionado = null;
                dgvPaqueteCanales.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool canalAgregado = false;
                foreach (BECanal canal in _paqueteSeleccionado.Canales)
                {
                    if (canal.Codigo == _canalSeleccionado.Codigo)
                    {
                        canalAgregado = true;
                        break;
                    }
                }

                if (!canalAgregado)
                {
                    foreach (BEPaquete paquete in Form1.paquetes)
                    {
                        if (paquete.Codigo == _paqueteSeleccionado.Codigo)
                            paquete.Canales.Add(_canalSeleccionado);
                    }
                }

                dgvPaqueteCanales.DataSource = null;
                dgvPaqueteCanales.DataSource = _paqueteSeleccionado.Canales;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar el paquete y la serie deseada.");
                return;
            }
        }
    }
}
