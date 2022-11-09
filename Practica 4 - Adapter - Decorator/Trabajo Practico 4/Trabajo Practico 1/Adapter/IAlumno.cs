using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public interface IAlumno : Comparable
    {
        string mostrarCalificacion();
        void setCalificacion(int valor);
        int responderPregunta(int pregunta);
        string getNombre();
        int getCalificacion();
        Numero getLegajo();
        Numero getPromedio();
        Numero getDni();
    }
}
