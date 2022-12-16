using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class Carta
    {
        string palo;
        int numero;
        public Carta(string palo, int numero)
        {
            this.palo = palo;
            this.numero = numero;
        }   
        public string getPalo() { return palo; }
        public int getNumero() { return numero; }
    }
}
