using _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio.Interfaces
{
    public interface InterfaceAgregarMultiples<T>
    {
        // Recibe como parametro una Lista de tipo generico que luego
        // sera utilizada por cada gestor para transformarla en una
        // Lista de Adelantos o una Lista de Empleados
        void CrearMultiplesRegistros(List<T> lista);
    }
}
