/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 12/06/2019
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Adapter;

namespace Proxy
{
	public class DocumentoProxy : IDocumento {
		private IDocumento documentoReal = null;
		private string nombre;
		private int opcion;

		public DocumentoProxy(string n, int o){
			nombre = n;
			opcion = o;
		}

		public string getNombre(){
			return nombre;
		}
				
		override public string ToString(){
			return this.getNombre();
		} 

		public void mostrarVistaPrevia(){
			if(documentoReal == null){
				documentoReal = FabricaDeDocumentos.crearDocumento(nombre, opcion);
			}

			documentoReal.mostrarVistaPrevia();
		}

	}
	
	public abstract class FabricaDeDocumentos{
		public static IDocumento crearDocumento(string nombre, int opcion){
			FabricaDeDocumentos fabrica = null;
			switch(opcion){
					case 1: fabrica = new FabricaDeDocumentoDeTexto(); break;
					case 2: fabrica = new FabricaDePlanillaDeCalculo(); break;
					case 3: fabrica = new FabricaDePresentacionDeDiapositivas(); break;
					case 4: fabrica = new FabricaDeAlbumDeMusica(); break;
					
					//Para el adapter
					case 5: fabrica = new FabricaDeImagenes(); break;
			}
			return fabrica.crearDocumento(nombre);
		}
		
		abstract public IDocumento crearDocumento(string nombre);
	}
	
	public class FabricaDeDocumentoDeTexto : FabricaDeDocumentos{
		override public IDocumento crearDocumento(string nombre){
			return new DocumentoDeTexto(nombre);
		}
	}
	
	public class FabricaDePlanillaDeCalculo : FabricaDeDocumentos{
		override public IDocumento crearDocumento(string nombre){
			return new PlanillaDeCalculo(nombre);
		}
	}
	
	public class FabricaDePresentacionDeDiapositivas : FabricaDeDocumentos{
		override public IDocumento crearDocumento(string nombre){
			return new PresentacionDeDiapositivas (nombre);
		}
	}
	
	public class FabricaDeAlbumDeMusica : FabricaDeDocumentos{
		override public IDocumento crearDocumento(string nombre){
			return new AlbumDeMusica(nombre);
		}
	}

}
