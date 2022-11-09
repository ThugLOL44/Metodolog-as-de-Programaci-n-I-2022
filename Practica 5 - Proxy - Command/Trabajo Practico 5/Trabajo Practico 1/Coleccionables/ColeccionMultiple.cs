using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class ColeccionMultiple : Coleccionable
    {
        Pila pila;
        Cola cola;
        Command CommandAulaLlena;
        Command CommandAulaInicio;
        CommandComparable CommandComparableLlegaAlumno;

        public ColeccionMultiple(Pila p, Cola c) 
        {
            this.pila = p;  
            this.cola = c;
        }

        public void Agregar(Comparable comparable)
        {
            return;
        }

        public bool Contiene(Comparable comparable)
        {
            if (this.pila.Contiene(comparable)) { return true; }
            else if (this.cola.Contiene(comparable)) { return true; }
            else { return false; }
        }

        public Iterador CrearIterador()
        {
            return null;
        }

        public int Cuantos()
        {
            bool x = false;
            for(int i = 0; i < 2; i++) 
            {
                if (x == false)
                {
                    x = true;
                    Console.WriteLine(this.pila.Cuantos());
                }
                else
                    return this.cola.Cuantos();
            }
            return 0;

        }


        //public Comparable Maximo()
        //{
        //    if (((Numero)this.pila.Maximo()).GetValor() > ((Numero)this.cola.Maximo()).GetValor())
        //        return this.pila.Maximo();
        //    else
        //        return this.cola.Maximo();
        //}

        public Comparable Maximo()
        {
            if (((Persona)this.pila.Maximo()).GetDni().GetValor() > ((Persona)this.cola.Maximo()).GetDni().GetValor())
                return this.pila.Maximo();
            else
                return this.cola.Maximo();
        }

        //public Comparable Minimo()
        //{
        //    if (((Numero)this.pila.Minimo()).GetValor() < ((Numero)this.cola.Minimo()).GetValor())
        //        return this.pila.Minimo();
        //    else
        //        return this.cola.Minimo();
        //}

        public Comparable Minimo()
        {
            if (((Persona)this.pila.Minimo()).GetDni().GetValor() < ((Persona)this.cola.Minimo()).GetDni().GetValor())
                return this.pila.Minimo();
            else
                return this.cola.Minimo();
        }

        public void setOrdenAulaLlena(Command CommandAulaLlena)
        {
            this.CommandAulaLlena = CommandAulaLlena;
        }

        public void setOrdenInicial(Command CommandAulaInicio)
        {
            this.CommandAulaInicio = CommandAulaInicio;
        }

        public void setOrdenLlegaAlumno(CommandComparable CommandComparableLlegaAlumno)
        {
            this.CommandComparableLlegaAlumno = CommandComparableLlegaAlumno;
        }
    }
}
