/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 01/09/2019
 * Time: 9:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Command
{
	public class Paciente{
		private int numero;
		
		public void tomarPresion(){
			Console.WriteLine("Paciente: No gracias, el tensiómetro me hace doler el brazo");
		}
		public void ofrecerTazaDeCafe(){
			Console.WriteLine("Paciente: No gracias, dudo de como esté hecho");
		}
		public void desearSuerte(){
			Console.WriteLine("Paciente: ¿Por qué me desea suerte?");
		}
		public void desinfectarAsinto(){
			Console.WriteLine("Paciente: Espere a que termine de levantarme antes de tirar ese producto");
		}
		
		public void setNumero(int n){
			numero = n;
		}
		
		public int getNumero(){
			return numero;
		}
	}
	
	public class Enfermero {
		List<Paciente> pacientesEnEspera = new List<Paciente>();
		IOrden ordenPush = null, ordenPop = null;
		int numero = 1;
		
		public Enfermero(IOrden oPush, IOrden oPop){
			ordenPush = oPush;
			ordenPop = oPop;
		}
		
		public void recibirPaciente(Paciente paciente) {
			// Método push
			Console.WriteLine("Enfermero: Buenos días, siéntese y espere a que el médico lo llame. Usted tiene el número " + numero);
			paciente.setNumero(numero);
			numero++;
			pacientesEnEspera.Add(paciente);
			ordenPush.ejecutar(paciente);
		}
		public Paciente proximoAAtender() {
			// Método pop
			Paciente p = pacientesEnEspera[0];
			Console.WriteLine("Enfermero: Paciente " + p.getNumero() + ", el médico lo atenderá ahora");
			
			pacientesEnEspera.RemoveAt(0);
			ordenPop.ejecutar(p);
			return p;
		}

		public void setOrdenPush(IOrden oPush){
			ordenPush = oPush;
		}

		public void setOrdenPop(IOrden oPop) {
			ordenPop = oPop;
		}
		
		public bool hayPacientesEnEspera(){
			return pacientesEnEspera.Count > 0;
		}

	}
	
	public class Program
	{
		static IOrden ordenPush = new NoHacerNada();
		static IOrden ordenPop = new NoHacerNada();
		static Enfermero enfermero = new Enfermero(ordenPush, ordenPop);
			
		public static void Main(string[] args)	{			
			char opcion;
			mostrarMenu();
			opcion = ' ';
			while(opcion != 's'){
				mostrarMenu();	
				switch(opcion){
						case 'i': ingresarPaciente(new Paciente()); break;
						case 'a': atenderPaciente(); break;
						case 'u': cambiarOrdenPush(); break;
						case 'o': cambiarOrdenPop(); break;
				}
				opcion = Console.ReadKey().KeyChar;
			}
			
			Console.Write("\n\n\nPrograma finalizado correctamente.");
			Console.ReadKey(true);
		}
		
		static private void ingresarPaciente(Paciente p){			
			enfermero.recibirPaciente(p);
		}
		
		static private void atenderPaciente(){
			if(enfermero.hayPacientesEnEspera())
				enfermero.proximoAAtender();
			else
				Console.WriteLine("Enfermero: No hay pacientes en espera");
		}
		
		static private void cambiarOrdenPush(){
			Console.WriteLine("¿Qué orden?");
			Console.WriteLine("(n)inguna");
			Console.WriteLine("(t)omar la presión");
			Console.WriteLine("(o)frecer taza de cafe");
			Console.WriteLine("(a)mbas");
			
			bool ok = true;
			IOrden orden = null;
			while(ok){
				char opcion = Console.ReadKey().KeyChar;
				orden = FabricaDeOrdenes.crearOrden(opcion);
				ok = orden == null;
			}
			enfermero.setOrdenPush(orden);
			Console.WriteLine("Orden cambiada");
		}
		
		static private void cambiarOrdenPop(){
			Console.WriteLine("¿Qué orden?");
			Console.WriteLine("(n)inguna");
			Console.WriteLine("(p)almear la espalda");
			Console.WriteLine("(d)esinfectar asiento");
			Console.WriteLine("a(m)bas");
			
			bool ok = true;
			IOrden orden = null;
			while(ok){
				char opcion = Console.ReadKey().KeyChar;
				orden = FabricaDeOrdenes.crearOrden(opcion);
				ok = orden == null;
			}
			enfermero.setOrdenPop(orden);
			Console.WriteLine("Orden cambiada");
		}
		
		static private void mostrarMenu(){
			Console.Clear();
			Console.WriteLine("Seleccione una opción");
			Console.WriteLine("(i)ngresar un paciente al hospital");
			Console.WriteLine("(a)tender paciente");
			Console.WriteLine("cambiar orden \"p(u)sh\"");
			Console.WriteLine("cambiar orden \"p(o)p\"");
			Console.WriteLine("(s)alir");
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("");
		}
	}
}
