using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabajo_Practico_1
{
    public abstract class FabricaDeVendedores : FabricaDeComparables
    {

       
        public static Vendedor crearVendedor(int opcionNum)
        {
            FabricaDeVendedores fabrica = new FabricaVendedorRandom();
            Vendedor Vendedor = null;
            switch (opcionNum)
            {
                case 1:
                    Vendedor = ((Vendedor)fabrica.crearAleatorio());
                    break;
                case 2:
                    Vendedor = ((Vendedor)fabrica.crearPorTeclado());
                    break;

                default:
                    Console.WriteLine("Seleccione la opcion 1 o 2");
                    break;
            }
            return Vendedor;
        }
        public Comparable crearAleatorio()
        {
            FabricaDeVendedores fabrica = new FabricaVendedorRandom();
            
            return fabrica.CrearVendedor();
        }

        public Comparable crearPorTeclado()
        {
            FabricaDeVendedores fabrica = new FabricaVendedorPorTeclado();
            return fabrica.CrearVendedor();
        }

        public abstract Vendedor CrearVendedor();
    }
    public class FabricaVendedorRandom : FabricaDeVendedores
    {
        
        public override Vendedor CrearVendedor()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            //Console.WriteLine("Ingrese maximos: ");
            //int max = int.Parse(Console.ReadLine());
            //return new Vendedor(generador.stringAleatorio(5), new Numero(generador.numeroAleatorio(max)), new Numero(generador.numeroAleatorio(max)));
            return new Vendedor(generador.stringAleatorio(8), new Numero(generador.numeroAleatorio(100)), new Numero(generador.numeroAleatorio(1000)));
        }
    }
    public class FabricaVendedorPorTeclado : FabricaDeVendedores
    {
        public override Vendedor CrearVendedor()
        {
            LectorDeDatos lector = new LectorDeDatos();
            return new Vendedor(lector.stringPorTeclado(), new Numero(lector.numeroPorTeclado()),new Numero(lector.numeroPorTeclado()));
        }
    }
}
