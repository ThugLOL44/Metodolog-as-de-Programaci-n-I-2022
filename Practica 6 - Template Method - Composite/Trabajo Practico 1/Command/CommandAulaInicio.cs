using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class CommandAulaInicio : Command
    {
        Aula aula;
        public CommandAulaInicio(Aula aula)
        {
            this.aula = aula;
        }
        public void Execute()
        {
            Console.WriteLine("Se ejecutara CommandAulaInicio, presione una tecla...");
            Console.ReadKey();
            this.aula.comenzar();
        }
    }
}
