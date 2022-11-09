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
        public StrategyComparacion comparacion;
        public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            comparacion = new ComparacionPromedio();
            
        }

        public Numero GetLegajo() { return legajo; }
        public Numero GetPromedio() { return promedio; }

        public StrategyComparacion c
        {
            set { comparacion = value; }
        }

        public StrategyComparacion GetStrategy() { return comparacion; }

        public void CambiarEstrategia(StrategyComparacion estrategia)
        {
            this.comparacion = estrategia;
        }


        public new bool SosIgual(Comparable comparable)
        {
            //return this.promedio.GetValor() == (((Alumno)comparable).GetPromedio().GetValor());
            return this.comparacion.sosIgual(this, comparable);
        }

        public new bool SosMayor(Comparable comparable)
        {
            //return this.promedio.GetValor() < (((Alumno)comparable).GetPromedio().GetValor());
            return this.comparacion.sosMayor(this, comparable);
        }

        public new bool SosMenor(Comparable comparable)
        {
            //return this.promedio.GetValor() > (((Alumno)comparable).GetPromedio().GetValor());
            return this.comparacion.sosMenor(this, comparable);
        }

        public override string ToString()
        {
            return "nombre: " + this.nombre + " dni: " + this.dni + " Legajo: " + this.legajo + " Promedio: " + this.promedio;
        }
    }
}
