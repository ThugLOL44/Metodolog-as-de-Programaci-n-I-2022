using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class IteradorPila : Iterador
    {
        List<Comparable> elem_pila = new List<Comparable>();
        int posicionActual;
        public IteradorPila(Pila pila)
        {
            elem_pila = pila.elementos;
            posicionActual = elem_pila.Count -1;
        }
        public object Actual()
        {
            return elem_pila[posicionActual];
        }

        public bool Fin()
        {
            return posicionActual <= 0;
        }

        public void Primero()
        {
            posicionActual = elem_pila.Count - 1;
        }

        public void Siguiente()
        {
            posicionActual--;
        }
    }
}
