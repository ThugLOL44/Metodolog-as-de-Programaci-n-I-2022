using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabajo_Practico_1
{
    public class Alumno : Persona, Comparable
    {

        private Numero legajo;
        private Numero promedio;
        public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public Numero GetLegajo() { return legajo; }
        public Numero GetPromedio() { return promedio; }

        public override bool SosIgual(Comparable comparable)
        {
            return this.promedio.GetValor() == (((Alumno)comparable).GetPromedio().GetValor());
        }

        public override bool SosMayor(Comparable comparable)
        {
            return this.promedio.GetValor() < (((Alumno)comparable).GetPromedio().GetValor());
        }

        public override bool SosMenor(Comparable comparable)
        {
            return this.promedio.GetValor() > (((Alumno)comparable).GetPromedio().GetValor());
        }
    }
}
