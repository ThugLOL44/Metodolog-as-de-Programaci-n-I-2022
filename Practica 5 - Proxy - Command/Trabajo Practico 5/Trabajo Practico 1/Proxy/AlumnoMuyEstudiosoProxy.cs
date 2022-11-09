using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class AlumnoMuyEstudiosoProxy : IAlumno
    {
        AlumnoMuyEstudioso alumnoReal = null;
        string nombre;
        Numero dni;
        Numero legajo;
        Numero promedio;
        int calificacion;
        public StrategyComparacion comparacion;
        public AlumnoMuyEstudiosoProxy(string n, Numero d, Numero l, Numero p)
        {
            this.nombre = n;
            this.dni = d;
            this.legajo = l;
            this.promedio = p;
            comparacion = new ComparacionCalificacion();
        }
        public int getCalificacion()
        {
            if (alumnoReal == null)
            {
                return this.calificacion;
            }
            else
            {
                return this.alumnoReal.getCalificacion();
            }
        }

        public Numero getDni()
        {
            if (alumnoReal == null)
            {
                return this.dni;
            }
            else
            {
                return this.alumnoReal.getDni();
            }
        }

        public Numero getLegajo()
        {
            if (alumnoReal == null)
            {
                return this.legajo;
            }
            else
            {
                return this.alumnoReal.getLegajo();
            }
        }

        public string getNombre()
        {
            if (alumnoReal == null)
            {
                return this.nombre;
            }
            else
            {
                return this.alumnoReal.getNombre();
            }
        }

        public Numero getPromedio()
        {
            if (alumnoReal == null)
            {
                return this.promedio;
            }
            else
            {
                return this.alumnoReal.getPromedio();
            }
        }

        public string mostrarCalificacion()
        {
            if (alumnoReal == null)
            {
                return this.getNombre() + " calificacion: " + this.calificacion;
            }
            else
            {
                return this.alumnoReal.mostrarCalificacion();
            }
        }

        public int responderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                alumnoReal = new AlumnoMuyEstudioso(this.nombre, this.dni, this.legajo, this.promedio);
                alumnoReal.setCalificacion(this.calificacion);
                alumnoReal.comparacion = this.comparacion;
            }
            return alumnoReal.responderPregunta(pregunta);
        }

        public void setCalificacion(int valor)
        {
            if (alumnoReal == null)
            {
                this.calificacion = valor;
            }
            else
            {
                this.alumnoReal.setCalificacion(valor);
            }
        }

        public bool SosIgual(Comparable comparable)
        {
            if (alumnoReal == null)
            {
                return comparacion.sosIgual(this, comparable);
            }
            else
            {
                return this.alumnoReal.comparacion.sosIgual(this.alumnoReal, comparable);
            }
        }

        public bool SosMayor(Comparable comparable)
        {
            if (alumnoReal == null)
            {
                return comparacion.sosMayor(this, comparable);
            }
            else
            {
                return this.alumnoReal.comparacion.sosMayor(this.alumnoReal, comparable);
            }
        }

        public bool SosMenor(Comparable comparable)
        {
            if (alumnoReal == null)
            {
                return comparacion.sosMenor(this, comparable);
            }
            else
            {
                return this.alumnoReal.comparacion.sosMenor(this.alumnoReal, comparable);
            }
        }
    }
}
