/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 15/04/2019
 * Time: 13:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Decorator
{
	public class PaqueteTuristico : IPaqueteTuristico
	{
		int diaLlegada, diaPartida, lugar;
		
		public PaqueteTuristico(int dl, int dp, int l)
		{
			diaLlegada = dl;
			diaPartida = dp;
			lugar = l;
		}
		
		public double precio(){
			return (diaPartida - diaLlegada + 1) * lugar;
		}
		
		public bool consultarDisponibilidad(){
			return true;
		}
		
		public void reservar(){
			Console.WriteLine("Haciendo efectiva la reserva");
		}
	}
	
	public class Program {
				
		public static void Main(string[] args)	{
			IPaqueteTuristico pt = crearPaqueteTuristicoConAlquilerDeAutoYPasajeDeAvion();
			
			Console.WriteLine("El paquete vale " + pt.precio());
			Console.WriteLine("Consultando disponibilidad ... ");
			if(pt.consultarDisponibilidad())
				pt.reservar();
			else
				Console.WriteLine("El paquete no está disponible");
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
		
		private static IPaqueteTuristico crearPaqueteTuristico(){
			return new PaqueteTuristico(2, 6, 80);
		}
		
		private static IPaqueteTuristico crearPaqueteTuristicoConAlquilerDeAuto(){
			IPaqueteTuristico pt = crearPaqueteTuristico();
			return new AlquilerDeAuto(60, pt);
		}
		
		private static IPaqueteTuristico crearPaqueteTuristicoConAlquilerDeAutoYPasajeDeAvion(){
			IPaqueteTuristico pt = crearPaqueteTuristicoConAlquilerDeAuto();
			return new PasajeDeAvion(3000, pt);
		}
	}
}
