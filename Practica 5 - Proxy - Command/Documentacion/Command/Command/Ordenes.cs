/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 01/09/2019
 * Time: 9:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Command
{
	
	public interface IOrden
	{
		void ejecutar(Paciente p);
	}
	
	public class NoHacerNada : IOrden {
		public void ejecutar(Paciente p){
			// No hace nada
		}
	}
	
	public class TomarPresion : IOrden {
		public void ejecutar(Paciente p){
			Console.WriteLine("Enfermero: ¿Le puedo tomar la presión?");
			p.tomarPresion();
		}
	}
	
	public class TazaDeCafe : IOrden {
		public void ejecutar(Paciente p){
			Console.WriteLine("Enfermero: ¿Le puedo ofrecer una taza de cafe?");
			p.ofrecerTazaDeCafe();
		}
	}
		
	public class DesinfectarAsiento : IOrden {
		public void ejecutar(Paciente p){
			Console.WriteLine("Enfermero: Tirando lavandina en el asiento");
			p.desinfectarAsinto();
		}
	}
		
	public class PalmearEspalda : IOrden {
		public void ejecutar(Paciente p){
			Console.WriteLine("Enfermero: ¡Suerte, la va a necesitar!");
			p.desearSuerte();
		}
	}
	
	public class OrdenCompuesta : IOrden {
		private List<IOrden> ordenes = new List<IOrden>();
		
		public void ejecutar(Paciente p){
			foreach(IOrden o in ordenes)
				o.ejecutar(p);
		}
		
		public void agregarOrden(IOrden o){
			ordenes.Add(o);
		}
	}
	
	public abstract class FabricaDeOrdenes{
		static public IOrden crearOrden(char opcion){
			FabricaDeOrdenes fabrica = null;
			switch(opcion){
					case 'n': fabrica = new FabricaDeOrdenNinguna(); break;
					case 't': fabrica = new FabricaDeOrdenTomarPresion(); break;
					case 'o': fabrica = new FabricaDeOrdenTazaDeCafe(); break;
					case 'a': fabrica = new FabricaDeOrdenAmbasPush(); break;
					case 'p': fabrica = new FabricaDeOrdenPalmearEspalda(); break;
					case 'd': fabrica = new FabricaDeOrdenDesinfectarAsiento(); break;
					case 'm': fabrica = new FabricaDeOrdenAmbasPop(); break;
			}
			return fabrica.crearOrden();
		}
		
		abstract public IOrden crearOrden();
	}
	
	public class FabricaDeOrdenNinguna : FabricaDeOrdenes{
		override public IOrden crearOrden(){
			return new NoHacerNada();
		}
	}
					
	public class FabricaDeOrdenTomarPresion : FabricaDeOrdenes{
		override public IOrden crearOrden(){
			return new TomarPresion();
		}
	}
				
	public class FabricaDeOrdenTazaDeCafe : FabricaDeOrdenes{
		override public IOrden crearOrden(){
			return new TazaDeCafe();
		}
	}
				
	public class FabricaDeOrdenAmbasPush : FabricaDeOrdenes{
		override public IOrden crearOrden(){
			IOrden o1 = FabricaDeOrdenes.crearOrden('t');
			IOrden o2 = FabricaDeOrdenes.crearOrden('o');
			OrdenCompuesta o3 = new OrdenCompuesta();
			o3.agregarOrden(o1);
			o3.agregarOrden(o2);
			return o3;
		}
	}
					
	public class FabricaDeOrdenPalmearEspalda : FabricaDeOrdenes{
		override public IOrden crearOrden(){
			return new PalmearEspalda();
		}
	}
					
	public class FabricaDeOrdenDesinfectarAsiento : FabricaDeOrdenes{
		override public IOrden crearOrden(){
			return new DesinfectarAsiento();
		}
	}
					
	public class FabricaDeOrdenAmbasPop : FabricaDeOrdenes{
		override public IOrden crearOrden(){
			IOrden o1 = FabricaDeOrdenes.crearOrden('p');
			IOrden o2 = FabricaDeOrdenes.crearOrden('d');
			OrdenCompuesta o3 = new OrdenCompuesta();
			o3.agregarOrden(o1);
			o3.agregarOrden(o2);
			return o3;
		}
	}
}
