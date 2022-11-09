/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 12/06/2019
 * Time: 9:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proxy
{
	public interface IDocumento
	{
		string getNombre();
		void mostrarVistaPrevia();
	}
	
	public class DocumentoDeTexto : IDocumento{
		private string nombre;
		
		public DocumentoDeTexto(string s){
			nombre = s;
			
			Console.WriteLine("Creando el documento de texto " + nombre + "...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo páginas...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo secciones...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo índices...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo figuras...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo tablas...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Fin de la carga del documento.");
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public void mostrarVistaPrevia(){
			Console.WriteLine("Mostrando el documento de texto " + nombre);
		}
		
		override public string ToString(){
			return this.getNombre();
		}
	}
	
	public class PlanillaDeCalculo : IDocumento{
		private string nombre;
		
		public PlanillaDeCalculo(string s){
			nombre = s;
			
			Console.WriteLine("Creando la planilla de cálculo " + nombre + "...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo hojas...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo fórmulas...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo tablas dinámicas...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo figuras...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Fin de la carga de la planilla.");
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public void mostrarVistaPrevia(){
			Console.WriteLine("Mostrando la planilla de cálculo " + nombre);
		}
		
		override public string ToString(){
			return this.getNombre();
		}
	}
	
	public class PresentacionDeDiapositivas : IDocumento{
		private string nombre;
		
		public PresentacionDeDiapositivas(string s){
			nombre = s;
			
			Console.WriteLine("Creando la presentación " + nombre + "...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo diapositivas...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo imágenes...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo animaciones y transiciones...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo cuadros de texto...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Fin de la carga de la presentación.");
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public void mostrarVistaPrevia(){
			Console.WriteLine("Mostrando la presentación de diapositvas " + nombre);
		}
		
		override public string ToString(){
			return this.getNombre();
		}
	}
	
	public class AlbumDeMusica : IDocumento{
		private string nombre;
		
		public AlbumDeMusica(string s){
			nombre = s;
			
			Console.WriteLine("Creando al abum de música " + nombre + "...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo índice de tiempos...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo formatos...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Cargando codecs...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo los datos de audio...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Fin de la carga del album.");
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public void mostrarVistaPrevia(){
			Console.WriteLine("Mostrando el álbum de música " + nombre);
		}
		
		override public string ToString(){
			return this.getNombre();
		}
	}
}
