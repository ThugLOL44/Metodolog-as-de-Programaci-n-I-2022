using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public interface Comparable
    {
        bool SosIgual(Comparable comparable);
        bool SosMayor(Comparable comparable);
        bool SosMenor(Comparable comparable);
    }
}
