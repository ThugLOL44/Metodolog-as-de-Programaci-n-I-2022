using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class IteradorCola : Iterador
    {
        List<Comparable> elem_cola = new List<Comparable>();
        int posicionActual = 0;
        public IteradorCola(Cola cola) 
        {
            elem_cola = cola.elementos;
        }
        public object Actual()
        {
            return elem_cola[posicionActual];
        }

        public bool Fin()
        {
            return posicionActual >= elem_cola.Count();
        }

        public void Primero()
        {
            posicionActual = 0;
        }

        public void Siguiente()
        {
            posicionActual++;
        }
    }
}
