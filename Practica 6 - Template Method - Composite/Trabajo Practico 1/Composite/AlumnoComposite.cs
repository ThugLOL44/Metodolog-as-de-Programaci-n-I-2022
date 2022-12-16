using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class AlumnoComposite : IAlumno
    {
        private List<IAlumno> hijos = new List<IAlumno>();
        public void agregarHijo(IAlumno alumno) 
        {
            hijos.Add(alumno);
        }
        public int getCalificacion()       
        {
            foreach(IAlumno alumno in hijos)
            {
                alumno.getCalificacion();
            }
            return 0;
        }

        public Numero getDni()
        {
            foreach (IAlumno alumno in hijos)
            {
                Console.WriteLine(alumno.getDni());
            }
            return new Numero(0);
        }

        public Numero getLegajo()
        {
            foreach (IAlumno alumno in hijos)
            {
                Console.WriteLine(alumno.getLegajo());
            }
            return new Numero(0);
        }

        public string getNombre()
        {
            string nombres = "";
            foreach (IAlumno alumno in hijos)
            {
                nombres += alumno.getNombre() + "\n";
            }
            return nombres;
        }

        public Numero getPromedio()
        {
            foreach (IAlumno alumno in hijos)
            {
                Console.WriteLine(alumno.getPromedio());
            }
            return new Numero(0);

        }

        public string mostrarCalificacion()
        {
            string calificacionDeTodos = "";
            foreach(IAlumno alumno in hijos) 
            {
                calificacionDeTodos += alumno.mostrarCalificacion() + "\n";
            }
            return calificacionDeTodos;
        }

        public int responderPregunta(int pregunta)
        {
            return hijos[0].responderPregunta(pregunta);
        }

        public void setCalificacion(int valor)
        {
            foreach(IAlumno alumno in hijos) 
            {
                alumno.setCalificacion(valor);
            }
        }

        public bool SosIgual(Comparable comparable)
        {
            foreach (IAlumno alumno in hijos) 
            {
                if (alumno.SosIgual((IAlumno)comparable)) 
                {
                    return true;
                }
            }
            return false;
        }

        public bool SosMayor(Comparable comparable)
        {
            foreach (IAlumno alumno in hijos)
            {
                if (alumno.SosMayor((IAlumno)comparable))
                {
                    return true;
                }
            }
            return false;
        }

        public bool SosMenor(Comparable comparable)
        {
            foreach (IAlumno alumno in hijos)
            {
                if (alumno.SosMenor((IAlumno)comparable))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
