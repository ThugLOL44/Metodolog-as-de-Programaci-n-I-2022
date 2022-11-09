using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class GeneradorDeDatosAleatorios
    {
        public int numeroAleatorio(int max)
        {
            Random random = new Random();
            int aleatorio = random.Next(0, max);
            return aleatorio;
        }

        public string stringAleatorio(int cant)
        {
            var caracteres = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            var cadena = new char[cant];
            Random random = new Random();
            string result;

            for(int i = 0; i < cadena.Length; i++)
            {
                cadena[i] = caracteres[random.Next(caracteres.Length)];
            }

            result = new string(cadena);
            return result;
            
        }
        
    }
}
