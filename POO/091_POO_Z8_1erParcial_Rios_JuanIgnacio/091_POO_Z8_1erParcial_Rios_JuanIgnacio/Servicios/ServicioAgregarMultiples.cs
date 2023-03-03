using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases;
using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Excepciones;
using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Gestores;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Servicios
{
    /*
     * Esta clase contiene datos hard-code para agilizar la asignacion de Empleados y Adelantos
     */
    public class ServicioAgregarMultiples
    {
        #region "Gestores"
        private GestorEmpleados _gestorEmpleados;
        private GestorAdelantos _gestorAdelantos;
        #endregion

        #region "Listas"
        private List<Empleado> _listaEmpleados = new List<Empleado>()
        {
            new Administrativo() { Legajo = "B00053022-T1", Apellido = "Rios",      Nombre = "Juan",        Sueldo = 190000},
            new Administrativo() { Legajo = "B00053022-T2", Apellido = "Perez",     Nombre = "Maria",       Sueldo = 215000},
            new Administrativo() { Legajo = "B00053022-T3", Apellido = "Maldonado", Nombre = "Ana",         Sueldo = 313000},
            new Directivo()      { Legajo = "B00053022-T4", Apellido = "Clavero",   Nombre = "Gian",        Sueldo = 422000},
            new Directivo()      { Legajo = "B00053022-T5", Apellido = "Pomari",    Nombre = "Jonathan",    Sueldo = 180000},
            new Directivo()      { Legajo = "B00053022-T6", Apellido = "Lamberti",  Nombre = "Ezequiel",    Sueldo = 417000},
            new Operario()       { Legajo = "B00053022-T7", Apellido = "Gimenez",   Nombre = "Marcela",     Sueldo = 322200},
            new Operario()       { Legajo = "B00053022-T8", Apellido = "Gomez",     Nombre = "Julieta",     Sueldo = 222700},
        };

        private List<Adelanto> _listaAdelantos = new List<Adelanto>()
        {
            new Adelanto() { Codigo = "1235ABCD", ImporteOtorgado = 35000  },
            new Adelanto() { Codigo = "1237ABCD", ImporteOtorgado = 60000  },
            new Adelanto() { Codigo = "1239ABCD", ImporteOtorgado = 30000  },
            new Adelanto() { Codigo = "1240ABCD", ImporteOtorgado = 80000  },
            new Adelanto() { Codigo = "1234ABCD", ImporteOtorgado = 75000  },
            new Adelanto() { Codigo = "1236ABCD", ImporteOtorgado = 130000 },
            new Adelanto() { Codigo = "1238ABCD", ImporteOtorgado = 12000  },
            new Adelanto() { Codigo = "1241WXYZ", ImporteOtorgado = 125000 },
            };
        #endregion

        #region "Constructor"
        public ServicioAgregarMultiples(GestorEmpleados gestorEmpleados, GestorAdelantos gestorAdelantos)
        {
            _gestorEmpleados = gestorEmpleados;
            _gestorAdelantos = gestorAdelantos;
        }
        #endregion

        #region "Destructor"
        ~ServicioAgregarMultiples() { }
        #endregion

        #region "Metodos"
        public void CrearMultiples()
        {
            try
            {
                // Cada gestor implementa el metodo CrearMultiplesRegistros de la interfaz InterfaceAgregarMultiples
                _gestorEmpleados.CrearMultiplesRegistros(_listaEmpleados);
                _gestorAdelantos.CrearMultiplesRegistros(_listaAdelantos);
            }
            catch (AgregarMultiplesException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion
    }
}
