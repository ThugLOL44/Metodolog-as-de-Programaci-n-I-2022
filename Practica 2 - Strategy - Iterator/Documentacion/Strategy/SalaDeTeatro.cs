/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 28/03/2019
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SalaDeTeatro
{
	
	public class Asiento{
		private bool vendido = false;
		
		public void vender(){
			vendido = true;
		}
		
		public bool estasVendido(){
			return vendido;
		}
	}
	
	public class SalaDeTeatro{
		private Asiento[,] asientos;
		private PoliticaDeVenta politica = new PorFila();
		
		public SalaDeTeatro(int filas, int columnas){
			asientos = new Asiento[filas, columnas];
			for(int f = 0; f < filas; f++)
				for(int c = 0; c < columnas; c++)
					asientos[f, c] = new Asiento();
		}
		
		public bool vender(int fila, int columna){
			if(asientos[fila, columna].estasVendido())
				return false;
			else{
				asientos[fila, columna].vender();
				return true;
			}
		}
		
		public string vender(int cantidad){
			return politica.vender(cantidad, asientos);
		}
	}
	
	public class Program
	{
		public static void Main(string[] args)
		{
			SalaDeTeatro st = new SalaDeTeatro(5, 5);
			
			int[,] simuladorDeVentas = new int[,]{ {2,2}, {4,4}, {1,2}, {4,4} };
			
			for(int i = 0; i < simuladorDeVentas.GetLength(0); i++){
				if(st.vender(simuladorDeVentas[i,0], simuladorDeVentas[i,1]))
					Console.WriteLine("El asiento de la fila " + simuladorDeVentas[i,0] + " columna " + simuladorDeVentas[i,1] + " fue vendido exitosamente.");
				else
					Console.WriteLine("El asiento de la fila " + simuladorDeVentas[i,0] + " columna " + simuladorDeVentas[i,1] + " ya se encuentra vendido.");
			}
			
			Console.WriteLine(st.vender(4));
			Console.WriteLine(st.vender(4));
			Console.WriteLine(st.vender(4));
			Console.WriteLine(st.vender(4));
			Console.WriteLine(st.vender(4));
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
	}
}