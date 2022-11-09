using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public interface Observador
    {
        void actualizar(Observable observable);
    }
}
