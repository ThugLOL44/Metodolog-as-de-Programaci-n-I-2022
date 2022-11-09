using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public interface Observable
    {
        void agregarObservador(Observador observador);
        void eliminarObservador(Observador observador);
        void notificar();
    }
}
