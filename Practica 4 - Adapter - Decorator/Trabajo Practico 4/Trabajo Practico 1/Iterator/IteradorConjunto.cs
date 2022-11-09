using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class IteradorConjunto : Iterador
    {
        List<Comparable> elementos = new List<Comparable>();
        int posicionActual = 0;

        public IteradorConjunto(Conjunto conjunto) 
        {
            elementos = conjunto.elementos;
        }
        public object Actual()
        {
            return elementos[posicionActual];
        }

        public bool Fin()
        {
            return posicionActual >= elementos.Count();
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
