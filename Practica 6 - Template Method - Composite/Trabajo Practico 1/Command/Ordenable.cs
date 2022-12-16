using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public interface Ordenable
    {
        void setOrdenInicial(Command CommandAulaInicio);
        void setOrdenLlegaAlumno(CommandComparable CommandComparableLlegaAlumno);
        void setOrdenAulaLlena(Command CommandAulaLlena);
    }
}
