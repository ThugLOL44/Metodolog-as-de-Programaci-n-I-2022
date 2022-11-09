/*
 Ejemplo del uso de interfaces
 
 Este ejemplo corresponde al video de interfaces de la aprimer clase de la materia Metodología de Programación I
 
 */
using System;

namespace EjemploInterfaces
{
	
	// Actividad 1. Implementar las interfaces Negocio, Cliente y Proveedor
	
	interface Negocio
	{
		void atenderCliente(Cliente c);
		void abstacerStock();
		String getNombre();
	}
	
	interface Cliente
	{
		void vender();
		void comprar();
		String getNombre();
	}
	
	interface Proveedor
	{
		void negociar(Negocio n);
	}
	
	// Actividad 2. Implementar una clae Ferretería que implemente la interface Negocio
	
	class Ferreteria : Negocio
	{
		private Proveedor proveedor;
		
		public Ferreteria(){
			proveedor = new Almacen();
		}
		
		public void atenderCliente(Cliente c)
		{
			Console.WriteLine("Atendiendo al cliente " + c.getNombre());
		}
		
		public void abstacerStock()
		{
			proveedor.negociar(this);
			Console.WriteLine("El stock fue abastecido");
		}
		
		public String getNombre()
		{
			return "La solución a todo";
		}
	}
	
	// Actividad 3. Implemenar una clse Alimentos que implemente la interface Negocio
	
	abstract class Alimento : Negocio
	{
		private Proveedor proveedor;
		
		public Alimento(){
			proveedor = new MercadoCentral();
		}
		
		public void abstacerStock()
		{
			proveedor.negociar(this);
			Console.WriteLine("El stock fue abastecido");
		}
		
		abstract public String getNombre();
		
		abstract public void atenderCliente(Cliente c);
	}
	
	// Actividad 4. Implemente tres subclases de Alimneto: Verduleria, Carniceria y Almacen
	
	class Verduleria : Alimento 
	{
		override public void atenderCliente(Cliente c)
		{
			Console.WriteLine("Vendiendo lechuga y tomate al cliente " + c.getNombre());
		}
			
		override public String getNombre()
		{
			return "La remolacha";	
		}
	}
	
	class Carniceria : Alimento 
	{
		override public void atenderCliente(Cliente c)
		{
			Console.WriteLine("Vendiendo carne al cliente " + c.getNombre());
		}
			
		override public String getNombre()
		{
			return "La vaca loca";	
		}
		
	}
	
	class Almacen : Alimento, Proveedor 
	{
		override public void atenderCliente(Cliente c)
		{
			Console.WriteLine("Vendiendo leche y yerba al cliente " + c.getNombre());
		}
			
		public void negociar(Negocio n){
			Console.WriteLine("Abasteciendo el stock de " + n.getNombre());
		}
		
		override public String getNombre()
		{
			return "Try'n'save";	
		}
	}
	
	class MercadoCentral : Proveedor{
		public void negociar(Negocio n){
			Console.WriteLine("Negociando con " + n.getNombre());
		}
	}
	
	// Actividad 5. Implemente la clase Resto que implemente las interfaces Negocio y Cliente
	
	class Resto : Negocio, Cliente
	{
		private Proveedor proveedor;
		private Negocio negocio;
		
		public Resto(Proveedor p, Negocio n){
			negocio = n;
			proveedor = p;
		}
		
		public void atenderCliente(Cliente c){
			Console.WriteLine("Atendiendo al cliente " + c.getNombre());
		}
		
		public void abstacerStock(){
			proveedor.negociar(this);
			Console.WriteLine("La cocina está llena para aeguir preparando comida");
		}
		
		public void vender(){
			negocio.atenderCliente(this);
			Console.WriteLine("Vendiendo dólares en mi banco");
		}
		
		public void comprar(){
			negocio.atenderCliente(this);
			Console.WriteLine("Comprando dólares en mi banco");
		}
		
		public String getNombre(){
			return "El Bar de Moe";
		}
	}
	
	// Actividad 6. Implemente la calase Banco que implemente la interface Negocio
	class Banco : Negocio 
	{
		public void atenderCliente(Cliente c)
		{
			Console.WriteLine("Haciendo operaciones bancarias con el cliente " + c.getNombre());
		}
		
		public void abstacerStock()
		{
			Console.WriteLine("No tengo proveedor, me abastesco de mis propios clientes");
		}
		
		public String getNombre(){
			return "El banco que te banca";
		}
	}	
	
	// Actividad 7 . Implemetne la interface Proveedor en la clase Almacen
	// (la implementación está más ariba) 
	
	// Clase auxiliar Persona
	
	class Persona : Cliente
	{
		Negocio negocio;
		
		public Persona(Negocio n)
		{
			negocio = n;
		}
		
		public void comprar(){
			Console.WriteLine("Comprando en un hermoso día");
			negocio.atenderCliente(this);
		}
		
		public void vender(){
			Console.WriteLine("Vendiendo en un hermoso día");
			negocio.atenderCliente(this);
		}
		
		public string getNombre()
		{
			return "Fulano De Tal";
		}
	}
	
	// Actividad 8. Realice un módulo main para testear el correcto funcionamiento de todo lo implemtado
	
	class Program{
		public static void Main(string[] args){
			//Probando Persona como Cliente y Ferretería como Negocio
			Console.WriteLine("*** Probando Persona como Cliente y Ferretería como Negocio ***");
			Persona per1 = new Persona(new Ferreteria());
			per1.comprar();
			per1.vender();
			Console.WriteLine("**********************************************************\n\n");
			
			//Probando Persona como Cliente y Carnicería como Negocio
			Console.WriteLine("*** Probando Persona como Cliente y Carnicería como Negocio ***");
			Persona per2 = new Persona(new Carniceria());
			per2.comprar();
			per2.vender();
			Console.WriteLine("**********************************************************\n\n");
			
			Resto resto = new Resto(new Almacen(), new Banco());
			
			//Probando Persona como Cliente y Resto como Negocio
			Console.WriteLine("*** Probando Persona como Cliente y Resto como Negocio ***");
			Persona per3 = new Persona(resto);
			per3.comprar();
			per3.vender();
			Console.WriteLine("**********************************************************\n\n");
			
			//Probando Resto como Cliente y Banco como Negocio
			Console.WriteLine("*** Probando Resto como Cliente y Banco como Negocio ***");
			resto.comprar();
			resto.vender();
			Console.WriteLine("**********************************************************\n\n");
			
			//Probando Resto como Negocio y Almacen como Proveedor
			Console.WriteLine("*** Probando Resto como Negocio y Almacen como Proveedor ***");
			resto.abstacerStock();
			Console.WriteLine("**********************************************************\n\n");
					
			Console.WriteLine("El programa finalizó correctamente.\n");
			Console.ReadKey();
		}			
	}
}