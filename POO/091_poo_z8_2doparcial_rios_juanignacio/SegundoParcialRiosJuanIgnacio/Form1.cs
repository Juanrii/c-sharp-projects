using SegundoParcialRiosJuanIgnacio.Clases;
using SegundoParcialRiosJuanIgnacio.Gestores;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SegundoParcialRiosJuanIgnacio.Eventos;
using SegundoParcialRiosJuanIgnacio.Excepciones;
using SegundoParcialRiosJuanIgnacio.Servicios;

namespace SegundoParcialRiosJuanIgnacio
{
    public partial class Form1 : Form
    {
        private Socio _socioSeleccionado = null;
        private Cuota _cuotaSeleccionada = null;
        private GestorSocios _gestorSocio = null;
        private GestorCuotas _gestorCuota = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _gestorSocio = new GestorSocios();
            _gestorCuota = new GestorCuotas();
            LimpiarDataGridViews(dgv1Socios, _gestorSocio.Clone());
            radioBtnASC.Checked = true;
        }

        private void LimpiarDataGridViews(DataGridView dgv, Object lista)
        {
            dgv.DataSource = null;
            dgv.DataSource = lista;
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Socio tipo = ObtenerTipoDeSocio();

                if (tipo == null) throw new Exception("Debe seleccionar un tipo de socio.");

                string legajo = Interaction.InputBox("Ingrese el legajo: ").ToUpper();
                if (String.IsNullOrEmpty(legajo))
                    throw new Exception("El legajo no puede ser vacio");

                if (_gestorSocio.LegajoExistente(legajo))
                    throw new Exception($"El legajo: {legajo} ya existe. Por favor ingrese otro");

                string nombre   = Interaction.InputBox("Ingrese el nombre: ");
                string apellido = Interaction.InputBox("Ingrese el apellido: ");

                if (DatosVacios(nombre, apellido))
                    throw new Exception("Los campos no pueden ser vacios");

                // Delegar creacion
                _gestorSocio.Agregar(legajo, nombre, apellido, tipo);

                LimpiarDataGridViews(dgv1Socios, _gestorSocio.Clone());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private Socio ObtenerTipoDeSocio()
        {
            if (radioBtnSocioNormal.Checked)        return new SocioNormal();
            else if (radioBtnSocioEspecial.Checked) return new SocioEspecial();
            else return null;
        }

        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewVacio(dgv1Socios))
                    throw new Exception("No existen socios para modificar");

                if (_socioSeleccionado == null)
                    throw new Exception("Debe seleccionar un socio para modificarlo");

                string nombre   = Interaction.InputBox("Ingrese el nombre: ", "Modificar");
                string apellido = Interaction.InputBox("Ingrese el apellido: ", "Modificar");

                if (DatosVacios(nombre, apellido))
                    throw new Exception("Los datos ingresados no pueden ser vacios");

                _gestorSocio.Modificar(nombre, apellido, _socioSeleccionado);

                LimpiarDataGridViews(dgv1Socios, _gestorSocio.Clone());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private bool DatosVacios(string datoA, string datoB)
        {
            return String.IsNullOrEmpty(datoA) || String.IsNullOrEmpty(datoB);

        }

        private bool DataGridViewVacio(DataGridView dgv)
        {
            return dgv.Rows.Count == 0;
        }

        private void dgv1Socios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv1Socios.SelectedRows.Count == 1)
            {
                _socioSeleccionado = (Socio)dgv1Socios.SelectedRows[0].DataBoundItem;
                LimpiarDataGridViews(dgv2CuotasAsginadas, _gestorCuota.ObtenerCuotasAsignadas(_socioSeleccionado));
                LimpiarDataGridViews(dgv3CuotasPagadas, _gestorCuota.ObtenerCuotasPagadas(_socioSeleccionado));
                LimpiarDataGridViews(dgv4CuotasOrdenadas, _gestorCuota.ObtenerCuotasPagadasOrdenadas(_socioSeleccionado));
            }
        }

        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewVacio(dgv1Socios))
                    throw new Exception("No existen socios para eliminar");

                if (_socioSeleccionado == null)
                    throw new Exception("Debe seleccionar un socio para eliminarlo");

                if (_socioSeleccionado.ObtenerCantidadCuotas() > 0)
                {
                    int cuotas = _socioSeleccionado.ObtenerCantidadCuotas();
                    throw new Exception($"El socio con legajo: {_socioSeleccionado.Legajo} tiene asignado " +
                        $"una cantidad de: {cuotas} cuotas. No puede eliminarlo.");
                }

                DialogResult dialogResult = MessageBox.Show($"¿Esta seguro que desea eliminar el socio con legajo: {_socioSeleccionado.Legajo}?",
                    "Aviso", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    _gestorSocio.Eliminar(_socioSeleccionado);
                    LimpiarDataGridViews(dgv1Socios, _gestorSocio.Clone());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAsignarCuota_Click(object sender, EventArgs e)
        {
            try
            {
                if (_socioSeleccionado == null)
                    throw new Exception("Debe seleccionar un socio para asignarle una cuota");

                if (_socioSeleccionado.ObtenerCuotasAdeudadas() >= 2)
                    throw new Exception("El socio no puede tener pendientes más de dos cuotas sin pagar");
                
                string codigo = Interaction.InputBox("Ingrese el codigo: ", "Nueva Cuota").ToUpper();
                if (String.IsNullOrEmpty(codigo))
                    throw new Exception("El codigo no puede ser vacio");

                if (_gestorCuota.CodigoExistente(codigo))
                    throw new Exception($"El codigo: {codigo} ya existe. Por favor ingrese otro");

                int mes = Convert.ToInt32(Interaction.InputBox("Ingrese el mes (MM): "));
                if (MesInvalido(mes))
                    throw new Exception($"Mes incorrecto: {mes}. Debe estar entre 1 y 12");

                int anio = Convert.ToInt32(Interaction.InputBox("Ingrese el año (yyyy): "));
                if (AñoInvalido(anio))
                    throw new Exception($"Formato del año incorrecto: {anio}. Debe ser (yyyy) y no puede ser menor o mayor al año acutal: {DateTime.Now.Year}");

                if (_socioSeleccionado.ObtenerCuotaPorFecha(mes, anio))
                    throw new Exception($"La cuota para el mes: {mes} y año: {anio} ya existe.");

                double importe = Convert.ToDouble(Interaction.InputBox("Ingrese el importe: $"));

                // Cuota
                Cuota cuota = _gestorCuota.Asginar(codigo, mes, anio, importe, _socioSeleccionado);

                // Socio
                _gestorSocio.AsginarCuota(_socioSeleccionado, cuota);

                LimpiarDataGridViews(dgv2CuotasAsginadas, _gestorCuota.ObtenerCuotasPendientes(_socioSeleccionado));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private bool AñoInvalido(int anio)
        {
            return anio != DateTime.Now.Year;
        }

        private bool MesInvalido(int mes)
        {
            return mes < 1 || mes > 12;
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            try
            {
                if (_socioSeleccionado == null)
                    throw new Exception("Debe seleccionar un socio para pagar la cuota");

                if (_cuotaSeleccionada == null)
                    throw new Exception("Debe seleccionar una cuota a pagar");

                if (_cuotaSeleccionada.GetPagada())
                    throw new Exception("La cuota ya esta pagada");

                double importe = _cuotaSeleccionada.ObtenerImporte();
                double adicional = _socioSeleccionado.ObtenerAdicional(_cuotaSeleccionada);
                DialogResult dialogResult = MessageBox.Show(
                    $"Importe a pagar: {importe}{Environment.NewLine}" +
                    $"Recargo: {adicional}{Environment.NewLine}" +
                    $"Total: {importe + adicional}{Environment.NewLine}" +
                    $"¿Desea pagar la cuota: {_cuotaSeleccionada.Codigo} perteneciente al mes {_cuotaSeleccionada.Mes} del año: {_cuotaSeleccionada.Anio}?",
                    "Aviso", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    _socioSeleccionado.ImporteExcedido += ImporteExcedidoFn;
                    _socioSeleccionado.Pagar(importe + adicional);
                    _gestorCuota.Pagada(_cuotaSeleccionada);


                    LimpiarDataGridViews(dgv2CuotasAsginadas, _gestorCuota.ObtenerCuotasPendientes(_socioSeleccionado));
                    LimpiarDataGridViews(dgv3CuotasPagadas, _gestorCuota.ObtenerCuotasPagadas(_socioSeleccionado));
                    LimpiarDataGridViews(dgv4CuotasOrdenadas, _gestorCuota.ObtenerCuotasPagadasOrdenadas(_socioSeleccionado));
                    ActualizarCuotasPagadasDGV5();
                    _socioSeleccionado.ImporteExcedido -= ImporteExcedidoFn;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
            
        }

        private void ActualizarCuotasPagadasDGV5()
        {
            
            LimpiarDataGridViews(dgv5CobrosPagados, _gestorSocio.ObtenerCuotasPagadas());
            dgv5CobrosPagados.Columns["ImporteConAdicional"].HeaderText = "Importe + Adicional";
        }

        private void ImporteExcedidoFn(object sender, ImporteExcedidoEventArgs e)
        {
            try
            {
                string message = $"El importe a pagar: {(e.ImporteTotalAPagar).ToString("F2")} supera los $10.000";
                throw new ImporteExcedidoException(message);
            }
            catch (Exception ex ) { MessageBox.Show(ex.Message, "Aviso"); }
            
        }

        private void dgv2CuotasAsginadas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv2CuotasAsginadas.SelectedRows.Count == 1)
            {
                _cuotaSeleccionada = (Cuota)dgv2CuotasAsginadas.SelectedRows[0].DataBoundItem;
            }
        }

        private void radioBtnASC_CheckedChanged(object sender, EventArgs e)
        {
            if (_socioSeleccionado != null)
            {
                var lista = _gestorCuota.ObtenerCuotasPagadas(_socioSeleccionado);
                lista.Sort(new ImporteASC());
                LimpiarDataGridViews(dgv4CuotasOrdenadas, lista);
            }
        }

        private void radioBtnDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (_socioSeleccionado != null)
            {
                var lista = _gestorCuota.ObtenerCuotasPagadas(_socioSeleccionado);
                lista.Sort(new ImporteDESC());
                LimpiarDataGridViews(dgv4CuotasOrdenadas, lista);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewVacio(dgv1Socios))
                    throw new Exception("No existen socios para asignar cuotas. Por favor ingrese al menos uno.");

                DialogResult dialogResult = MessageBox.Show($"¿Esta seguro que desea asignar multiples cuotas a distintos socios?",
                        "Aviso", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int mes = Convert.ToInt32(Interaction.InputBox("Ingrese el mes (MM): "));
                    if (MesInvalido(mes))
                        throw new Exception($"Mes incorrecto: {mes}. Debe estar entre 1 y 12");

                    int anio = Convert.ToInt32(Interaction.InputBox("Ingrese el año (yyyy): "));
                    if (AñoInvalido(anio))
                        throw new Exception($"Formato del año incorrecto: {anio}. Debe ser (yyyy) y no puede ser menor o mayor al año acutal: {DateTime.Now.Year}");

                    double importe = Convert.ToDouble(Interaction.InputBox("Ingrese el importe: $"));

                    // Se delega al servicio
                    ServicioAgregarMultiples servicio = new ServicioAgregarMultiples(mes, anio, importe, _gestorCuota, _gestorSocio);

                    LimpiarDataGridViews(dgv1Socios, _gestorSocio.Clone());
                    LimpiarDataGridViews(dgv2CuotasAsginadas, _gestorCuota.ObtenerCuotasAsignadas(_socioSeleccionado));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
