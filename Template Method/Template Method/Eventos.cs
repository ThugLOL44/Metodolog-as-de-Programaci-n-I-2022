/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 05/06/2019
 * Time: 13:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Template_Method
{
	
	abstract public class Evento
	{
		private int invitados = 500;
		private bool huboProblemas = false; 
		
		public void hacerFiesta(){
			this.vestirAAgasajado();
			this.enviarInvitaciones();
			this.prepararSalon();
			while(this.quedenInvitados()){
				this.ponerMusica();
				this.servirComida();
				this.sacarFotos();
			}
			this.entregarRecuerdo();
			if(this.noHuboProblemas())
				this.limpiarSalon();
		}
		
		protected void limpiarSalon(){
			Console.WriteLine("Limpiando el enchastre que quedó.");
		}
		
		protected void sacarFotos(){ 
			Console.WriteLine("Sacando fotos"); 
		}
		
		protected bool quedenInvitados(){
			invitados -= 50;
			return invitados > 0;
		}
		
		protected bool noHuboProblemas(){
			return ! huboProblemas;
		}


		abstract protected void vestirAAgasajado();
		abstract protected void enviarInvitaciones();
		abstract protected void prepararSalon();
		abstract protected void ponerMusica();
		abstract protected void servirComida();
		abstract protected void entregarRecuerdo();

	}
	
	public class CumpleDe15 : Evento{
		override protected void vestirAAgasajado(){ Console.WriteLine("Buscando vestido para la quinceañera"); }
		override protected void enviarInvitaciones(){ Console.WriteLine("Enviando invitaciones con dibujitos de unicornios"); }
		override protected void prepararSalon(){ Console.WriteLine("Preparando salón para los jóvenes"); }
		override protected void ponerMusica(){ Console.WriteLine("Poniendo música moderna"); }
		override protected void servirComida(){ Console.WriteLine("Sirviendo pizzas y gaseasosas"); }
		override protected void entregarRecuerdo(){ Console.WriteLine("Entregando caramelos"); }
	}
	
	public class Casamiento : Evento{
		override protected void vestirAAgasajado(){ Console.WriteLine("Buscando vestido y traje para los novios"); }
		override protected void enviarInvitaciones(){ Console.WriteLine("Enviando invitaciones formales"); }
		override protected void prepararSalon(){ Console.WriteLine("Preparando salón para los novios"); }
		override protected void ponerMusica(){ Console.WriteLine("Poniendo música de antes"); }
		override protected void servirComida(){ Console.WriteLine("Sirviendo lomo y vino"); }
		override protected void entregarRecuerdo(){ Console.WriteLine("Entregando un bonzai"); }
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("********************");			
			Console.WriteLine("* Cumpleaños de 15 *");
			Console.WriteLine("********************");			
			Evento e1 = new CumpleDe15();
			e1.hacerFiesta();
			Console.WriteLine("------------------------------------------\n\n");			
			
			Console.WriteLine("**************");			
			Console.WriteLine("* Casamiento *");
			Console.WriteLine("**************");						
			Evento e2 = new Casamiento();
			e2.hacerFiesta();
			Console.WriteLine("------------------------------------------\n\n");			
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
	}
}
