using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class FabricaDeAlumnoMuyEstudioso : FabricaDeAlumnos
    {
        public override Comparable crearAleatorio()
        {
            return new AlumnoMuyEstudioso(NombreAlAzar(),new Numero(DniAlAzar()),new Numero(generator.numeroAleatorio(100)),new Numero(generator.numeroAleatorio(10)));
        }
        public override Comparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(lector.stringPorTeclado(), new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()));
        }
    }
}
