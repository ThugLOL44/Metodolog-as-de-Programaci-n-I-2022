using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class DecoratorPromocion : DecoratorAlumnos
    {
        public DecoratorPromocion(IAlumno IAlumno) : base(IAlumno)
        {
        }
        public override string mostrarCalificacion()
        {
            string result = "";
            if (this.IAlumno.getCalificacion() > 7) { result = "(PROMOCION)"; }
            else if (this.IAlumno.getCalificacion() >= 4 && this.IAlumno.getCalificacion() <= 7) { result = "(APROBADO)"; }
            else if (this.IAlumno.getCalificacion() < 4) { result = "(DESAPROBADO)"; }
            return this.IAlumno.mostrarCalificacion() + " " + result;
        }
    }
}
