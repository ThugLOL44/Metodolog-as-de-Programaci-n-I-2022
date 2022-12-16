using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabajo_Practico_1
{
    public class FabricaDeVendedores : FabricaDePersonas
    {
        public override Comparable crearAleatorio()
        {
            return new Vendedor(base.NombreAlAzar(),new Numero(base.DniAlAzar()),new Numero(base.generator.numeroAleatorio(80000)));
        }
        public override Comparable crearPorTeclado()
        {
            return new Vendedor(base.NombrePorTeclado(), new Numero(base.DniPorTeclado()),new Numero(base.lector.numeroPorTeclado()));
        }
    }

}
