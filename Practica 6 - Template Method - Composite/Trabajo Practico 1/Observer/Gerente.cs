using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Gerente : Observador
    {
        List<Vendedor> lista = new List<Vendedor>();
        Coleccionable mejores = new Cola();

        public void actualizar(Observable observable)
        {
            this.venta(((Vendedor)observable).GetMonto, (Vendedor)observable);
        }

        public void cerrar()
        {
            Comparable vendedor;
            Iterador iter = ((Iterable)mejores).CrearIterador();
            while (!iter.Fin()) 
            {
                Vendedor x = (Vendedor)iter.Actual();
                Console.WriteLine(x.GetNombre() + " " + x.GetBonus());
                iter.Siguiente();
            }

        }

        public void venta(Numero monto, Vendedor vendedor) 
        {
            if (monto.GetValor() > 5000) 
            {
                if (!mejores.Contiene(vendedor)) 
                {
                    mejores.Agregar(vendedor);
                }
                vendedor.aumentaBonus();

            }
        }

    }
}
