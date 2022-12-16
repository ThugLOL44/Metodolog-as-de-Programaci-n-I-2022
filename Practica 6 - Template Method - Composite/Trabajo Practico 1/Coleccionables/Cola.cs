using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Cola : Coleccionable
    {
        public List<Comparable> elementos = new List<Comparable>();
        Command CommandAulaLlena = null;
        Command CommandAulaInicio = null;
        CommandComparable CommandComparableLlegaAlumno = null;

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
            if(elementos.Count == 0) 
            {
                if(CommandAulaInicio != null) 
                { 
                    CommandAulaInicio.Execute();
                }
            }
            elementos.Add(comparable);
            if(CommandComparableLlegaAlumno != null) 
            {
               CommandComparableLlegaAlumno.Execute((IAlumno)comparable);
            }
            
            if(elementos.Count == 40)
            {
                if(CommandAulaLlena != null)
                {
                    CommandAulaLlena.Execute();
                }
            }
        }

        public bool contiene(Comparable comparable)
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                if (comparable.SosIgual(elementos[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public Iterador crearIterador(Cola cola)
        {

            return new IteradorCola(this);
        }

        public bool Contiene(Comparable comparable)
        {
            for (int i = 0; i < elementos.Count; i++) 
            {
                if (comparable.SosIgual(elementos[i])) 
                {
                    return true;
                }
            }
            return false;
        }

        public Iterador CrearIterador()
        {
            return new IteradorCola(this);
        }

        public void setOrdenInicial(Command CommandAulaInicio)
        {
            this.CommandAulaInicio = CommandAulaInicio;
        }

        public void setOrdenLlegaAlumno(CommandComparable CommandComparableLlegaAlumno)
        {
            this.CommandComparableLlegaAlumno = CommandComparableLlegaAlumno;
        }

        public void setOrdenAulaLlena(Command CommandAulaLlena)
        {
            this.CommandAulaLlena = CommandAulaLlena;
        }
    }
}
