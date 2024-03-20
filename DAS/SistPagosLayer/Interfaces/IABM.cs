using System.Collections.Generic;

namespace Interfaces
{
    public interface IABM<T>
    {
        void Alta(T beObject);  
        void Baja(T beObject);
        void Modificar(T beObject);
        List<T> ListarTodo();
    }
}
