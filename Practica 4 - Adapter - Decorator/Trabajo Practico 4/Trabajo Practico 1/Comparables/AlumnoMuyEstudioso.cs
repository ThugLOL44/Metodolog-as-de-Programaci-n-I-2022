using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string n, Numero d, Numero l, Numero p) : base(n, d, l, p)
        {
        }
        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
