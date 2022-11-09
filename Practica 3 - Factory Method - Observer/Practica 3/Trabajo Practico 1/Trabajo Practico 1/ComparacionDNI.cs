using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class ComparacionDNI : StrategyComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).GetDni().GetValor() == ((Alumno)c2).GetDni().GetValor();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).GetDni().GetValor() > ((Alumno)c2).GetDni().GetValor();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).GetDni().GetValor() < ((Alumno)c2).GetDni().GetValor();
        }
    }
}
