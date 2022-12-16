using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public interface Iterador
    {
        void Primero();
        void Siguiente();
        bool Fin();
        object Actual();
    }
}
