using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Vendedor : Persona, Observable
    {
        Numero sueldobasico;
        double bonus;
        List<Observador> observadores = new List<Observador>();
        Numero monto;

        public Vendedor(string n, Numero d, Numero sueldobasico) : base(n, d)
        {
            this.sueldobasico = sueldobasico;
            bonus = 1;
        }

        public void venta (Numero m) 
        {
            Console.WriteLine("Monto de vendedor {0}: $ {1} ",this.nombre, monto);
            monto = m;
            this.notificar();
        }

        public void aumentaBonus()
        {
            bonus += 0.1;
        }

        public void agregarObservador(Observador observador)
        {
            observadores.Add(observador);   
        }

        public void eliminarObservador(Observador observador)
        {
            observadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (Observador observador in observadores) 
            {
                observador.actualizar(this);
            }
        }

        public double GetBonus()
        {
            return bonus; 
        }
        public Numero GetMonto
        {
            get { return monto; }
            set { monto = value; }
        }

    }
}
