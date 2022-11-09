using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public abstract class FabricaDeComparables : Fabrica
    {
        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 3:
                    fabrica = new FabricaDeVendedores();
                    break;
                case 4:
                    fabrica = new FabricaDeAlumnoMuyEstudioso();
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnosProxy();
                    break;
                case 6:
                    fabrica = new FabricaDeAlumnosMuyEstudiososProxy();
                    break;
                default:
                    fabrica = null;
                    break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 3:
                    fabrica = new FabricaDeVendedores();
                    break;
                case 4:
                    fabrica = new FabricaDeAlumnoMuyEstudioso();
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnosProxy();
                    break;
                case 6:
                    fabrica = new FabricaDeAlumnosMuyEstudiososProxy();
                    break;
                default:
                    fabrica = null;
                    break;
            }
            return fabrica.crearPorTeclado();
        }

        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}
