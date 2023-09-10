using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class Login : Form
    {
        private BLLUsuario _bllUsuario;

        public Login()
        {
            InitializeComponent();
            _bllUsuario = new BLLUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = ObtenerCampos();

                if (usuario is null) return;

                if (_bllUsuario.Buscar(usuario) <= 0)
                {
                    MessageBox.Show("F no te conozco");
                    return;
                }

                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private BEUsuario ObtenerCampos()
        {
            try
            {
                if (String.IsNullOrEmpty(inputUsuario.Text) || String.IsNullOrEmpty(inputContra.Text))
                    throw new Exception("Campos incorrectos.Vuelva a ingresarlos por favor.");

                return new BEUsuario()
                {
                    Usuario = inputUsuario.Text,
                    Contra  = inputContra.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
    }
}
