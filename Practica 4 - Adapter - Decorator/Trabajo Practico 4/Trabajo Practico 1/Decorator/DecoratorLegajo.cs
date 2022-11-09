using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class DecoratorLegajo : DecoratorAlumnos
    {
        public DecoratorLegajo(IAlumno IAlumno) : base(IAlumno)
        {
        }
        public override string mostrarCalificacion()
        {
            return "(" + base.getLegajo() + ") " + base.mostrarCalificacion();
        }
    }
}
