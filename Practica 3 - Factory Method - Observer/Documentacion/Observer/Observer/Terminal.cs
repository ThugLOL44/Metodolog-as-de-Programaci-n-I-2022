/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 02/05/2019
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Observer
{
	public interface IObservado{
		void agregarObservador(IObservador o);
		void notificar();
	}
	
	public interface IObservador {	}
	
	public interface IObservadorDeTerminales : IObservador {
		void actualizar(Terminal t);
	}
	
	public interface IObservadorDeCajeros : IObservador {
		void actualizar(Cajero c);
	}
	
	public class Terminal : IObservado
	{
		private int proximoNumero = 0;
		
		public void solicitar(){
			proximoNumero++;
			Console.WriteLine("Binvenido cliente. Será atendido con el número " + proximoNumero);
			this.notificar();
		}
		
		public int getUltimoNumeroOtorgado(){
			return proximoNumero;
		}
		
		private List<IObservador> observadores = new List<IObservador>();
		
		public void agregarObservador(IObservador o){
			observadores.Add(o);
		
		}
		public void notificar(){
			foreach(IObservadorDeTerminales o in observadores)
				o.actualizar(this);
		}

	}
	
	public class Cajero : IObservadorDeTerminales, IObservadorDeCajeros, IObservado
	{
		private int numeroALlamar = 1, ultimoNumeroOtorgado = 0, puesto;
		
		public Cajero(int p){
			puesto = p;
		}
		
		public void llamar(){
			if(numeroALlamar <= ultimoNumeroOtorgado){
				Console.WriteLine("Puesto " + puesto + " llamando al cliente con número " + numeroALlamar);			
				numeroALlamar++;
				this.notificar();
			}
			else
				Console.WriteLine("No hay nadie esperando.");			
		}
		
		public int getUltimoNumeroOtorgado(){
			return numeroALlamar;
		}
		
		public void actualizar(Terminal t){
			ultimoNumeroOtorgado = t.getUltimoNumeroOtorgado();
		}
		
		public void actualizar(Cajero c){
			numeroALlamar = c.getUltimoNumeroOtorgado();
		}
		
		private List<IObservador> observadores = new List<IObservador>();
		
		public void agregarObservador(IObservador o){
			observadores.Add(o);
		
		}
		public void notificar(){
			foreach(IObservadorDeCajeros o in observadores)
				o.actualizar(this);
		}
	}
	
	public class Program {
				
		public static void Main(string[] args)	{
			//Inicialización
			Terminal t = new Terminal();
			Cajero[] cs = new Cajero[5];
			for(int c = 0; c < 5; c++){
				cs[c] = new Cajero(c+1);
				t.agregarObservador(cs[c]);
			}
			for(int c = 0; c < 5; c++){
				for(int d = 0; d < 5; d++){
					if(c != d)
						cs[c].agregarObservador(cs[d]);
				}
			}
			
			//Simulación
			Random r = new Random();
			for(int c = 1; c <= 100; c++){
				if(r.NextDouble() > 0.4)
					t.solicitar();
				else{
					int cj = r.Next(5);
					cs[cj].llamar();
				}
			}
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
	}
}
