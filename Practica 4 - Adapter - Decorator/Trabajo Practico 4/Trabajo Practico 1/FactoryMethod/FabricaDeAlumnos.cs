using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class FabricaDeAlumnos : FabricaDePersonas
    {
        public override Comparable crearAleatorio()
        {
            return new Alumno(base.NombreAlAzar(), new Numero(base.DniAlAzar()), new Numero(base.generator.numeroAleatorio(100)), new Numero(base.generator.numeroAleatorio(10)));
        }
        public override Comparable crearPorTeclado()
        {
            return new Alumno(base.lector.stringPorTeclado(), new Numero(base.lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()), new Numero(base.lector.numeroPorTeclado()));
        }
    }
}
