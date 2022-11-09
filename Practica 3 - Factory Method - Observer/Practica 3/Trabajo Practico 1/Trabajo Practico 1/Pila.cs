using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Pila : Coleccionable
    {
        public List<Comparable> elementos = new List<Comparable>();
        public void Agregar(Comparable comparable)
        {
            elementos.Add(comparable);
        }

        public bool Contiene(Comparable comparable)
        {
            foreach (Comparable c in this.elementos)
                if (c.SosIgual(comparable))
                    return true;
            return false;
        }

        public Iterador CrearIterador()
        {
            return new IteradorPila(this);
        }

        public int Cuantos() { return elementos.Count; }

        public Comparable Maximo() 
        {
            Comparable maximo = null;
            if (elementos.Count > 0)
                maximo = elementos[0];

            for (int i = 1; i < elementos.Count; i++)
            {
                if (maximo.SosMayor(elementos[i]))
                    maximo = elementos[i];
            }
            return maximo;
        }

        public Comparable Minimo()
        {
            Comparable minimo = null;
            if (elementos.Count > 0)
                minimo = elementos[0];

            for (int i = 1; i < elementos.Count; i++)
            {
                if (minimo.SosMenor(elementos[i]))
                    minimo = elementos[i];
            }
            return minimo;
        }
       


    }
}
