using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    abstract public class Juego
    {
        protected List<Jugador> jugadores = new List<Jugador>();
        protected List<Carta> mazo = GeneradorDeMazo();
      
        
        public void jugar() 
        {
            this.Mezclar();
            this.Repartir();
            for (int i = 0; i < 3; i++)
            {
                this.JugarMano();
                this.QuienGana();

            }
            ganadorFinal();
            
        }

        abstract protected void Mezclar();
        abstract protected void Repartir();
        abstract protected void JugarMano();
        abstract protected void QuienGana();
        abstract protected void ganadorFinal();
        public static List<Carta> GeneradorDeMazo() 
        {
            List<Carta> mazo = new List<Carta>();
            List<string> palos = new List<string>() { "Basto", "Copa", "Espada", "Oro" };
            foreach (string palo in palos)
            {
                for (int i = 1; i < 13; i++)
                {
                    mazo.Add(new Carta(palo, i));
                }
            }
            return mazo;
        }

    }
    public class Truco : Juego
    {
        private List<Carta> manoActual = new List<Carta>();
        int contj1 = 0;
        int contj2 = 0;
        public Truco() 
        {
            this.jugadores.Add(new Jugador("Jugador 1", 3));
            this.jugadores.Add(new Jugador("Jugador 2", 3));
        }
        protected override void JugarMano()
        {
            if (contj2 != 2 && contj1 != 2)
            {
                List<Carta> mano = _jugarmano();
                manoActual = mano;
                int i = 0;
                foreach (Jugador jugador in jugadores)
                {
                    Console.Write(jugador.getNombre() + ": " + mano[i].getNumero() + " de " + mano[i].getPalo() + "\n");
                    i++;
                }
            }
        }
        public List<Carta> _jugarmano() 
        {
            List<Carta> mano = new List<Carta>();
    
            foreach (Jugador jugador in jugadores)
            {

                List<Carta> CartasJugador = jugador.getCartaList();
                Carta cartajugada = CartasJugador[new Random().Next(CartasJugador.Count)];
                CartasJugador.Remove(cartajugada);

                mano.Add(cartajugada);
            }

            return mano;
        }
        protected override void Mezclar()
        {
            Console.WriteLine("Removiendo 8 y 9 del mazo");
            List<Carta> mazotruco = new List<Carta>();
            foreach(Carta carta in mazo)
            {
                if(carta.getNumero() != 9 && carta.getNumero() != 8) 
                {
                    mazotruco.Add(carta);
                }
            }
            Console.ReadKey();
            Console.Clear();
            mazo = mazotruco;
            Console.WriteLine("...Mezclando mazo...");
            for (int i = mazo.Count - 1; i > 0; i--)
            {
                int k = new Random().Next(i + 1);
                Carta value = mazo[k];
                mazo[k] = mazo[i];
                mazo[i] = value;

            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("...Mazo mezclado...");
        }

        protected override void QuienGana()
        {
            if (contj2 != 2 && contj1 != 2)
            {
                Jugador ganador = ganadorRonda();
                Console.WriteLine("El ganador de esta ronda es: " + ganador.getNombre());
            }
        }
        protected override void ganadorFinal()
        {
            if (contj1 == 2) { Console.WriteLine("El ganador final es: " + jugadores[0].getNombre()); }
            else { Console.WriteLine("El ganador final es: " + jugadores[1].getNombre()); }
        }
        public Jugador ganadorRonda() 
        {
            int Jugador1pos = 0;
            int Jugador2pos = 0;
            List<Carta> JerarquiaTruco = new List<Carta>() { new Carta("Espada",1),new Carta("Basto",1),new Carta("Espada",7),new Carta("Oro",7),new Carta("Espada",3), new Carta("Oro",3), new Carta("Basto",3), new Carta("Copa",3), new Carta("Espada", 2), new Carta("Oro", 2), new Carta("Basto", 2), new Carta("Copa", 2), new Carta("Oro", 1), new Carta("Copa", 1), new Carta("Espada", 12), new Carta("Oro", 12), new Carta("Basto", 12), new Carta("Copa", 12), new Carta("Espada", 11), new Carta("Oro", 11), new Carta("Basto", 11), new Carta("Copa", 11), new Carta("Espada", 10), new Carta("Oro", 10), new Carta("Basto", 10), new Carta("Copa", 10), new Carta("Basto", 7), new Carta("Copa", 7), new Carta("Espada", 6), new Carta("Oro", 6), new Carta("Basto", 6), new Carta("Copa", 6), new Carta("Espada", 5), new Carta("Oro", 5), new Carta("Basto", 5), new Carta("Copa", 5), new Carta("Espada", 4), new Carta("Oro", 4), new Carta("Basto", 4), new Carta("Copa", 4)};
             for(int i = 0; i < JerarquiaTruco.Count;i++)
             {
                if (manoActual[0].getNumero() == JerarquiaTruco[i].getNumero() && manoActual[0].getPalo() == JerarquiaTruco[i].getPalo()) 
                {
                    break;
                }
                Jugador1pos++;
             }
            for (int i = 0; i < JerarquiaTruco.Count; i++)
            {
                if (manoActual[1].getNumero() == JerarquiaTruco[i].getNumero() && manoActual[1].getPalo() == JerarquiaTruco[i].getPalo())
                {
                    break;
                }
                Jugador2pos++;
            }

            if (Jugador1pos > Jugador2pos) { contj2++; return jugadores[1]; }
            contj1++;
            return jugadores[0];

        }

        protected override void Repartir()
        {
            Console.WriteLine("...Repartiendo Cartas...");
           
            foreach(Jugador jugador in jugadores) 
            {
                for(int i = 0; i < jugador.getCantCartas(); i++) 
                {
                    jugador.getCartaList().Add(mazo[0]);
                    mazo.RemoveAt(0);
                }
                Console.WriteLine("Cartas de {0}:", jugador.getNombre());
                foreach(Carta carta in jugador.getCartaList()) 
                {
                    Console.WriteLine(carta.getNumero() + " de " + carta.getPalo());
                }
            }
            
        } 
    }
}


