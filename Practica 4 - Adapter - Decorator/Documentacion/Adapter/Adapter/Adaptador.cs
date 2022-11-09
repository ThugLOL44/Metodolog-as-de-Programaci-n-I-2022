/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 18/06/2019
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Proxy;

namespace Adapter
{
	public class DocumentoAdapter : IDocumento {
    	IImage imagen;
   
    	public DocumentoAdapter(IImage i){
			imagen = i;
    	}
    	public string getNombre(){
			return imagen.getName();
    	}
    	public void mostrarVistaPrevia(){
			imagen.showPreview();
    	}
	}

}
