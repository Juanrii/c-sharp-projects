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
    public partial class FormTipoProducto : Form
    {
        private BLLTipo _bllTipo;
        public FormTipoProducto()
        {
            InitializeComponent();
            _bllTipo = new BLLTipo();

            dgvTipos.DataSource = null;
            dgvTipos.DataSource = _bllTipo.Listar();

            campoRequerido1.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(inputNombre.Text.Trim()))
                {
                    campoRequerido1.Show();
                    throw new Exception("Datos incorrectos. Vuelva a ingresarlos por favor.");
                }

                BETipo tipo = new BETipo(inputNombre.Text);
                bool guardado = _bllTipo.Guardar(tipo);

                if (guardado)
                {
                    dgvTipos.DataSource = null;
                    dgvTipos.DataSource = _bllTipo.Listar();
                    campoRequerido1.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
