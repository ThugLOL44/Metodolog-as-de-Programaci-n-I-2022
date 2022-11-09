using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public interface Fabrica
    {
        Comparable crearAleatorio();
        Comparable crearPorTeclado();  
    }
}
