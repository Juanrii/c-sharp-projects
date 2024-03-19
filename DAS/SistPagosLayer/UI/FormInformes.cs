using BE;
using BE.Pago;
using BLL;
using BLL.Pago;
using BLL.Persona;
using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UI.Eventos;

namespace UI
{
    public partial class FormInformes : Form
    {
        private BLLInternacional _bllInternacional;
        private BLLNacional _bllNacional;
        private BLLPago _bllPagos;
        private string patronApellido = "";

        // Delegado para el evento PagoExcedido
        public delegate void PagoExcedidoEventHandler(object sender, PagoExcedidoEventArgs e);
        public event PagoExcedidoEventHandler PagoExcedidoEvent;

        public FormInformes()
        {
            InitializeComponent();
            this.PagoExcedidoEvent += ControladoPagoExcedidoEvent;
        }

        private void ControladoPagoExcedidoEvent(object sender, PagoExcedidoEventArgs e)
        {
            MessageBox.Show($"Este pago de {e.ImportePagado} supera los $50.000\nDocumento: {e.Documento}, Apellido: {e.Apellido}, Nombre: {e.Nombre}, Importe Pagado: {e.ImportePagado}, Descuento: {e.Descuento}");
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            _bllInternacional = new BLLInternacional();
            _bllNacional = new BLLNacional();
            _bllPagos = new BLLPago();

            ListarPersonas();

            ListarPagos();

            ListarPersonasXApellido();


        }

        private void ListarPersonasXApellido()
        {
            dgvPersonasXApellido.DataSource = null;
            dgvPersonasXApellido.DataSource = _bllInternacional.ListarTodo();
        }

        private void ListarPagos()
        {
            dgvPagos.DataSource = null;
            dgvPagos.DataSource = _bllPagos.ListarTodo();
        }

        private void ListarPersonas()
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.Columns.Clear(); // Limpia las columnas existentes

            DataGridViewCheckBoxColumn columnaExtranjero = new DataGridViewCheckBoxColumn();
            columnaExtranjero.Name = "Extranjero";
            columnaExtranjero.HeaderText = "¿Internacional?";
            columnaExtranjero.ValueType = typeof(bool);
            columnaExtranjero.ReadOnly = true;
            dgvPersonas.Columns.Add(columnaExtranjero);

            // Establecer el DataSource
            dgvPersonas.DataSource = _bllInternacional.ListarTodo();

            // Manejar el evento DataBindingComplete para actualizar los valores de la columna Extranjero
            dgvPersonas.DataBindingComplete += (sender, e) => {
                foreach (DataGridViewRow row in dgvPersonas.Rows)
                {
                    BEPersona persona = row.DataBoundItem as BEPersona;
                    if (persona is BEInternacional internacional)
                    {
                        row.Cells["Extranjero"].Value = internacional.Extranjero;
                    }
                    else
                    {
                        row.Cells["Extranjero"].Value = false; // O cómo quieras manejar las personas que no son internacionales
                    }
                }
            };
        }


        BEPersona _personaSeleccionada = null;
        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count == 1)
                {
                    _personaSeleccionada = dgvPersonas.SelectedRows[0].DataBoundItem as BEPersona;

                    if (_personaSeleccionada != null)
                    {
                        // Config grilla 3
                        labelPagosPersona.Text = $"Grilla 3: Pagos de: {_personaSeleccionada.Nombre} {_personaSeleccionada.Apellido} - DNI: {_personaSeleccionada.Documento}";

                        dgvPagosPersona.DataSource = null;
                        dgvPagosPersona.DataSource = _bllPagos.ListarPagosPorPersona(_personaSeleccionada);
                        if (dgvPagosPersona.Columns.Count > 0)
                        {
                            // Esconder la columna Persona
                            dgvPagosPersona.Columns[4].Visible = false;
                        }


                        // Config de grilla 4
                        dgvGrilla4.DataSource = null;
                        dgvGrilla4.AutoGenerateColumns = true;
                        dgvGrilla4.DataSource = _bllPagos.ListarDataPorPersona(_personaSeleccionada);
                        if (dgvGrilla4.Columns.Count > 0)
                        {
                            dgvGrilla4.Columns[0].HeaderText = "Documento";
                            dgvGrilla4.Columns[1].HeaderText = "Apellido, Nombre";
                            dgvGrilla4.Columns[2].HeaderText = "Edad";
                            dgvGrilla4.Columns[3].HeaderText = "Suma Importes Pagados";
                            dgvGrilla4.Columns[4].HeaderText = "Suma Importes Descontados";
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void inputApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si se presiono la tecla de retroseso para borrar
                if (e.KeyChar == (char)Keys.Back)
                {
                    // Verifica que haya algo escrito
                    if (patronApellido.Length > 0)
                    {
                        // Borra el ultimo caracter
                        patronApellido = patronApellido.Remove(patronApellido.Length - 1);
                    }
                }
                // Verifica que la tecla no sea Enter
                else if (!char.IsControl(e.KeyChar))
                {
                    // Concatena el string para formar el inicio de patente
                    patronApellido += e.KeyChar.ToString();
                }

                dgvPersonasXApellido.DataSource = null;
                dgvPersonasXApellido.DataSource = _bllInternacional.FiltrarPersonasPorApellido(patronApellido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnListarPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                inputApellido.Text = patronApellido = "";
                ListarPersonasXApellido();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
                return;
            }
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPagosPersona.SelectedRows.Count == 0)
                {
                    MessageBox.Show($"No existen pagos para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (dgvPagosPersona.SelectedRows.Count == 1)
                {
                    BEPago pago = dgvPagosPersona.SelectedRows[0].DataBoundItem as BEPago;

                    BEPersona persona = _bllInternacional.ObtenerPersonaPorDNI(pago.PersonaDoc);

                    _bllPagos.Baja(pago);

                    labelPagosPersona.Text = $"Pagos de: {_personaSeleccionada.Nombre} {_personaSeleccionada.Apellido} - DNI: {_personaSeleccionada.Documento}";

                    dgvPagosPersona.DataSource = null;
                    dgvPagosPersona.DataSource = _bllPagos.ListarPagosPorPersona(persona);
                    if (dgvPagosPersona.Columns.Count > 0)
                    {
                        // Esconder la columna Persona
                        dgvPagosPersona.Columns[4].Visible = false;
                    }

                    dgvPagos.DataSource = null;
                    dgvPagos.DataSource = _bllPagos.ListarTodo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
                return;
            }
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count == 0)
                {
                    MessageBox.Show($"No existen personas para asignarle pagos.", "Agregar Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvPersonas.SelectedRows.Count == 1)
                {
                    _personaSeleccionada = dgvPersonas.SelectedRows[0].DataBoundItem as BEPersona;

                    if (_personaSeleccionada != null)
                    {
                        // Solicitar la fecha al usuario
                        string fechaInput = Interaction.InputBox("Ingrese la fecha (DD/MM/YYYY)", "Fecha");

                        // Expresión regular para validar el formato DD/MM/YYYY
                        string pattern = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}$";
                        bool fechaValida = Regex.IsMatch(fechaInput, pattern);

                        DateTime fecha = DateTime.Now;
                        if (fechaValida)
                        {
                            fecha = DateTime.ParseExact(fechaInput, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).Date;
                        }
                        else
                        {
                            MessageBox.Show("Fecha invalida"); return;
                        }

                        decimal importe = Convert.ToDecimal(Interaction.InputBox("Ingrese el importe: ", "Importe"));

                        decimal importeConDescuento =_bllPagos.CalcularImporte(fecha, importe, _personaSeleccionada);

                        if (_bllPagos.ValidarImporte(importe))
                        {
                            // Invocacion al evento
                            PagoExcedidoEvent?.Invoke(
                                this,
                                new PagoExcedidoEventArgs(
                                    _personaSeleccionada.Documento, 
                                    _personaSeleccionada.Apellido, 
                                    _personaSeleccionada.Nombre, 
                                    importe,  
                                    importeConDescuento
                                )
                            );
                        }
                        
                        BEPago pago = new BEPago()
                        {
                            PagoId = Convert.ToInt32(DateTimeOffset.UtcNow.ToUnixTimeSeconds()),
                            Fecha = fecha,
                            Importe = importeConDescuento,
                            PersonaDoc = _personaSeleccionada.Documento,
                            Persona = _personaSeleccionada
                        };

                        _bllPagos.Alta(pago);

                        dgvPagosPersona.DataSource = dgvPagos.DataSource = null;
                        dgvPagos.DataSource = _bllPagos.ListarTodo();


                        dgvPagosPersona.DataSource = _bllPagos.ListarPagosPorPersona(_personaSeleccionada);
                        if (dgvPagosPersona.Columns.Count > 0)
                        {
                            // Esconder la columna Persona
                            dgvPagosPersona.Columns[4].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
                return;
            }
        }

        private void dgvFiltrarPersonas_Enter(object sender, EventArgs e)
        {

        }
    }
}
