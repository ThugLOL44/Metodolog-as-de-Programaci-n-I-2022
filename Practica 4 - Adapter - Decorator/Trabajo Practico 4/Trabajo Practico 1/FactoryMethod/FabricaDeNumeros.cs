using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generator = new GeneradorDeDatosAleatorios();
            return new Numero(generator.numeroAleatorio(new Random().Next()));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            return new Numero(lector.numeroPorTeclado());
        }
    }

}
