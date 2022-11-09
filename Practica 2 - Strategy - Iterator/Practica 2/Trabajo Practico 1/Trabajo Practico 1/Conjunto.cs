using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Conjunto : Coleccionable
    {
       public List<Comparable> elementos;
        public Conjunto() { elementos = new List<Comparable>(); }
        public List<Comparable> elementosGet() { return elementos; }

        public bool pertenece(Comparable elemento) 
        {
            foreach(Comparable c in elementos)
            {
                if (c.SosIgual(elemento)) { return true; }
            }
            return false;
        }
        public void agregar(Comparable elemento) 
        {
            if (!pertenece(elemento)) { elementos.Add(elemento); }
        }

        public int Cuantos()
        {
            return elementos.Count;
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

        public void Agregar(Comparable comparable)
        {
            this.agregar(comparable);
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
            return new IteradorConjunto(this);
        }
    }
}
