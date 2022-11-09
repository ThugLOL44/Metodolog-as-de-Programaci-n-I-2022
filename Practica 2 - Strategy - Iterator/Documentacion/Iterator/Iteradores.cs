/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 15/04/2019
 * Time: 14:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Iterator
{	
	
	public interface IteradorDePaginas
	{
		Pagina actual();
		void siguiente();
		bool fin();
	}
	
	public interface Iterable
	{
		IteradorDePaginas crearIterador();
	}
	
	public class IteradorDeArreglos : IteradorDePaginas {
		private Pagina[] paginas;
		private int dl;
		private int indice;
		
		public IteradorDeArreglos(Pagina[] p, int _dl){
			paginas = p;
			dl = _dl;
			indice = 0;
		}
		
		public Pagina actual(){
			return paginas[indice];
		}
		
		public void siguiente(){
			indice++;
		}
		
		public bool fin(){
			return indice >= dl;
		}
	}
	
	public class IteradorDeListasEnlazadas : IteradorDePaginas {
		private Diapositiva diapo;
		
		public IteradorDeListasEnlazadas(Diapositiva d){
			diapo = d;
		}
		
		public Pagina actual(){
			return diapo.getPagina();
		}
		
		public void siguiente(){
			diapo = diapo.getSiguiente();
		}
		
		public bool fin(){
			return diapo == null;
		}
	}
}
