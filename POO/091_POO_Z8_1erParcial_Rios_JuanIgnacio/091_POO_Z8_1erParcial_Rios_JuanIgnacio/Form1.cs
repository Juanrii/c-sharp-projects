using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases;
using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Eventos;
using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Excepciones;
using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Gestores;
using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Servicios;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio
{
    public partial class Form1 : Form
    {
        #region "Gestores"
        GestorEmpleados _gestorEmpleados = new GestorEmpleados();
        GestorAdelantos _gestorAdelantos = new GestorAdelantos();
        GestorEmpleadoAdelantoVista _gestorEmpleadoAdelantoVista = new GestorEmpleadoAdelantoVista();
        #endregion

        #region "Propiedades Privadas"
        private Empleado _empleadoSeleccionado = null;
        private Adelanto _adelantoSeleccionado = null;
        private EmpleadoAdelantoVista _empleadoAdelantoSeleccionado = null;
        #endregion

        #region "Constantes"
        private const string TITULO_NUEVO_E = "Nuevo Empleado";
        private const string TITULO_MOD_E = "Modificar Empleado";
        private const string TITULO_NUEVO_A = "Nuevo Adelanto";
        private const string TITULO_MOD_A = "Modificar Adelanto";
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario se inicializan las tres DataGridViews
            ActualizarDgvEmpleados();
            ActualizarDgvAdelantos();
            ActualizarDgvEmpleadosAdelantos();

            // Se setea en false el AutoSize de los TextBox para luego editarlos
            inputTotalAdeudado.AutoSize = false;
            inputTotalImporteAsignado.AutoSize = false;

            // Seteo de altura
            inputTotalImporteAsignado.Height = 30;
            inputTotalAdeudado.Height = 30;

            // Seteo en cero los valores de los TextBox
            inputTotalImporteAsignado.Text = "$0.00";
            inputTotalAdeudado.Text = "$0.00";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se obtiene una instacia del tipo Empleado (Adminstrativo, Directivo u Operario)
                Empleado tipo = ObtenerTipoDeEmpleado();

                // En caso de que no haya seleccionado un tipo, se lanza la excepcion
                if (tipo == null) throw new Exception("Debe seleccionar un tipo de empleado");

                string legajo = Interaction.InputBox("Ingrese el legajo: ", TITULO_NUEVO_E).ToUpper();
                if (String.IsNullOrEmpty(legajo))
                    throw new Exception("El legajo no puede ser vacio");

                // Se valida si el legajo ingresado existe
                if (_gestorEmpleados.LegajoExistente(legajo))
                    throw new Exception($"El legajo: {legajo} ya existe. Por favor ingrese otro");

                // Se almacenan los datos ingresados por el usuario
                string nombre = Interaction.InputBox("Ingrese el nombre: ", TITULO_NUEVO_E);
                string apellido = Interaction.InputBox("Ingrese el apellido: ", TITULO_NUEVO_E);
                double sueldo = Convert.ToInt32(Interaction.InputBox("Ingrese el sueldo: ", TITULO_NUEVO_E));

                if (DatosVacios(nombre, apellido, sueldo))
                    throw new Exception("Los datos ingresados no pueden ser vacios");

                // Se delega la cracion al gestor de empleados
                _gestorEmpleados.CrearEmpleado(legajo, nombre, apellido, sueldo, tipo);

                // Actualizamos el Dgv con el nuevo empleado
                ActualizarDgvEmpleados();

                LimpiarRadioButtons();
            }
            catch (Exception ex)
            {
                // Si ocurre alguna excepcion, se mostrar un mensaje con el error
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /*
         * Cada vez que se agregue un empleado, se limpian los radio buttons.
         */
        private void LimpiarRadioButtons()
        {
            radioBtnAdministrativo.Checked = false;
            radioBtnDirectivo.Checked = false;
            radioBtnOperario.Checked = false;
        }

        /* 
         * Devuelve una instancia que hereda de Empelado
         * segun el radio button seleccionado
         */
        private Empleado ObtenerTipoDeEmpleado()
        {
            if (radioBtnAdministrativo.Checked) return new Administrativo();
            else if (radioBtnDirectivo.Checked) return new Directivo();
            else if (radioBtnOperario.Checked) return new Operario();
            else return null;
        }

        public void ActualizarDgvEmpleados()
        {
            dgvBeneficiarios.DataSource = null;
            dgvBeneficiarios.DataSource = _gestorEmpleados.ObtenerListadoEmpleados();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si el DataGridView esta vacio, recibe un tipo DataGridView
                if (DataGridViewVacio(dgvBeneficiarios))
                    throw new Exception("No existen empleados para eliminar");

                // Verifica si no hay un empleado seleccionado
                if (_empleadoSeleccionado == null)
                    throw new Exception("Debe seleccionar un empleado para eliminarlo");

                // Verifica si el empleado seleccionado ya posee adelantos asignados
                if (_empleadoSeleccionado.TieneAdelantos())
                {
                    // Obtiene la cantidad de adelantos
                    int adelantos = _empleadoSeleccionado.ObtenerCantidadAdelantos();
                    string adelantosTexto = adelantos > 1 ? $"{adelantos} adelantos" : $"{adelantos} adelanto";

                    // Lanza excepcion mostrando la cantidad de adelantos asignados
                    throw new Exception($"El empleado con legajo: {_empleadoSeleccionado.Legajo} tiene asignado {adelantosTexto}. No puede eliminarlo.");
                }

                // Se muestra un mensaje y se guarda la respuesta del usuario
                DialogResult dialogResult = MessageBox.Show($"¿Esta seguro que desea eliminar el empleado con legajo: {_empleadoSeleccionado.Legajo}?",
                    "Aviso", MessageBoxButtons.YesNo);

                // En caso de que quiera eliminar el empleado
                if (dialogResult == DialogResult.Yes)
                {
                    // Se delega le eliminacion al gestor de epleados,
                    // pasandole como argumento el empleado seleccionado
                    _gestorEmpleados.EliminarEmpleado(_empleadoSeleccionado);

                    // Actualiza el DataGridView sin el empleado eliminado
                    ActualizarDgvEmpleados();
                }
            }
            catch (Exception ex)
            {
                // En caso de que ocurra una excepcion, se mostrara con su mensaje
                MessageBox.Show(ex.Message, "Error");
            }

        }

        /*
         * Verifica si el DataGridView esta vacio, recibe un tipo DataGridView
         */
        private bool DataGridViewVacio(DataGridView dgv)
        {
            return dgv.Rows.Count == 0;
        }

        private void dgvBeneficiarios_SelectionChanged(object sender, EventArgs e)
        {
            // En caso de que haya una fila de los empleados seleccionada
            if (dgvBeneficiarios.SelectedRows.Count == 1)
            {
                // Se guarda el empleado seleccionado
                _empleadoSeleccionado = (Empleado)dgvBeneficiarios.SelectedRows[0].DataBoundItem;

                // Se actualiza el DataGridView 3 que tiene informacion
                // de los adelantos asignados al empleado seleccionado en el DataGridView 1
                ActualizarDgvEmpleadosAdelantos(_empleadoSeleccionado);

                // Se actualizan los TextBox de totales para
                // el empleado seleccionado
                ActualizarInputsTotales();
            }
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                // Si el DataGridView de empleados esta vacio, lanza una excepcion
                if (DataGridViewVacio(dgvBeneficiarios))
                    throw new Exception("No existen empleados para modificar");

                // Verifica que exista un empleado seleccionado
                if (_empleadoSeleccionado == null)
                    throw new Exception("Debe seleccionar un empleado para modificarlo");

                // Verifica si el empleado que se desea eliminar ya posee
                // adelantos otorgados. En caso de que tenga adelantos,
                // se lanza una excepcion y se le da aviso al usuario
                if (_empleadoSeleccionado.TieneAdelantos())
                    throw new Exception($"El empleado con legajo: {_empleadoSeleccionado.Legajo} " +
                        $"posee el adelantos asignados. No puede modificarlo.");


                // Se guardan los valores a modificar del empleado. El legajo no es modificable
                string nombre = Interaction.InputBox("Ingrese el nombre: ", TITULO_MOD_E);
                string apellido = Interaction.InputBox("Ingrese el apellido: ", TITULO_MOD_E);
                double sueldo = Convert.ToInt32(Interaction.InputBox("Ingrese el sueldo: ", TITULO_MOD_E));

                if (DatosVacios(nombre, apellido, sueldo))
                    throw new Exception("Los datos ingresados no pueden ser vacios");


                // Se delega la modificacion al gestor de empleados pasandole como argumentos
                // los nuevos datos y el empleado seleccionado
                _gestorEmpleados.ModificarEmpleado(nombre, apellido, sueldo, _empleadoSeleccionado);

                // Se actualiza el DataGridView con los nuevos datos
                ActualizarDgvEmpleados();
            }
            catch (Exception ex)
            {
                // Si ocurre alguna excepcion, se mostrara el mensaje
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private bool DatosVacios(string nombre, string apellido, double sueldo)
        {
            return String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido) || sueldo == 0;
        }

        private void btnCrearAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                // Se obtiene el codigo ingresado por el usuario
                string codigo = Interaction.InputBox("Ingrese el codigo: ", TITULO_NUEVO_A).ToUpper();

                // Verifica si el codigo ingresado es invalido
                if (CodigoInvalido(codigo))
                    throw new Exception("El formato del codigo es invalido. Debe ser conformado de la siguiente manera: 1234ABCD");

                // Se delega la verificaion del codigo existente al gestor de adelantos
                if (_gestorAdelantos.CodigoExistente(codigo))
                    throw new Exception($"El codigo: {codigo} ya existe. Por favor ingrese otro.");

                // Se guardan los valores ingresados por el usuario
                double importeOtorgado = Convert.ToDouble(Interaction.InputBox("Ingrese el importe: ", TITULO_NUEVO_A));

                // Se delega la cracion del adelanto al gestor de adelantos
                _gestorAdelantos.CrearAdelanto(codigo, importeOtorgado);

                // Se actualiza el DataGridView 2 con el nuevo adelanto
                ActualizarDgvAdelantos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /*
         * El codigo del Adelanto debe ser alfanumerico. Ej: 1234ABCD
         */
        private bool CodigoInvalido(string codigo)
        {
            // La cantidad de caracteres debe ser 8
            if (codigo.Length != 8) return true;

            // Se almacena en un array de chars cada letra del codigo ingresado
            char[] array = codigo.ToCharArray();

            // Se validan que los primero 4 caracteres sean numeros
            // y luego que los 4 que siguen sean letras
            if (! array.Take(4).All(Char.IsNumber) || ! array.Skip(4).All(Char.IsLetter))
                return true;

            // Se retorna false si todo esta bien. Codigo valido
            return false;
        }

        private void ActualizarDgvAdelantos()
        {
            dgvAdelantos.DataSource = null;
            dgvAdelantos.DataSource = _gestorAdelantos.ObtenerListadoAdelantos();
        }

        private void btnEliminarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si el DataGridView 2 de adelantos esta vacio
                if (DataGridViewVacio(dgvAdelantos))
                    throw new Exception("No existen adelantos para eliminar");

                // Verifica si no hay un adelanto seleccionado en el DataGridView 2 de adelantos
                if (_adelantoSeleccionado == null)
                    throw new Exception("Debe seleccionar un adelanto para eliminarlo");

                // Verifica si el adelanto seleccionado tiene un empleado asignado
                if (_adelantoSeleccionado.TieneBeneficiario())
                    throw new Exception($"El adelanto con codigo: {_adelantoSeleccionado.Codigo} " +
                        $"posee el beneficiario con legajo: {_adelantoSeleccionado.ObtenerEmpleado().Legajo}. No puede eliminarlo.");


                // Se guarda la eleccion del usuario
                DialogResult dialogResult = MessageBox.Show($"¿Esta seguro que desea eliminar el adelanto con codigo: {_adelantoSeleccionado.Codigo}?",
                    "Aviso", MessageBoxButtons.YesNo);

                // En caso de que quiera eliminarlo
                if (dialogResult == DialogResult.Yes)
                {
                    // Se delega la eliminacion al gestor de adelantos pasandole
                    // como argumento el adelanto seleccionado
                    _gestorAdelantos.EliminarAdelanto(_adelantoSeleccionado);
                    ActualizarDgvAdelantos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgvAdelantos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdelantos.SelectedRows.Count == 1)
                _adelantoSeleccionado = (Adelanto)dgvAdelantos.SelectedRows[0].DataBoundItem;
        }

        private void btnModificarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si existen adelantos en la DataGridView
                if (DataGridViewVacio(dgvAdelantos))
                    throw new Exception("No existen adelantos para modificar");

                // Verifica si existen un adelanto seleccionado la DataGridView
                if (_adelantoSeleccionado == null)
                    throw new Exception("Debe seleccionar un adelanto para modificarlo");


                // Verifica si el adelanto seleccionado tiene un empleado asignado
                if (_adelantoSeleccionado.TieneBeneficiario())
                    throw new Exception($"El adelanto con codigo: {_adelantoSeleccionado.Codigo} " +
                        $"posee el beneficiario con legajo: {_adelantoSeleccionado.ObtenerEmpleado().Legajo}. No puede modificarlo.");

                // Se guardan los valores ingresados por el usuario
                double importeOtorgado = Convert.ToDouble(Interaction.InputBox("Ingrese el importe: ", TITULO_MOD_A));

                // Se delega la modificacion al gestor de adelantos,
                // pasandole como argumentos los datos y el adelanto seleccionado
                _gestorAdelantos.ModificarAdelanto(importeOtorgado, _adelantoSeleccionado);

                ActualizarDgvAdelantos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAsignarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si existe un empleado seleccionado o un adelanto seleccionado
                if (_empleadoSeleccionado == null || _adelantoSeleccionado == null)
                    throw new Exception("Debe seleccionar un par Empleado - Adelanto para asignar");

                // Verifica si el adelanto seleccionado tiene un empleado asignado
                if (_gestorAdelantos.EmpleadoExistente(_adelantoSeleccionado))
                    throw new Exception($"El adelanto con codigo: {_adelantoSeleccionado.Codigo} " +
                        $"ya tiene asignado un beneficiario: {_adelantoSeleccionado.ObtenerEmpleado().Nombre} {_adelantoSeleccionado.ObtenerEmpleado().Apellido}");

                // Verifica que la cantidad de adelantos asignados al empleado seleccionado no sea mayor a 3
                if (_gestorEmpleados.CantidadMaximaAdelantos(_empleadoSeleccionado))
                    throw new Exception($"El beneficiario: {_empleadoSeleccionado.Nombre} alcanzo el maximo de adelantos");

                // Verifica si la suma de importes otorgados de los adelantos no supere el sueldo del empleado
                if (_gestorAdelantos.SuperaSumatoriaAdelantos(_empleadoSeleccionado, _adelantoSeleccionado))
                    throw new Exception($"El monto total de adelantos supera el sueldo del empleado: {_empleadoSeleccionado.Nombre} ");

                // Verifica que el importe otorgado del adelanto no supere el 50% del sueldo del empleado
                if (_gestorAdelantos.SuperaMitadDelSueldo(_empleadoSeleccionado, _adelantoSeleccionado))
                    throw new Exception($"La cantidad de importe de adelantos supera el 50% del sueldo: ${_empleadoSeleccionado.Sueldo / 2}");

                // Se delega la asignacion de adelanto al gestor empleados
                _gestorEmpleados.AgregarAdelanto(_empleadoSeleccionado, _adelantoSeleccionado);

                // Se delega la asignacion de empleado al gestor adelantos
                _gestorAdelantos.AgregarEmpleado(_adelantoSeleccionado, _empleadoSeleccionado);

                // Se agrega la informacion a gestor de la clase vista y se guarda la instancia creada
                EmpleadoAdelantoVista ea = _gestorEmpleadoAdelantoVista.AgregarEmpleadoAdelanto(_adelantoSeleccionado, _empleadoSeleccionado);

                // Se actualiza el DataGridView 2 de adelantos con los valores del objeto de tipo clase vista
                _gestorAdelantos.ActualizarDatosAdelantos(ea.Beneficio, ea.SaldoAdeudado, _adelantoSeleccionado);

                // Se actualizan los DataGridViews
                ActualizarDgvAdelantos();
                ActualizarDgvEmpleadosAdelantos(_empleadoSeleccionado);

                ActualizarInputsTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ActualizarInputsTotales()
        {
            // Se obtienen los importes del empleado seleccionado
            // y se actualizan los valores de los TextBox
            double importe = _gestorEmpleadoAdelantoVista.ObtenerImporteTotal(_empleadoSeleccionado);
            inputTotalImporteAsignado.Text = "$" + importe.ToString("F2");

            double adeudado = _gestorEmpleadoAdelantoVista.ObtenerDeudaTotal(_empleadoSeleccionado);
            inputTotalAdeudado.Text = "$" + adeudado.ToString("F2");
        }

        private void ActualizarDgvEmpleadosAdelantos(Empleado empleado = null)
        {
            dgvBeneficiariosAdelantosVista.DataSource = null;
            dgvBeneficiariosAdelantosVista.DataSource = _gestorEmpleadoAdelantoVista.ObtenerListadoEmpleadosAdelantos(empleado);
        }

        private void btnCrearMultiples_Click(object sender, EventArgs e)
        {
            try
            {
                // Se le pregunta al usuario si desaea ejecutar la creacion mulitple de Empleados y Adelantos
                DialogResult dialogResult = MessageBox.Show($"¿Esta seguro que desea crear multiples Empleados y Adealantos??",
                        "Aviso", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    // En caso afirmativo, se instancia el servicio y se le pasa
                    // como argumentos del constructor los gestores 
                    ServicioAgregarMultiples servicio = new ServicioAgregarMultiples(_gestorEmpleados, _gestorAdelantos);

                    // Se ejecuta el metodo
                    servicio.CrearMultiples();

                    // Se actualizan los DataGridViews de empleados y adelantos
                    ActualizarDgvEmpleados();
                    ActualizarDgvAdelantos();

                    // Se deshabilita el boton Crear Multiples
                    btnCrearMultiples.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvBeneficiariosAdelantosVista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBeneficiariosAdelantosVista.SelectedRows.Count == 1)
            {
                _empleadoAdelantoSeleccionado = (EmpleadoAdelantoVista)dgvBeneficiariosAdelantosVista.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnPagarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                if (_empleadoAdelantoSeleccionado == null)
                    throw new Exception("Debe seleccionar un adelanto asignado");

                // Subscripcion al evento de importe invalido
                _empleadoAdelantoSeleccionado.ImportePagadoInvalido += AdelantoImportePagadoInvalido;

                // Verifica si el pago ya ha sido efectuado
                if (_empleadoAdelantoSeleccionado.SaldoAdeudado == 0)
                    throw new Exception("El adelanto ya ha sido pagado");

                // La fecha de devolucion es la fecha actual. Por eso uso DateTime.Now.
                // De esta manera me aseguro que no sea posible la devolucion del pago antes de lo otorgado.
                if (_empleadoAdelantoSeleccionado.FechaOtorgamiento > DateTime.Now)
                    throw new Exception($"No es posible realizar pagos con fechas anteriores a la del otorgamiento: {_empleadoAdelantoSeleccionado.FechaOtorgamiento}");

                // Se guarda el importe ingresado por el usuario
                double importe = Convert.ToDouble(Interaction.InputBox("Ingrese el monto a pagar: "));

                // Se ejecuta el metodo Pagar con el argumento importe ingresado
                _empleadoAdelantoSeleccionado.Pagar(importe);

                _gestorEmpleadoAdelantoVista.PagarAdelanto(_empleadoAdelantoSeleccionado, importe);

                // DgvAdelantos
                _gestorAdelantos.ActualizarImporteAdelantos(_empleadoAdelantoSeleccionado.Codigo, importe);
                ActualizarDgvAdelantos();

                // DgvEmpleadosAdelantos
                ActualizarDgvEmpleadosAdelantos(_empleadoAdelantoSeleccionado.ObtenerEmpleado());

                // Actualizar input deuda. Se limpia el string y se guarda como double
                double deuda = Convert.ToDouble((inputTotalAdeudado.Text).Replace("$", String.Empty));
                // Se le resta el importe ingresado
                deuda -= Convert.ToDouble(importe.ToString("F2"));
                // Se asigna el nuevo valor de lo adeudado
                inputTotalAdeudado.Text = "$" + deuda.ToString("F2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /*
         * Controlador de evento
         */
        private void AdelantoImportePagadoInvalido(object sender, ImportePagadoInvalidoEventArgs e)
        {
            string message = $"Las cancelaciones de los adelantos son siempre por el monto adeudado. " +
                $"El importe adeudado es de ${e.SaldoAdeudado} y se intentó abonar ${e.ImportePagado}. " +
                $"Diferencia: ${Math.Abs(e.SaldoAdeudado - e.ImportePagado).ToString("F2")}";
            
            // Desubscripcion al evento
            _empleadoAdelantoSeleccionado.ImportePagadoInvalido -= AdelantoImportePagadoInvalido;

            throw new ImporteInvalidoException(message);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}   
