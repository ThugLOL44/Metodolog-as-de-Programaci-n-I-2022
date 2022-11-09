using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabajo_Practico_1
{
    public class Alumno : Persona, Comparable, IAlumno
    {

        private Numero legajo;
        private Numero promedio;
        private int calificacion;
        
        public StrategyComparacion comparacion;
        public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            comparacion = new ComparacionCalificacion();
            
        }

        public Numero GetLegajo() { return legajo; }
        public Numero GetPromedio() { return promedio; }

        public StrategyComparacion c
        {
            set { comparacion = value; }
        }

        public int GetCalificacion { get { return calificacion; } set { calificacion = value; } }
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
        
        public virtual int responderPregunta(int pregunta) 
        {
            return new Random().Next(1, 3);
        }

        public string mostrarCalificacion()
        {
            return mostrarCalificacion(this.calificacion);
        }

        public string mostrarCalificacion(int calificacion)
        {
            return  "Nombre: "+ this.nombre + "             Calificacion: " + this.calificacion;
        }

        public void setCalificacion(int valor)
        {
            calificacion = valor;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getCalificacion()
        {
            return this.calificacion;
        }

        public Numero getLegajo()
        {
            return this.legajo;
        }

        public Numero getPromedio()
        {
            return this.promedio;
        }

        public Numero getDni()
        {
            return this.dni;
        }
    }
}
