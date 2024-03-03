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
    public partial class FormInformesListar : Form
    {
        private BLLAuto _bllAuto;
        public FormInformesListar()
        {
            InitializeComponent();
        }

        private void FormInformesListar_Load(object sender, EventArgs e)
        {
            _bllAuto = new BLLAuto();
            ListarDataGridView();
        }

        private void ListarDataGridView()
        {
            dgvListadoAutos.DataSource = null;
            dgvListadoAutos.DataSource = _bllAuto.ListarTodo();
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
