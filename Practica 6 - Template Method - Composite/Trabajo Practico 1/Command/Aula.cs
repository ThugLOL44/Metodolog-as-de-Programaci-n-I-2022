using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class Aula
    {
        Teacher teacher;
        public void comenzar() 
        {
            Console.WriteLine("comienza la clase...");
            teacher = new Teacher();
        }
        public void nuevoAlumno(IAlumno alumno) 
        {
            teacher.goToClass(new Adapter_Alumno(alumno));
        }
        public void claseLista() 
        {
            teacher.teachingAClass();
        }
    }
}
