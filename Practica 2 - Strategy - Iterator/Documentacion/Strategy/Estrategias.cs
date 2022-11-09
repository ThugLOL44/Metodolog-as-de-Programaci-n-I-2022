/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 28/03/2019
 * Time: 15:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SalaDeTeatro
{
	public interface PoliticaDeVenta{
		string vender(int cantidad, Asiento[,] asientos);
	}

	public class PorFila : PoliticaDeVenta
	{
		public string vender(int cantidad, Asiento[,] asientos) {
			for(int f = 0; f < asientos.GetLength(0); f++)
				for(int c = 0; c < asientos.GetLength(1) - cantidad; c++){
					int o = 0;
					while((! asientos[f, c + o].estasVendido()) && (o < cantidad))
						o++;
					if(o == cantidad){
						string asis = "";
						for(int a = 0; a < cantidad; a ++){
							asientos[f, c+a].vender();
							asis+= "Asiento en la fila " + f + " columna " + (c+a) + "; ";
						}
						return asis;
					}
			}
			return "No hay disponibilidad";
		}

	}
}
