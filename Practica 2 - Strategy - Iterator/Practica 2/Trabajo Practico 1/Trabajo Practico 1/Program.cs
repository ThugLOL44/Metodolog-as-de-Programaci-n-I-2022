using Trabajo_Practico_1;

public class Program 
{
public static void Main(string[] args) 
    {


        //Pila pila = new Pila();
        //Pila cola = new Pila();
        //ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        //LlenarAlumnos(pila);
        //LlenarAlumnos(cola);
        //Alumno g = new Alumno("gonzalo", new Numero(44042480), new Numero(100), new Numero(10));
        //g.CambiarEstrategia(new ComparacionNombre());
        //pila.Agregar(g);
        //Informar(multiple);

        Pila pila = new Pila();
        LlenarAlumnos(pila);
        ImprimirElementos(pila);
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
        Console.Clear();

        CambiarEstrategia(pila, new ComparacionNombre());
        Informar(pila);
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
        Console.Clear();

        CambiarEstrategia(pila, new ComparacionLegajo());
        Informar(pila);
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
        Console.Clear();

        CambiarEstrategia(pila, new ComparacionPromedio());
        Informar(pila);
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
        Console.Clear();

        CambiarEstrategia(pila, new ComparacionDNI());
        Informar(pila);
        Console.WriteLine();
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
        Console.Clear();

    }

    public static void Llenar(Coleccionable coleccionable) 
    {
    for(int i = 0; i < 20; i++) 
        {
            coleccionable.Agregar(new Numero(new Random().Next()));
        }
    }

    public static void LlenarPersonas(Coleccionable coleccionable)
    {
        List<string> lista_nombres = new List<string>(){"Juan", "Gonzalo", "Pedro", "Martin", "Gaston", "Marcelo", "Emiliano", "Oscar", "Nestor", "Agustina", "Matias", "Ivan", "Diego", "Marcos", "Lucas", "Alejandro", "Francisco", "Julia", "Vanesa", "Florencia"};
        for (int i = 0; i < 20; i++)
        {
           coleccionable.Agregar(new Persona(lista_nombres[i], new Numero(new Random().Next())));   
        }
    }

    public static void LlenarAlumnos(Coleccionable coleccionable) 
    {
        for (int i = 0; i < 20; i++)
        {
            List<string> lista_nombres = new List<string>() { "Juan", "Gonzalo", "Pedro", "Martin", "Gaston", "Marcelo", "Emiliano", "Oscar", "Nestor", "Agustina", "Matias", "Ivan", "Diego", "Marcos", "Lucas", "Alejandro", "Francisco", "Julia", "Vanesa", "Florencia" };
            Alumno a = new Alumno(lista_nombres[i], new Numero(new Random().Next()), new Numero(new Random().Next(200)), new Numero(new Random().Next(10)));
            coleccionable.Agregar(a);
        }
    }

    public static void Informar(Coleccionable coleccionable)
    {
        Console.WriteLine(coleccionable.Cuantos());
        //Console.WriteLine(((Persona)coleccionable.Minimo()).GetDni().GetValor());
        //Console.WriteLine(((Persona)coleccionable.Maximo()).GetDni().GetValor());
        Console.WriteLine(coleccionable.Minimo());
        Console.WriteLine(coleccionable.Maximo());
        //Comparable c = new Alumno(Console.ReadLine(),new Numero(int.Parse(Console.ReadLine())),new Numero(int.Parse(Console.ReadLine())),new Numero(int.Parse(Console.ReadLine())));
        //if (coleccionable.Contiene((c)))
        //    Console.WriteLine("El elemento leido esta en la coleccion");
        //else
        //    Console.WriteLine("El elemento leido no esta en la coleccion");
    }

    public static void ImprimirElementos(Coleccionable coleccionable)
    {
        Console.WriteLine("Imprimiendo Elementos del Coleccionable: ");
        Iterador i = coleccionable.CrearIterador();
        while (!i.Fin()) 
        {
            Console.WriteLine(((Alumno)i.Actual()).GetNombre().ToString());
            i.Siguiente();
        }
    }
    public static void CambiarEstrategia(Coleccionable Coleccion, StrategyComparacion estrategia)
    {
        Console.WriteLine("Cambiando Estrategia...");
        Iterador iterador = Coleccion.CrearIterador();
        while (!iterador.Fin())
        {

            object alumno = iterador.Actual();
            ((Alumno)alumno).CambiarEstrategia(estrategia);
            iterador.Siguiente();
        }
    }
}
