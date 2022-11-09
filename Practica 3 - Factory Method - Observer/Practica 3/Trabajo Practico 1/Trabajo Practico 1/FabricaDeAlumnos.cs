using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public abstract class FabricaDeAlumnos : FabricaDeComparables
    {
        public static Alumno crearAlumnos(int opcion)
        {
            FabricaDeNumeros fabricaR = new FabricaNumeroRandom();
            FabricaDeNumeros fabricaT = new FabricaNumeroPorTeclado();
            Alumno alumno = null;
            switch (opcion)
            {
                case 1:
                    alumno = ((Alumno)fabricaR.crearAleatorio());
                    break;
                case 2:
                    alumno = ((Alumno)fabricaT.crearPorTeclado());
                    break;
                default:
                    alumno = null;
                    break;
            }
            return alumno;

        }
        public Comparable crearAleatorio()
        {
            FabricaDeAlumnos fabrica = new FabricaAlumnosRandom();
            return fabrica.crearAleatorio();
        }

        public Comparable crearPorTeclado()
        {
            FabricaDeAlumnos fabrica = new FabricaAlumnosPorTeclado();
            return fabrica.crearPorTeclado();
        }

        public abstract Alumno CrearAlumno();
    }

    public class FabricaAlumnosRandom : FabricaDeAlumnos 
    {
        public override Alumno CrearAlumno() 
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            Console.WriteLine("Ingrese el maximo de caracteres: ");
            int maxc = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de dni maximo: ");
            int maxd = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese legajo maximo: ");
            int maxl = int.Parse(Console.ReadLine());
            int maxp = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el maximo de caracteres: ");
            return new Alumno(generador.stringAleatorio(maxc), new Numero(generador.numeroAleatorio(maxd)), new Numero(generador.numeroAleatorio(maxl)), new Numero(generador.numeroAleatorio(maxp)));
        }
    }

    public class FabricaAlumnosPorTeclado : FabricaDeAlumnos 
    {
        public override Alumno CrearAlumno()
        {
            LectorDeDatos lector = new LectorDeDatos();
            return new Alumno(lector.stringPorTeclado(),new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()), new Numero(lector.numeroPorTeclado()));
        }
    }
}
