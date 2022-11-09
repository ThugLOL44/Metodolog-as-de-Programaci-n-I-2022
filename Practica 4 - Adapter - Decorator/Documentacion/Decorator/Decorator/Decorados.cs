/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 15/04/2019
 * Time: 13:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Decorator
{
	
	public interface IPaqueteTuristico
	{
		double precio();
		bool consultarDisponibilidad();
		void reservar();
	}
	
	public abstract class AdicionalDecorator : IPaqueteTuristico{
		private IPaqueteTuristico adicional;
		
		public AdicionalDecorator(IPaqueteTuristico a){
			adicional = a;
		}
		
		virtual public double precio(){
			if(adicional != null)
				return adicional.precio();
			else
				return 0;
		}
		
		virtual public bool consultarDisponibilidad(){
			if(adicional != null)
				return adicional.consultarDisponibilidad();
			else
				return true;
		}
		
		virtual public void reservar(){
			if(adicional != null)
				adicional.reservar();
		}
	}
	
	public class AlquilerDeAuto : AdicionalDecorator {
		private int auto;
		
		public AlquilerDeAuto(int a, IPaqueteTuristico pt) : base(pt){
			auto = a;
		}
		
		override public double precio(){
			return auto + base.precio();
		}
		
		override public bool consultarDisponibilidad(){
			Console.Write("Consultando disponibilidad de auto (S/N): ");
			ConsoleKeyInfo k = Console.ReadKey();
			Console.WriteLine();
			if(k.KeyChar == 'S')
				return base.consultarDisponibilidad();
			else
				return false;
		}
		
		override public void reservar(){
			Console.WriteLine("Haciendo efectiva la reserva del auto");
			base.reservar();
		}
	}
	
	public class PasajeDeAvion : AdicionalDecorator {
		private int avion;
		
		public PasajeDeAvion(int a, IPaqueteTuristico pt) : base(pt){
			avion = a;
		}
		
		override public double precio(){
			return avion + base.precio();
		}
		
		override public bool consultarDisponibilidad(){
			Console.Write("Consultando disponibilidad de vuelo (S/N): ");
			ConsoleKeyInfo k = Console.ReadKey();
			Console.WriteLine();
			if(k.KeyChar == 'S')
				return base.consultarDisponibilidad();
			else
				return false;
		}
		
		override public void reservar(){
			base.reservar();
			Console.WriteLine("Haciendo efectiva la reserva del vuelo");			
		}
	}
}
