using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class CommandComparableLlegaAlumno : CommandComparable
    {
        Aula aula;
        public CommandComparableLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }
        public void Execute(Comparable comparable) 
        {
            
            this.aula.nuevoAlumno((IAlumno)comparable);
        }
    }
}
