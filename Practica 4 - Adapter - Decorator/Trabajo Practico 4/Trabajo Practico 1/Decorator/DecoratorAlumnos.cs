using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public abstract class DecoratorAlumnos : IAlumno
    {
        private IAlumno IAlumno;
        public DecoratorAlumnos(IAlumno IAlumno)
        {
            this.IAlumno = IAlumno;
        }

        public virtual int getCalificacion()
        {
           return this.IAlumno.getCalificacion();
        }

        public virtual Numero getDni()
        {
            return this.IAlumno.getDni();
        }

        public virtual Numero getLegajo()
        {
            return this.IAlumno.getLegajo();
        }

        public virtual string getNombre()
        {
            return this.IAlumno.getNombre();
        }

        public virtual Numero getPromedio()
        {
            return this.IAlumno.getPromedio();
        }

        public virtual string mostrarCalificacion()
        {
            return this.IAlumno.mostrarCalificacion();
        }

        public virtual int responderPregunta(int pregunta)
        {
            return this.IAlumno.responderPregunta(pregunta);
        }

        public virtual void setCalificacion(int valor)
        {
            this.IAlumno.setCalificacion(valor);
        }

        public virtual bool SosIgual(Comparable comparable)
        {
            return this.IAlumno.SosIgual(comparable);
        }

        public virtual bool SosMayor(Comparable comparable)
        {
            return this.IAlumno.SosMayor(comparable);
        }

        public virtual bool SosMenor(Comparable comparable)
        {
            return this.IAlumno.SosMenor(comparable);
        }
    }
}
