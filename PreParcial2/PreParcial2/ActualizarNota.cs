using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreParcial2
{
    public partial class ActualizarNota : Form
    {
        private Nota notaSelect;
        private GestorNotas gestorNotas;

        public ActualizarNota(Nota notaSelect, GestorNotas gestorNotas)

        {
            InitializeComponent();
            this.notaSelect = notaSelect;
            this.gestorNotas = gestorNotas;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Nota notaActualizada = new Nota(Convert.ToInt32(this.inputLegajo.Value))
            {
                Fecha = this.inputFecha.Value.ToString("yyy-MM-dd"),
                Materia = this.inputMateria.Text,
                ValorNota = Convert.ToInt32(this.inputValorNota.Text),

        };
            gestorNotas.Actualizar(notaActualizada);
            Close();
            MessageBox.Show("Nota actualizada correctamente.", "Actualizada");
        }

        private void ActualizarNota_Load(object sender, EventArgs e)
        {
            this.inputLegajo.Value = notaSelect.Legajo;
            this.inputFecha.Value = Convert.ToDateTime(notaSelect.Fecha);
            this.inputMateria.Text = notaSelect.Materia;
            this.inputValorNota.Text = notaSelect.ValorNota.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
