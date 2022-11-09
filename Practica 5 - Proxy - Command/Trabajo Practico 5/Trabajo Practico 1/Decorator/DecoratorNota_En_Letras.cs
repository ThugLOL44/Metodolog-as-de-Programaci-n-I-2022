using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class DecoratorNota_En_Letras : DecoratorAlumnos
    {
        public DecoratorNota_En_Letras(IAlumno IAlumno) : base(IAlumno)
        {
        }
        public override string mostrarCalificacion()
        {
            List<string> lista = new List<string>() {"CERO","UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVE","DIEZ"};
            return this.IAlumno.mostrarCalificacion() + "(" + lista[this.IAlumno.getCalificacion()] + ")";
        }
    }
}
