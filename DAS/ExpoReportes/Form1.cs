/* =============================================================================
 * Universidad: Universidad Abierta Interamericana (UAI)
 * Materia: DESARROLLO Y ARQUITECTURA DE SOFTWARE
 * Tema: FastReport
 * Año: 2024
 * 
 * Descripción: El objetivo es demostrar el uso de FastReport para la creación,
 * manipulación y exportación de reportes en aplicaciones .NET, específicamente
 * en el contexto de un proyecto de Windows Forms.
 * =============================================================================
 */

using FastReport;
using System;
using System.Windows.Forms;

namespace ExpoReportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrevisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea una instancia de Report
                // Se utiliza using para luego liberar los recursos utilizados
                using (Report report = new Report())
                {
                    // Carga el diseño desde un archivo .frx
                    report.Load(@"Prueba.frx");

                    // Busca un objeto de texto en el reporte por su nombre 'Text1'
                    TextObject textObject = report.FindObject("Text1") as TextObject;

                    // Si el objeto de texto existe y el textBox1 tiene algun texto,
                    // actualiza el objeto de texto en el reporte con el contenido de textBox1
                    if (textObject != null && textBox1.Text != String.Empty)
                    {
                        // Permite que el objeto de texto crezca si el texto es demasiado largo
                        textObject.CanGrow = true;
                        // Establece el texto del objeto
                        textObject.Text = textBox1.Text;
                    }

                    // Muestra el reporte en el visor de FastReport
                    report.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si textBox1 esta vacio y muestra un mensaje de error si es asi
                if (textBox1.Text == String.Empty)
                {
                    MessageBox.Show($"Debe escribir algo para guardar en el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pregunta al usuario si desea guardar los cambios
                DialogResult respuesta = MessageBox.Show($"Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                    return;

                using (Report report = new Report())
                {
                    report.Load(@"Prueba.frx");

                    TextObject textObject = report.FindObject("Text1") as TextObject;
                    
                    if (textObject != null && textBox1.Text != "")
                    {
                        textObject.CanGrow = true;
                        textObject.Text = textBox1.Text;

                        // Guardar el reporte con los cambios realizados.
                        report.Save(@"Prueba.frx");
                        // Limpia el campo de texto
                        textBox1.Text = "";

                        MessageBox.Show("Reporte guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (Report report = new Report())
                {
                    report.Load(@"Prueba.frx");

                    // Prepara el reporte para la exportacion
                    report.Prepare();

                    // Crea una instancia de la clase de exportacion a PDF de FastReport
                    FastReport.Export.Pdf.PDFExport export = new FastReport.Export.Pdf.PDFExport();

                    // Muestra el dialogo de configuracion de exportacion y, si el usuario confirma, exporta el reporte
                    if (export.ShowDialog())
                    {
                        string archivo = "Prueba.pdf";
                        report.Export(export, archivo);
                        MessageBox.Show($"El reporte {archivo} fue exportado correctamente", "Exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
