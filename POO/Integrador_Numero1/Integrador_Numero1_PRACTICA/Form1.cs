using Integrador_Numero1_PRACTICA.Clases;
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
        private List<Persona> _personaList = new List<Persona>();

        private List<Auto> _autoList = new List<Auto>();

        private List<AutoPersonaVista> _autoPersonaList = new List<AutoPersonaVista>();

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
                if (DniExistente(dni))
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

                // Esto se podria delegar a una clase Gestor
                Persona nuevaPersona = new Persona()
                {
                    DNI = dni,
                    Nombre = nombre,
                    Apellido = apellido
                };

                _personaList.Add(nuevaPersona);

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

        private bool DniExistente(string dni)
        {
            return _personaList.Find(p => p.DNI == dni) is Persona; 
        }

        private void ActualizarDgvPersonas()
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = _personaList;

            labelTotal1.Text = "Totales: ";
            labelTotal1.Text += _personaList.Count();
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                string patente  = Interaction.InputBox("Ingrese la Patente: ");
                if (PatenteExistente(patente))
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

                Auto nuevoAuto = new Auto(patente, marca, modelo, anio, precio);

                _autoList.Add(nuevoAuto);

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
            dgvAutos.DataSource = _autoList;

            labelTotal2.Text = "Totales: ";
            labelTotal2.Text += _autoList.Count();
        }

        private bool DatosAutosVacios(string marca, string modelo, string anio, decimal precio)
        {
            return (String.IsNullOrEmpty(marca) || String.IsNullOrEmpty(modelo) || String.IsNullOrEmpty(anio) || String.IsNullOrEmpty(precio.ToString()));
        }

        private bool PatenteExistente(string patente)
        {
            return _autoList.Find(a => a.Patente == patente) is Auto;
        }

        private void btnAsignarDuenio_Click(object sender, EventArgs e)
        {
            if (_personaSeleccionada != null && _autoSeleccionado != null)
            {
                foreach (Auto a in _autoList)
                {
                    if (a.Patente == _autoSeleccionado.Patente && a.Duenio() == null)
                    {
                        a.SetearDuenio = _personaSeleccionada;
                        _personaSeleccionada.AgregarAuto(a);
                        AutoPersonaVista apv = new AutoPersonaVista()
                        {
                            Marca = a.Marca,
                            Anio = a.Anio,
                            Modelo = a.Modelo,
                            Patente = a.Patente,
                            DNI = a.Duenio().DNI,
                            Duenio = a.Duenio().Apellido + ", " + a.Duenio().Nombre 
                        };
                        _autoPersonaList.Add(apv);
                    }
                }
                ActualizarDgvAutosDePersona();
                ActualizarDgvAutosConDuenio();
            }
        }

        private void ActualizarDgvAutosConDuenio()
        {
            dgvDueniosAutos.DataSource = null;
            dgvDueniosAutos.DataSource = _autoPersonaList;

            labelTotal4.Text = "Totales: ";
            labelTotal4.Text += _autoPersonaList.Count();
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
                _personaList.Remove(_personaSeleccionada);
                foreach (Auto a in _autoList)
                {
                    if (a.Duenio() == _personaSeleccionada)
                        a.SetearDuenio = null;
                }

                List<AutoPersonaVista> itemsABorrar = _autoPersonaList.FindAll(apv => apv.DNI == _personaSeleccionada.DNI);
                foreach (AutoPersonaVista apv in itemsABorrar)
                {
                    if (apv is AutoPersonaVista)
                        _autoPersonaList.Remove(apv);
                }

                _personaSeleccionada = null;

                ActualizarDgvPersonas();
                ActualizarDgvAutos();
                ActualizarDgvAutosDePersona();
                ActualizarDgvAutosConDuenio();
            }
        }
    }
}
