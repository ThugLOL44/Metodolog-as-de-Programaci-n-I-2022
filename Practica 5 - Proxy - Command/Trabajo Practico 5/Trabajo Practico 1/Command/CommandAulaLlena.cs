using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class CommandAulaLlena : Command
    {
        Aula aula;
        public CommandAulaLlena(Aula aula) 
        {
            this.aula = aula;
        }

        public void Execute()
        {
            Console.WriteLine("Se ejecutara CommandAulaLlena, presione una tecla...");
            Console.ReadKey();
            this.aula.claseLista();
        }
    }
}
