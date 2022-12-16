using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Adapter_Alumno : Student
    {
        IAlumno IAlumno;
        public Adapter_Alumno(IAlumno a)
        {
            IAlumno = a;
        }
        public IAlumno getAlumno()
        {
            return IAlumno;
        }
        public bool equals(Student student)
        {
            return IAlumno.SosIgual(((Adapter_Alumno)student).getAlumno());
        }

        public string getName()
        {
            return IAlumno.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return IAlumno.SosMayor(((Adapter_Alumno)student).getAlumno());
        }

        public bool lessThan(Student student)
        {
            return IAlumno.SosMenor(((Adapter_Alumno)student).getAlumno());
        }

        public void setScore(int score)
        {
            IAlumno.setCalificacion(score);
        }

        public string showResult()
        {
            return IAlumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return IAlumno.responderPregunta(question);
        }
    }
}
