using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Persona : Comparable
    {
        protected string nombre;
        protected Numero dni;
        public Persona(string n, Numero d)
        {
            this.nombre = n;
            this.dni = d;
        }
        public string GetNombre() { return nombre; }
        public Numero GetDni() { return dni; }

        public virtual bool SosIgual(Comparable comparable)
        {
            return this.dni.GetValor() == (((Persona)comparable).GetDni().GetValor());
        }
        
        public virtual bool SosMayor(Comparable comparable)
        {
            return this.dni.GetValor() < (((Persona)comparable).GetDni().GetValor());
        }

        public virtual bool SosMenor(Comparable comparable)
        {
            return this.dni.GetValor() > (((Persona)comparable).GetDni().GetValor());
        }
    }
}
