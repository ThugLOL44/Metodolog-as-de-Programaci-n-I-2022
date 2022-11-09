using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class DecoratorRecuadroAstericos : DecoratorAlumnos
    {
        public DecoratorRecuadroAstericos(IAlumno IAlumno) : base(IAlumno)
        {
        }
        public override string mostrarCalificacion()
        {
            string resultado = "***************************************************************************";
            resultado += ("\n* " + base.mostrarCalificacion() + " *");
            resultado += "\n***************************************************************************";

            return resultado;
        }
    }
}
