using System;
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
                    throw new Exception("El usuario ingresado no existe. Por favor vuelva a intentar.");

                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
                return;
            }
        }

        private BEUsuario ObtenerCampos()
        {
            try
            {
                if (String.IsNullOrEmpty(inputUsuario.Text.Trim()) || String.IsNullOrEmpty(inputContra.Text))
                    throw new Exception("Campos incorrectos. Vuelva a ingresarlos por favor.");

                return new BEUsuario()
                {
                    Usuario = inputUsuario.Text,
                    Contra  = inputContra.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BEUsuario nuevoUsuario = ObtenerCampos();

            if (nuevoUsuario is null) return;

            DialogResult res = MessageBox.Show($"Desea crear el usuario: {inputUsuario.Text}?", "Aviso", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    bool guardado = _bllUsuario.Agregar(nuevoUsuario);

                    inputUsuario.Text = inputContra.Text = "";

                    if (guardado)
                        MessageBox.Show("Nuevo usuario registrado.", "Exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            
        }
    }
}
