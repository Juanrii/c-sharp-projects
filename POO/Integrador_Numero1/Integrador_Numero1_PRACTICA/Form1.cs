using Integrador_Numero1_PRACTICA.Clases;
using Integrador_Numero1_PRACTICA.Gestores;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_Numero1_PRACTICA
{
    public partial class Form1 : Form
    {
        private GestorPersonas _gestorPersonas = new GestorPersonas();

        private GestorAutos _gestorAutos = new GestorAutos();

        private GestorAutoPersonaVista _gestorAutosPersonas = new GestorAutoPersonaVista();

        private Persona _personaSeleccionada = null;

        private Auto _autoSeleccionado = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarDataGridViews();
        }

        private void InicializarDataGridViews()
        {
            dgvPersonas.DataSource      = null;
            dgvPersonas.DataSource      = new List<Persona>();
            dgvAutos.DataSource         = null;
            dgvAutos.DataSource         = new List<Auto>();
            dgvAutosPersona.DataSource  = null;
            dgvAutosPersona.DataSource  = new List<Auto>();
            dgvDueniosAutos.DataSource  = null;
            dgvDueniosAutos.DataSource  = new List<AutoPersonaVista>();
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = Interaction.InputBox("Ingrese el DNI: ");
                if (_gestorPersonas.DniExistente(dni))
                {
                    MessageBox.Show($"El DNI ingresado: {dni} ya existe. Por favor ingrese otro.", "DNI Existente");
                    return;
                }

                string nombre   = Interaction.InputBox("Ingrese el Nombre: ");
                string apellido = Interaction.InputBox("Ingrese el Apellido: ");

                if (DatosPersonaVacios(dni, nombre, apellido))
                {
                    MessageBox.Show($"No puede dejar campos incompletos.", "Campos Incompletos");
                    return;
                }

                _gestorPersonas.CrearPersona(dni, nombre, apellido);

                ActualizarDgvPersonas();
            }
            catch (Exception)
            {
                MessageBox.Show("Datos ingresados incorrectos.", "Error");
            }
        }

        private bool DatosPersonaVacios(string dni, string nombre, string apellido)
        {
            return (String.IsNullOrEmpty(dni) || String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido));
        }
        
        private void ActualizarDgvPersonas()
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = _gestorPersonas.ObtenerPersonas();

            labelTotal1.Text = "Totales: ";
            labelTotal1.Text += _gestorPersonas.CantidadPersonas();
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                string patente  = Interaction.InputBox("Ingrese la Patente: ");
                if (_gestorAutos.PatenteExistente(patente))
                {
                    MessageBox.Show($"La Patente ingresada: {patente} ya existe. Por favor ingrese otra.", "Patente Existente");
                    return;
                }

                string marca    = Interaction.InputBox("Ingrese la Marca: ");
                string modelo   = Interaction.InputBox("Ingrese el Modelo: ");
                string anio     = Interaction.InputBox("Ingrese el Año: ");
                decimal precio  = Convert.ToDecimal(Interaction.InputBox("Ingrese el Precio: "));

                if (DatosAutosVacios(marca, modelo, anio, precio))
                {
                    MessageBox.Show($"No puede dejar campos incompletos.", "Campos Incompletos");
                    return;
                }

                _gestorAutos.CrearAuto(patente, marca, modelo, anio, precio);

                ActualizarDgvAutos();
            }
            catch (Exception)
            {
                MessageBox.Show("Datos ingresados incorrectos.", "Error");
            }
        }

        private void ActualizarDgvAutos()
        {
            dgvAutos.DataSource = null;
            dgvAutos.DataSource = _gestorAutos.ObtenerAutos();

            labelTotal2.Text = "Totales: ";
            labelTotal2.Text += _gestorAutos.CantidadAutos();
        }

        private bool DatosAutosVacios(string marca, string modelo, string anio, decimal precio)
        {
            return (String.IsNullOrEmpty(marca) || String.IsNullOrEmpty(modelo) || String.IsNullOrEmpty(anio) || String.IsNullOrEmpty(precio.ToString()));
        }

        private void btnAsignarDuenio_Click(object sender, EventArgs e)
        {
            if (_personaSeleccionada != null && _autoSeleccionado != null)
            {
                _gestorAutos.AsignarDuenio(_personaSeleccionada, _autoSeleccionado);

                _gestorAutosPersonas.AgregarAutoPersona(_autoSeleccionado);


                ActualizarDgvAutosDePersona();
                ActualizarDgvAutosConDuenio();
            }
        }

        private void ActualizarDgvAutosConDuenio()
        {
            dgvDueniosAutos.DataSource = null;
            dgvDueniosAutos.DataSource = _gestorAutosPersonas.ObtenerAutosDuenios();

            labelTotal4.Text = "Totales: ";
            labelTotal4.Text += _gestorAutosPersonas.CantidadAutosDuenios();
        }

        private void ActualizarDgvAutosDePersona()
        {
            dgvAutosPersona.DataSource = null;
            dgvAutosPersona.DataSource = _personaSeleccionada?.ListaDeAutos();

            labelTotal3.Text = "Totales: ";
            labelTotal3.Text += _personaSeleccionada?.CantidadDeAutos();
        }

        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count == 1)
            {
                _personaSeleccionada = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
                ActualizarDgvAutosDePersona();
            }
        }

        private void dgvAutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAutos.SelectedRows.Count == 1)
            {
                _autoSeleccionado = (Auto)dgvAutos.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            if (_personaSeleccionada != null)
            {
                DialogResult dialogResult = MessageBox.Show($"¿Desea eliminar la persona con DNI: {_personaSeleccionada.DNI}?", 
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    _gestorPersonas.EliminarPersona(_personaSeleccionada);

                    _gestorAutos.EliminarDuenio(_personaSeleccionada);

                    _gestorAutosPersonas.BorrarDuenio(_personaSeleccionada);

                    _personaSeleccionada = null;

                    ActualizarDgvPersonas();
                    ActualizarDgvAutos();
                    ActualizarDgvAutosDePersona();
                    ActualizarDgvAutosConDuenio();
                }
            }
        }

        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            if (_autoSeleccionado != null)
            {
                DialogResult dialogResult = MessageBox.Show($"¿Desea eliminar el auto con Patente: {_autoSeleccionado.Patente}?",
                   "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Persona duenio = _autoSeleccionado.Duenio();

                    _gestorAutos.EliminarAuto(_autoSeleccionado);

                    duenio.QuitarAuto(_autoSeleccionado);

                    _gestorAutosPersonas.BorrarAuto(_autoSeleccionado);

                    _autoSeleccionado = null;

                    ActualizarDgvPersonas();
                    ActualizarDgvAutos();
                    ActualizarDgvAutosDePersona();
                    ActualizarDgvAutosConDuenio();
                }
            }
        }
    }
}
