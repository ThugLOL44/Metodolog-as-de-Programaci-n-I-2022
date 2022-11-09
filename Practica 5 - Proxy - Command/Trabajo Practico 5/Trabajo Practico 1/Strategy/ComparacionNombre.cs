using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class ComparacionNombre : StrategyComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).GetNombre().Length.Equals(((Alumno)c2).GetNombre());
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).GetNombre().Length < (((Alumno)c2).GetNombre().Length);
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).GetNombre().Length > (((Alumno)c2).GetNombre().Length);
        }
    }
}
