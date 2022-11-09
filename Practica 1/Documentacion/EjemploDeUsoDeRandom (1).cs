using System;

namespace EjemploDeUsoDeRandom
{
	public class Ejemplo
	{
		private Random randomUnicoDeInstancia = new Random();
		
		public Ejemplo(Random r = null){
			if(r != null)
				randomUnicoDeInstancia = r;
		}
		
		public void testRandomUnico()
		{
			for(int x = 1; x <= 10; x++)
				Console.Write(randomUnicoDeInstancia.Next(100) + " - ");
			Console.WriteLine("\n");
		}
		
		public void testRandomSerieRepetida()
		{
			Random randomSerieRepetida = new Random();
			for(int x = 1; x <= 10; x++)
				Console.Write(randomSerieRepetida.Next(100) + " - ");
			Console.WriteLine("\n");
		}
		
		public void testRandomIguales()
		{
			for(int x = 1; x <= 10; x++){
				Random randomIguales = new Random();
				Console.Write(randomIguales.Next(100) + " - ");
			}
			Console.WriteLine("\n");
		}
	}
	public class Program
	{
		private static Random unicoRandomGlobal = new Random();
		
		public static void Main(string[] args)
		{
			Ejemplo ejemplo = new Ejemplo();
			
			Console.WriteLine("******************************************************************************\n" +
			                  "* Este uso de Random genera siempre el mismo valor ya que se está            *\n" +
			                  "* instanciando un Random por cada número que se agrega a la lista.           *\n" +
			                  "* Como el random depende del clock de la computadora, todos los random       *\n" +
			                  "* generan el mismo valor.                                                    *\n" + 
			                  "* (En ocasiones puede observarse que cambia una única vez)                   *\n");
			for(int i = 1; i <= 5; i++){
				Console.Write("\tIntento " + i.ToString() + ": ");
				ejemplo.testRandomIguales();
			}
			Console.WriteLine("\n******************************************************************************\n\n");
			
			Console.WriteLine("******************************************************************************\n" +
			                  "* Este uso de Random genera valores distintos cada vez que se invoca a la    *\n" +
			                  "* función, pero como se está instanciando un Random en cada llamada,         *\n" +
			                  "* las series contienen siempre el mismo valor.                               *\n" + 
			                  "* (En ocasiones puede observarse que toda la serie cambia una única vez)     *\n");
			for(int i = 1; i <= 5; i++){
				Console.Write("\tIntento " + i.ToString() + ": ");
				ejemplo.testRandomSerieRepetida();
			}
			Console.WriteLine("\n******************************************************************************\n");
			
			Console.WriteLine("******************************************************************************\n" +
			                  "* Este uso de Random genera siempre valores distintos, sin importar cuantas  *\n" +
			                  "* veces se llame a la función.                                               *\n");
			for(int i = 1; i <= 5; i++){
				Console.Write("\tIntento " + i.ToString() + ": ");
				ejemplo.testRandomUnico();
			}
			Console.WriteLine("\n******************************************************************************\n");
			
			Console.WriteLine("******************************************************************************\n" +
			                  "* El caso de uso anterior podría generar las mismas series si se usan        *\n" +
			                  "* distintas instancias, ya que se crean instancias distintas de Random.      *\n" +
			                  "* (En ocasiones puede observarse que toda la serie cambia una única vez)     *\n");
			for(int i = 1; i <= 5; i++){
				Console.Write("\tIntento " + i.ToString() + ": ");
				(new Ejemplo()).testRandomUnico();
			}
			Console.WriteLine("\n******************************************************************************\n");
			
			Console.WriteLine("******************************************************************************\n" +
			                  "* La forma más segura de generar valores random únicos es crear una única    *\n" +
			                  "* instancia en la clase Program. Eventualmente se puede pasar esa instancia  *\n" +
			                  "* como parámetro a la clase que necesite elegir valores únicos.              *\n");
			for(int i = 1; i <= 5; i++){
				Console.Write("\tIntento " + i.ToString() + ": ");
				(new Ejemplo(unicoRandomGlobal)).testRandomUnico();
			}
			Console.WriteLine("\n******************************************************************************\n");
			
			Console.ReadKey();
		}
	}
}
