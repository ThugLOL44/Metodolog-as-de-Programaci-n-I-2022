using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Numero : Comparable
    {
        int valor;
        public Numero(int valor)        {
            this.valor = valor;
        }

        public int GetValor() { return valor; }

        public bool SosIgual(Comparable comparable)
        {
            return this.valor == ((Numero)comparable).GetValor();
        }

        public bool SosMayor(Comparable comparable)
        {
            return this.valor < ((Numero)comparable).GetValor();
        }

        public bool SosMenor(Comparable comparable)
        {
            return this.valor > ((Numero)comparable).GetValor();
        }
    }
}
