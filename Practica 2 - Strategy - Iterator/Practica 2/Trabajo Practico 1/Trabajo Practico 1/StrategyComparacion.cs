using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public interface StrategyComparacion
    {
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMenor(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
    }
}
