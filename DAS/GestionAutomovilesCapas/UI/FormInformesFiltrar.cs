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
    public partial class FormInformesFiltrar : Form
    {
        private BLLAuto _bllAuto;
        private string patronPatente = "";
        public FormInformesFiltrar()
        {
            InitializeComponent();
        }
        private void FormInformesFiltrar_Load(object sender, EventArgs e)
        {
            _bllAuto = new BLLAuto();
            dgvAutosFiltrados.DataSource = null;
            dgvAutosFiltrados.DataSource = _bllAuto.ListarTodo();
            SetearNombreColumnas();
        }

        private void inputPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si se presiono la tecla de retroseso para borrar
                if (e.KeyChar == (char)Keys.Back)
                {
                    // Verifica que haya algo escrito
                    if (patronPatente.Length > 0)
                    {
                        // Borra el ultinmo caracter
                        patronPatente = patronPatente.Remove(patronPatente.Length - 1);
                    }
                }
                // Verifica que la tecla no sea Enter
                else if (!char.IsControl(e.KeyChar))
                {
                    // Concatena el string para formar el inicio de patente
                    patronPatente += e.KeyChar.ToString().ToUpper();
                }

                dgvAutosFiltrados.DataSource = null;
                dgvAutosFiltrados.DataSource = _bllAuto.FiltrarPorPatente(patronPatente);
                SetearNombreColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void SetearNombreColumnas()
        {
            // Editar el nombre de las columnas
            dgvAutosFiltrados.Columns["AuPatente"].HeaderText = "Patente";
            dgvAutosFiltrados.Columns["AuAnio"].HeaderText = "Año";
            dgvAutosFiltrados.Columns["ValorResidual"].HeaderText = "Valor Residual";
            dgvAutosFiltrados.Columns["AuEnUso"].HeaderText = "En Uso";
            dgvAutosFiltrados.Columns["AuValor"].HeaderText = "Valor";
            dgvAutosFiltrados.Columns["AuFechaIngreso"].HeaderText = "Fecha Ingreso";
            dgvAutosFiltrados.Columns["AuFechaBaja"].HeaderText = "Fecha Baja";
        }
    }
}
