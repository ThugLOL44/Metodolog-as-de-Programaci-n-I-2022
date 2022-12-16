using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class Jugador
    {
        string nombre;
        int cantCartas;
        List<Carta> cartaList;
        public Jugador(string nombre, int cantCartas)
        {
            this.nombre = nombre;
            this.cantCartas = cantCartas;
            cartaList = new List<Carta>();
        }
        public int getCantCartas() { return cantCartas; }
        public List<Carta> getCartaList() { return cartaList; }
       public string getNombre() { return nombre; } 
    }
}
