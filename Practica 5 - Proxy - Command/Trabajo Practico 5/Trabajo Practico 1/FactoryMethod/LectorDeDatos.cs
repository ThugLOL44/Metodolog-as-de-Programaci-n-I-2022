using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class LectorDeDatos
    {
        public int numeroPorTeclado() 
        {
            Console.WriteLine("Ingrese un numero: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }

        public string stringPorTeclado() 
        {
            Console.WriteLine("Ingrese una cadena de texto: ");
            string x = Console.ReadLine();
            return x;
        }
    }
}
