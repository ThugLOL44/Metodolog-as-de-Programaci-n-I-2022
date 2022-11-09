using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    public class FabricaDePersonas : FabricaDeComparables
    {
        protected GeneradorDeDatosAleatorios generator = new GeneradorDeDatosAleatorios();
        protected LectorDeDatos lector = new LectorDeDatos();
        List<string> lista_nombres = new List<string>() { "Pepito", "Menganito", "Gonzalo", "Lucas", "Lourdes", "Juan", "Federico", "Gaston", "Marcelo", "Martin", "Emiliano", "Oscar", "Ivan", "Agustina", "Ludmila", "Vanesa", "Lautaro", "Raul", "Luciano", "Nestor", "Marcela","Alejandro","Ayelen","Fernando","Matias","Daniela","Daniel","Alicia","Antonio","Camila","Franco","Francisco","Paula","Roberto","Eugenia","Sebastian","Valentin"};
        public override Comparable crearAleatorio()
        {
            return new Persona(NombreAlAzar(), new Numero(DniAlAzar()));
        }

        public override Comparable crearPorTeclado()
        {
            return new Persona(lector.stringPorTeclado(), new Numero(lector.numeroPorTeclado()));
        }
        public string NombreAlAzar() 
        {
            return lista_nombres[new Random().Next(0,(lista_nombres.Count-1))];
        }
        public string NombrePorTeclado() 
        {
            return lector.stringPorTeclado();
        }
        public int DniAlAzar() 
        {
            return generator.numeroAleatorio(44042480);
        }
        public int DniPorTeclado()
        {
            return lector.numeroPorTeclado();
        }
    }
}
