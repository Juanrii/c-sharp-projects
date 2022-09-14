using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Ejercicio 3 - Un cine pequeño nos propone hacer una aplicación para controlar 
 * las personas que ingresa al mismo, para los grandes estrenos de películas.
 * Unos conjuntos de personas esperaran para sacar una entrada, tendremos que calcular 
 * la entrada según la edad de la persona (mínimo 5 años).
 * Las edades de las personas se generan aleatoriamente entre 5 y 60 años.
 * Al final, deberemos mostrar la cantidad total recaudada. El número de personas de la lista 
 * se elige al azar entre 0 y 50. 
 * Además, se debe permitir: 
 *      a. Llevar un registrar de las nuevas personas que ingresan a la lista 
 *      b. Poder eliminar a la persona que se va de la lista (en cualquier posición) 
 *      c. Actualizar los datos de la persona (modificar algún dato) 
 *      d. Mostrar Listado de las personas.
 *      e. Agregar después del seleccionado. */

namespace TP4_Ejer3
{
    public partial class CineForm : Form
    {
        public CineForm()
        {
            InitializeComponent();
        }
    }
}
