using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BE;
using BLL;
using Microsoft.VisualBasic;
using UI.Excepciones;
using UI.Eventos;

namespace UI
{
    public partial class FormGestionAutos : Form
    {
        private BLLAuto _bllAuto;

        /*
         * Al intentar dar de alta o modificar el auto si la patente no es correcta se debe 
         * desencadenar un evento que así lo indique e impedir que el auto ingrese a la BD. 
         */
        public delegate void PatenteInvalidaEventHandler(object sender, PatenteInvalidaEventArgs e);
        public event PatenteInvalidaEventHandler PatenteInvalidaEvent;

        public FormGestionAutos()   
        {
            InitializeComponent();
            // Subscriptcion al evento
            this.PatenteInvalidaEvent += ControladorPatenteInvalidaEvent;
        }

        private void FormGestionAutos_Load(object sender, EventArgs e)
        {
            _bllAuto = new BLLAuto();
            ListarDataGridView();
        }

        private void ListarDataGridView()
        {
            dgvGestionAutos.DataSource = null;
            dgvGestionAutos.DataSource = _bllAuto.ListarTodo();
            SetearNombreColumnas();
        }

        private void SetearNombreColumnas()
        {
            // Editar el nombre de las columnas
            dgvGestionAutos.Columns["AuPatente"].HeaderText = "Patente";
            dgvGestionAutos.Columns["AuAnio"].HeaderText = "Año";
            dgvGestionAutos.Columns["ValorResidual"].HeaderText = "Valor Residual";
            dgvGestionAutos.Columns["AuEnUso"].HeaderText = "En Uso";
            dgvGestionAutos.Columns["AuValor"].HeaderText = "Valor";
            dgvGestionAutos.Columns["AuFechaIngreso"].HeaderText = "Fecha Ingreso";
            dgvGestionAutos.Columns["AuFechaBaja"].HeaderText = "Fecha Baja";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = Interaction.InputBox("Ingrese la patente: ", "Patente").ToUpper();

                if (PatenteInvalida(patente))
                {
                    // Invocacion al evento
                    PatenteInvalidaEvent?.Invoke(
                        this, 
                        new PatenteInvalidaEventArgs("El Formato es incorrecto. La patente debe ser (AA123BBB) - (dos letras, tres números y tres letras)")
                    );
                    return;
                }

                // Se lanza una excepcion en caso de que la patente ya exista
                if (PatenteExistente(patente))
                    throw new PatenteExistenteException("Patente existente. Debe ingresar otra.");

                BEAuto nuevoAuto    = PopularCampos();
                nuevoAuto.AuPatente = patente;

                _bllAuto.Alta(nuevoAuto);

                ListarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private BEAuto PopularCampos()
        {
            bool enUso              = Interaction.InputBox("Esta en uso? (Y/N): ", "Uso").ToUpper() == "Y" ? true : false;
            DateTime fechaIngreso   = Convert.ToDateTime(Interaction.InputBox("Ingrese la fecha de ingreso (mm/dd/aaaa): ", "Fecha de Ingreso")).Date;
            DateTime fechaBaja      = enUso ? _bllAuto.ObtenerFechaBajaEnUso() : Convert.ToDateTime(Interaction.InputBox("Ingrese la fecha de baja (mm/dd/aaaa): ", "Fecha de Baja")).Date;
            int anio                = Convert.ToInt32(Interaction.InputBox("Ingrese el año: ", "Año"));
            decimal valor           = Convert.ToDecimal(Interaction.InputBox("Ingrese el valor: $", "Valor"));

            return new BEAuto()
            {
                AuFechaIngreso = fechaIngreso,
                AuFechaBaja = fechaBaja,
                AuAnio = anio,
                AuEnUso = enUso,
                AuValor = valor
            };
        }

        private bool PatenteInvalida(string patente)
        {
            /*
             * Una forma que pense de verificar esto es convertir el string patente
             * a un array de caracteres e ir verificando que los dos primeros sean
             * letras, los terceros numeros y los ultimos tres letras.
             * Pero para realizar esto es mas sencilo usar Regex.
             * Expresion regular que coincide con el patron: dos letras, tres numeros y tres letras
             */
            string patron = @"^[A-Za-z]{2}\d{3}[A-Za-z]{3}$";

            // Verifica si la patente coincide con el patrón
            if(! Regex.IsMatch(patente, patron))
                return true;

            return false;
        }

        private bool PatenteExistente(string patente)
        {
            return _bllAuto.PatenteExistente(patente);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGestionAutos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay autos para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BEAuto autoSeleccionado = (BEAuto)dgvGestionAutos.SelectedRows[0].DataBoundItem;

                DialogResult respuesta = MessageBox.Show($"Esta seguro que desea eliminar el auto con patente: {autoSeleccionado.AuPatente}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.No) 
                    return;

                _bllAuto.Baja(autoSeleccionado);
                ListarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGestionAutos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay autos para modificar.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BEAuto autoSeleccionado = (BEAuto)dgvGestionAutos.SelectedRows[0].DataBoundItem;

                autoSeleccionado.AuEnUso        = Interaction.InputBox("Esta en uso? (Y/N): ", "Uso").ToUpper() == "Y" ? true : false;
                autoSeleccionado.AuFechaIngreso = Convert.ToDateTime(Interaction.InputBox("Ingrese la fecha de ingreso (mm/dd/aaaa): ", "Fecha de Ingreso", autoSeleccionado.AuFechaIngreso.Date.ToString("MM/dd/yyyy"))).Date;
                autoSeleccionado.AuFechaBaja    = autoSeleccionado.AuEnUso ? _bllAuto.ObtenerFechaBajaEnUso() : Convert.ToDateTime(Interaction.InputBox("Ingrese la fecha de baja (mm/dd/aaaa): ", "Fecha de Baja", autoSeleccionado.AuFechaBaja.Date.ToString("MM/dd/yyyy"))).Date;
                autoSeleccionado.AuAnio         = Convert.ToInt32(Interaction.InputBox("Ingrese el año: ", "Año", autoSeleccionado.AuAnio.ToString()));
                autoSeleccionado.AuValor        = Convert.ToDecimal(Interaction.InputBox("Ingrese el valor: $", "Valor", autoSeleccionado.AuValor.ToString()));

                _bllAuto.Modificar(autoSeleccionado);
                ListarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ControladorPatenteInvalidaEvent(object sender, PatenteInvalidaEventArgs e)
        {
            MessageBox.Show(e.Mensaje);
        }

    }
}
