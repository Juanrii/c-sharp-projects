using BE;
using BLL;
using BLL.Persona;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPersonas : Form
    {
        private BLLInternacional _bllInternacional;
        private BLLNacional _bllNacional;

        public FormPersonas()
        {
            InitializeComponent();
        }

        private void FormPersonas_Load(object sender, EventArgs e)
        {
            btnNacional.Checked = true;

            _bllInternacional = new BLLInternacional();
            _bllNacional = new BLLNacional();

            ListarPersonas();
        }

        private void ListarPersonas()
        {
            try
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
                            row.Cells["Extranjero"].Value = false;
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
                return;
            }

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!uC_FechaNac1.ValidarFecha(uC_FechaNac1.FechaNac.ToString("dd/MM/yyyy")))
                {
                    MessageBox.Show("Formato de fecha inválido. Por favor, use el formato DD/MM/AAAA con años que comiencen con 19 o 20.");
                    return;
                }

                string documento = Interaction.InputBox("Ingrese el documento: ", "Documento").ToUpper();

                if (!ValidarDocumento(documento))
                {
                    MessageBox.Show("Documento invalido. Debe ser alfanumérico de 8 caracteres.", "Documento Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_bllInternacional.DocumentoExistente(documento))
                {
                    MessageBox.Show($"El documento: {documento} ya existe. Ingrese otro.", "Documento existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (btnNacional.Checked)
                {
                    BENacional nacional = new BENacional()
                    {
                        Documento   = documento,
                        Nombre      = Interaction.InputBox("Ingrese el nombre: ", "Nombre"),
                        Apellido    = Interaction.InputBox("Ingrese el apellido: ", "Apellido"),
                        FechaNac    = uC_FechaNac1.FechaNac
                    };
                    _bllNacional.Alta(nacional);
                    dgvPersonas.DataSource = null;
                    dgvPersonas.DataSource = _bllNacional.ListarTodo();
                }
                else if (btnInternacional.Checked)
                {
                    BEInternacional inter = new BEInternacional()
                    {
                        Documento = documento,
                        Nombre = Interaction.InputBox("Ingrese el nombre: ", "Nombre"),
                        Apellido = Interaction.InputBox("Ingrese el apellido: ", "Apellido"),
                        FechaNac = uC_FechaNac1.FechaNac,
                        Extranjero = true
                    };
                    _bllInternacional.Alta(inter);
                    dgvPersonas.DataSource = null;
                    dgvPersonas.DataSource = _bllInternacional.ListarTodo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
                return;
            }
        }

        private bool ValidarDocumento(string documento)
        {
            return _bllInternacional.ValidarDocumento(documento);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No hay personas para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvPersonas.SelectedRows.Count == 1)
                {
                    BEPersona persona = dgvPersonas.SelectedRows[0].DataBoundItem as BEPersona;

                    DialogResult respuesta = MessageBox.Show($"Desea eliminar a la persona con DNI: {persona.Documento}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                        return;

                    // Realizar un casting seguro a BEInternacional
                    BEInternacional personaInternacional = persona as BEInternacional;

                    // Comprobar si personaInternacional no es null y si Extranjero es true
                    if (personaInternacional != null && personaInternacional.Extranjero)
                    {
                        _bllInternacional.Baja(personaInternacional);
                        dgvPersonas.DataSource = null;
                        dgvPersonas.DataSource = _bllInternacional.ListarTodo();
                    }
                    else
                    {
                        _bllNacional.Baja(persona as BENacional);
                        dgvPersonas.DataSource = null;
                        dgvPersonas.DataSource = _bllNacional.ListarTodo();
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No hay personas para modificar.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!uC_FechaNac1.ValidarFecha(uC_FechaNac1.FechaNac.ToString("dd/MM/yyyy")))
                {
                    MessageBox.Show("Formato de fecha inválido. Por favor, use el formato DD/MM/AAAA con años que comiencen con 19 o 20.");
                    return;
                }


                if (dgvPersonas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay personas para modificar.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BEPersona personaSeleccionada = (BEPersona)dgvPersonas.SelectedRows[0].DataBoundItem;

                if (btnNacional.Checked)
                {

                    BENacional persona = personaSeleccionada as BENacional;

                    persona.Documento = personaSeleccionada.Documento;
                    persona.Nombre = Interaction.InputBox("Ingrese el nombre: ", "Nombre", personaSeleccionada.Nombre.ToString());
                    persona.Apellido = Interaction.InputBox("Ingrese el apellido: ", "Apellido", personaSeleccionada.Apellido.ToString());
                    persona.FechaNac = uC_FechaNac1.FechaNac;

                    _bllNacional.Modificar(persona);
                    dgvPersonas.DataSource = null;
                    dgvPersonas.DataSource = _bllNacional.ListarTodo();
                }
                else if (btnInternacional.Checked)
                {
                    BEInternacional persona = personaSeleccionada as BEInternacional;

                    persona.Documento = personaSeleccionada.Documento;
                    persona.Nombre = Interaction.InputBox("Ingrese el nombre: ", "Nombre", personaSeleccionada.Nombre.ToString());
                    persona.Apellido = Interaction.InputBox("Ingrese el apellido: ", "Apellido", personaSeleccionada.Apellido.ToString());
                    persona.FechaNac = uC_FechaNac1.FechaNac;
                    persona.Extranjero = true;

                    _bllInternacional.Modificar(persona);
                    dgvPersonas.DataSource = null;
                    dgvPersonas.DataSource = _bllInternacional.ListarTodo();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
                return;
            }
        }

        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvPersonas.SelectedRows[0];
                    if (selectedRow.Cells["Extranjero"] != null && selectedRow.Cells["Extranjero"].Value != null)
                    {
                        bool esInter = (bool)selectedRow.Cells["Extranjero"].Value;

                        if (esInter)
                        {
                            btnInternacional.Checked = true;
                        }
                        else
                        {
                            btnNacional.Checked = true;
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

    }
}
