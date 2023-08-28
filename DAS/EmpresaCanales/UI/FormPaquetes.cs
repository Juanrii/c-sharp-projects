using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using static BE.BECanal;

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
            inputGenero.DataSource = Enum.GetNames(typeof(BECanal.TipoGenero));

            dropDownClientes.Items.Clear();
            dropDownClientes.DisplayMember = "Nombre";
            dropDownClientes.ValueMember = "Codigo";
            foreach (BECliente c in FormInicial.clientes)
            {
                dropDownClientes.Items.Add(c);
            }

            foreach (BEPaquete paquete in FormInicial.paquetes)
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
                    Genero = (TipoGenero)Enum.Parse(typeof(TipoGenero), inputGenero.Text),
                    Director = inputDirector.Text,
                };
                FormInicial.canales.Add(canal);
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
            dgvCanales.DataSource = FormInicial.canales;

            dgvPaquetes.DataSource = null;
            dgvPaquetes.DataSource = FormInicial.paquetes;
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
                BEPaquete paquete = null;
                BLPaquete BLPaquete = null;

                if (btnPremium.Checked)
                {
                    paquete = new BEPremium();
                    BLPaquete = new BLPremium();

                } else if (btnSilver.Checked) { 
                    paquete = new BESilver();
                    BLPaquete = new BLSilver();
                }

                paquete.Cliente = (BECliente)dropDownClientes.SelectedItem;
                paquete.Abono = BLPaquete.ObtenerAbono(paquete);
                FormInicial.paquetes.Add(paquete);
                dgvPaquetes.DataSource = null;
                dgvPaquetes.DataSource = FormInicial.paquetes;
                _totalRecaudado += paquete.Abono;

                dropDownClientes.Items.Remove((BECliente)dropDownClientes.SelectedItem);

                labelRecaudado.Text = "Total Recaudado: $" + _totalRecaudado.ToString();

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

                inputSerie.Text = _canalSeleccionado.Serie;
                inputTemporada.Text = _canalSeleccionado.Temporadas.ToString();
                inputDuracion.Text = _canalSeleccionado.Duracion.ToString();
                inputEpisodio.Text = _canalSeleccionado.Episodio.ToString();
                inputRanking.Text = _canalSeleccionado.Ranking.ToString();
                inputGenero.Text = _canalSeleccionado.Genero.ToString();
                inputDirector.Text = _canalSeleccionado.Director;
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
                    foreach (BEPaquete paquete in FormInicial.paquetes)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (_canalSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un canal para actualizar.");
                    return;
                }

                // actualizar lista canales
                foreach (BECanal canal in FormInicial.canales)
                {
                    if (canal.Codigo == _canalSeleccionado.Codigo)
                    {
                        canal.Serie = inputSerie.Text;
                        canal.Temporadas = Convert.ToInt32(inputTemporada.Text);
                        canal.Duracion = Convert.ToInt32(inputDuracion.Text);
                        canal.Episodio = Convert.ToInt32(inputEpisodio.Text);
                        canal.Ranking = Convert.ToInt32(inputRanking.Text);
                        canal.Genero = (TipoGenero)Enum.Parse(typeof(TipoGenero), inputGenero.Text);
                        canal.Director = inputDirector.Text;
                    }
                }

                // acutalizar canal en lista de paquetes
                foreach (BEPaquete paquete in FormInicial.paquetes)
                {
                    foreach (BECanal canal in paquete.Canales)
                    {
                        if (canal.Codigo == _canalSeleccionado.Codigo)
                        {
                            canal.Serie = inputSerie.Text;
                            canal.Temporadas = Convert.ToInt32(inputTemporada.Text);
                            canal.Duracion = Convert.ToInt32(inputDuracion.Text);
                            canal.Episodio = Convert.ToInt32(inputEpisodio.Text);
                            canal.Ranking = Convert.ToInt32(inputRanking.Text);
                            canal.Genero = (TipoGenero)Enum.Parse(typeof(TipoGenero), inputGenero.Text);
                            canal.Director = inputDirector.Text;
                        }
                    }
                }

                ActualizarDGV();



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
