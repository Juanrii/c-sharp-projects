using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsControlLibrary1
{
    public partial class UC_FechaNac: UserControl
    {
        public UC_FechaNac()
        {
            InitializeComponent();
        }

        public DateTime FechaNac
        {
            get
            {
                // Agrego esta configuracion porque por defecto sino es MM/dd/YYYY
                var cultura = new System.Globalization.CultureInfo("es-ES");
                return DateTime.ParseExact(inputFechaNac.Text, "dd/MM/yyyy", cultura);
            }
            set
            {
                inputFechaNac.Text = value.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("es-ES"));
            }
        }

        public bool ValidarFecha(string fecha)
        {
            // Valida el formato DD/MM/AAAA y asegura que el año comience con 19 o 20
            string patron = @"^(0[1-9]|[12][0-9]|3[01])\/(0[1-9]|1[012])\/(19|20)\d\d$";
            Regex regex = new Regex(patron);
            return regex.IsMatch(fecha);
        }
    }
}
