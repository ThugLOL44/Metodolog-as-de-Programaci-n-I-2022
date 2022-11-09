/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 15/04/2019
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Iterator
{
	public class Pagina{
		private int numero;
		
		public Pagina(int n){
			numero = n;
		}
		
		override public string ToString(){
			return "" + numero;
		}
	}
	
	public interface IDocumento : Iterable {
		void agregarPagina(Pagina p);
		string getTitulo();
	}
	
	public class DocumentoDeTexto : IDocumento {
		private Pagina[] paginas;
		private string titulo;
		private int dl;
		
		public string getTitulo(){
			return titulo;
		}
		
		public DocumentoDeTexto(int ps, string t){
			titulo = t;
			paginas = new Pagina[ps];
			dl = 0;
		}
		
		public void agregarPagina(Pagina p){
			paginas[dl++] = p;
		}
		
		public IteradorDePaginas crearIterador(){
			return new IteradorDeArreglos(paginas, dl);
		}
	}
	
	public class Diapositiva{
		private Pagina pagina;
		private Diapositiva siguiente;
		
		public Diapositiva(Pagina p, Diapositiva s){
			pagina = p;
			siguiente = s;
		}
		
		public Pagina getPagina(){
			return pagina;
		}
		
		public Diapositiva getSiguiente(){
			return siguiente;
		}
	}
	
	public class Presentacion : IDocumento {
		private Diapositiva siguiente;
		private string titulo;
		
		public Presentacion(string t){
			titulo = t;
			siguiente = null;
		}
		
		public string getTitulo(){
			return titulo;
		}
		
		public void agregarPagina(Pagina p){
			siguiente = new Diapositiva(p, siguiente);
		}
		
		public IteradorDePaginas crearIterador(){
			return new IteradorDeListasEnlazadas(siguiente);
		}
	}
	
	public class Impresora
	{
		public void imprimir(IDocumento doc){
			IteradorDePaginas ite = doc.crearIterador();
			Console.WriteLine("Imprimiendo documento " + doc.getTitulo());
			while(! ite.fin()){
				this.imprimirPagina(ite.actual());
				ite.siguiente();
			}
		}
		
		private void imprimirPagina(Pagina p){
			Console.WriteLine("\tImprimiendo página " + p);
		}
	}
	
	public class Program {
				
		public static void Main(string[] args)	{
			IDocumento docText = crearDocumentoDeTexto();
			IDocumento docPres = crearPresentacion();
			
			Impresora i = new Impresora();
			i.imprimir(docText);
			i.imprimir(docPres);
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
		
		private static IDocumento crearDocumentoDeTexto(){
			int paginas = 10;
			IDocumento d = new DocumentoDeTexto(paginas, "Manual del uso de los patrones de diseño");
			for(int i= 1; i<= paginas; i++)
				d.agregarPagina(new Pagina(i));
			return d;
		}
		
		private static IDocumento crearPresentacion(){
			int paginas = 6;
			IDocumento d = new Presentacion("Presentación para el buen uso de los patrones de diseño");
			for(int i= 1; i<= paginas; i++)
				d.agregarPagina(new Pagina(i));
			return d;
		}
	}
}
