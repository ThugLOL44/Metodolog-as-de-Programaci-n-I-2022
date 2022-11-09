/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 18/06/2019
 * Time: 9:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Adapter
{
	public interface IImage{
		string getName();
		void showPreview();
	}
	
	public class Imagen : IImage{
		private string nombre;
		
		public Imagen(string s){
			nombre = s;
			
			Console.WriteLine("Creando imagen " + nombre + "...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo paleta de colores...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Leyendo píxeles...");
			System.Threading.Thread.Sleep(800);
			Console.WriteLine("Fin de la carga de la imagen.");
		}
		
		public string getName(){
			return nombre;
		}
		
		public void showPreview(){
			Console.WriteLine("Mostrando la imagen " + nombre);
		}
		
		override public string ToString(){
			return this.getName();
		}
	}
}
