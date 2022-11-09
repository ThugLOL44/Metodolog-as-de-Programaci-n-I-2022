using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public abstract class FabricaDeNumeros : FabricaDeComparables
    {

        public static Numero CrearNumeroDefault()
        {
            return crearNumero(1);
        }

         public static Numero crearNumero(int opcion)
          {
            FabricaDeNumeros fabricaR = new FabricaNumeroRandom();
            FabricaDeNumeros fabricaT = new FabricaNumeroPorTeclado();
            Numero producto = null;
            switch(opcion)
            {
                case 1:
                    producto = ((Numero)fabricaR.crearAleatorio());
                    break;
                case 2:
                    producto = ((Numero)fabricaT.crearPorTeclado());
                    break;
                default:
                    producto = null;
                    break;
            }
            return producto;
            
          }
        
        public Comparable crearAleatorio()
        {

            FabricaDeNumeros factory = new FabricaNumeroRandom();
            return factory.crearNumero();
        }

        
   

        public Comparable crearPorTeclado()
        {
            FabricaDeNumeros factory = new FabricaNumeroPorTeclado();
            return factory.crearNumero();
        }

        public abstract Numero crearNumero();
    }
    
    public class FabricaNumeroRandom : FabricaDeNumeros 
    {
        public override Numero crearNumero() 
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            Console.WriteLine("Ingrese el numero maximo: ");
            int max = int.Parse(Console.ReadLine());
            Numero x = new Numero(generador.numeroAleatorio(max));
            return x;
        }
    }

    public class FabricaNumeroPorTeclado : FabricaDeNumeros 
    {
        public override Numero crearNumero()
        {
            LectorDeDatos lector = new LectorDeDatos();
            return new Numero(lector.numeroPorTeclado());
        }
    }
}
