using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class ComparacionCalificacion : StrategyComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() == ((IAlumno)c2).getCalificacion();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() > ((IAlumno)c2).getCalificacion();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() < ((IAlumno)c2).getCalificacion();
        }
    }
}
