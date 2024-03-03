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

namespace UI
{
    public partial class FormInformesListarDeBaja : Form
    {
        private BLLAuto _bllAuto;

        public FormInformesListarDeBaja()
        {
            InitializeComponent();
        }

        private void FormInformesListarDeBaja_Load(object sender, EventArgs e)
        {
            _bllAuto = new BLLAuto();

            btnAsc.Checked = true;

            dgvListadoAutos.DataSource = null;
            dgvListadoAutos.DataSource = _bllAuto.ListarAutosDeBaja();
            SetearNombreColumnas();
        }

        private void btnDesc_CheckedChanged(object sender, EventArgs e)
        {
            dgvListadoAutos.DataSource = null;
            dgvListadoAutos.DataSource = _bllAuto.ListarAutosDeBaja("DESC");
            SetearNombreColumnas();
        }

        private void btnAsc_CheckedChanged(object sender, EventArgs e)
        {
            dgvListadoAutos.DataSource = null;
            dgvListadoAutos.DataSource = _bllAuto.ListarAutosDeBaja();
            SetearNombreColumnas();
        }

        private void SetearNombreColumnas()
        {
            // Editar el nombre de las columnas
            dgvListadoAutos.Columns["AuPatente"].HeaderText = "Patente";
            dgvListadoAutos.Columns["AuAnio"].HeaderText = "Año";
            dgvListadoAutos.Columns["ValorResidual"].HeaderText = "Valor Residual";
            dgvListadoAutos.Columns["AuEnUso"].HeaderText = "En Uso";
            dgvListadoAutos.Columns["AuValor"].HeaderText = "Valor";
            dgvListadoAutos.Columns["AuFechaIngreso"].HeaderText = "Fecha Ingreso";
            dgvListadoAutos.Columns["AuFechaBaja"].HeaderText = "Fecha Baja";
        }
    }
}
