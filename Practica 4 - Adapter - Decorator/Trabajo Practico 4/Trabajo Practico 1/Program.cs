using Trabajo_Practico_1;

public class Program 
{
public static void Main(string[] args) 
    {
        Teacher teacher = new Teacher();
        for (int i = 0; i < 10; i++)
        {
            IAlumno alumno = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
            IAlumno decorador = new DecoratorNota_En_Letras(alumno);
            decorador = new DecoratorLegajo(decorador);
            decorador = new DecoratorPromocion(decorador);
            decorador = new DecoratorRecuadroAstericos(decorador);
            teacher.goToClass(new Adapter_Alumno(decorador));
        }
        teacher.teachingAClass();
        
        for(int i = 0; i < 10; i++) 
        {
            IAlumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(2);
            IAlumno decorador = new DecoratorNota_En_Letras(alumno);
            decorador = new DecoratorLegajo(decorador);
            decorador = new DecoratorPromocion(decorador);
            decorador = new DecoratorRecuadroAstericos(decorador);
            teacher.goToClass(new Adapter_Alumno(decorador));
        }
        teacher.teachingAClass();

    }

    //public static void Llenar(Coleccionable coleccionable) 
    //{
    //for(int i = 0; i < 20; i++) 
    //    {
    //        coleccionable.Agregar(new Numero(new Random().Next()));
    //    }
    //}

    //public static void LlenarPersonas(Coleccionable coleccionable)
    //{
    //    List<string> lista_nombres = new List<string>(){"Juan", "Gonzalo", "Pedro", "Martin", "Gaston", "Marcelo", "Emiliano", "Oscar", "Nestor", "Agustina", "Matias", "Ivan", "Diego", "Marcos", "Lucas", "Alejandro", "Francisco", "Julia", "Vanesa", "Florencia"};
    //    for (int i = 0; i < 20; i++)
    //    {
    //       coleccionable.Agregar(new Persona(lista_nombres[i], new Numero(new Random().Next())));   
    //    }
    //}

    //public static void LlenarAlumnos(Coleccionable coleccionable) 
    //{
    //    for (int i = 0; i < 20; i++)
    //    {
    //        List<string> lista_nombres = new List<string>() { "Juan", "Gonzalo", "Pedro", "Martin", "Gaston", "Marcelo", "Emiliano", "Oscar", "Nestor", "Agustina", "Matias", "Ivan", "Diego", "Marcos", "Lucas", "Alejandro", "Francisco", "Julia", "Vanesa", "Florencia" };
    //        Alumno a = new Alumno(lista_nombres[i], new Numero(new Random().Next()), new Numero(new Random().Next(200)), new Numero(new Random().Next(10)));
    //        coleccionable.Agregar(a);
    //    }
    //}

    //public static void Informar(Coleccionable coleccionable)
    //{
        //Console.WriteLine(coleccionable.Cuantos());
        //Console.WriteLine(((Persona)coleccionable.Minimo()).GetDni().GetValor());
        //Console.WriteLine(((Persona)coleccionable.Maximo()).GetDni().GetValor());
        //Console.WriteLine(coleccionable.Minimo());
        //Console.WriteLine(coleccionable.Maximo());
        //Comparable c = new Alumno(Console.ReadLine(),new Numero(int.Parse(Console.ReadLine())),new Numero(int.Parse(Console.ReadLine())),new Numero(int.Parse(Console.ReadLine())));
        //if (coleccionable.Contiene((c)))
        //    Console.WriteLine("El elemento leido esta en la coleccion");
        //else
        //    Console.WriteLine("El elemento leido no esta en la coleccion");
    //}

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

    public static void llenarNumeros(Coleccionable coleccionable)
    {
        Comparable num = null;
        for (int i = 0; i < 20; i++) 
        {
            num = FabricaDeComparables.crearAleatorio(1);
            coleccionable.Agregar(num);
        }
        Console.WriteLine("Se han creado 20 numeros");
    }
    public static void LlenarAlumnos(Coleccionable coleccionable)
    {
        Comparable alumno = null;
        for (int i = 0; i < 20; i++)
        {
            alumno = FabricaDeComparables.crearAleatorio(2);
            coleccionable.Agregar(alumno);
        }
        Console.WriteLine("Se han creado 20 alumnos");

    }
    public static void LlenarVendedores(Coleccionable coleccionable)
    {
        Comparable comparable = null;
        for (int i = 0; i < 20; i++)
        {
            comparable = FabricaDeComparables.crearAleatorio(3);
            coleccionable.Agregar(comparable);
            comparable = null;
        }
        Console.WriteLine("Se han creado 20 vendedores");
    }

    public static void Informar(Coleccionable coleccionable, int opcion) 
    {
        Console.WriteLine(coleccionable.Cuantos());
        Console.WriteLine(coleccionable.Minimo());
        Console.WriteLine(coleccionable.Maximo());
        Comparable comparable = FabricaDeComparables.crearAleatorio(2);
        if (coleccionable.Contiene(comparable))
        {
            Console.WriteLine("El elemento leído está en la colección");
        }
        else
        {
            Console.WriteLine("El elemento leído no está en la colección");
        }
    }

    public static void jornadaDeVentas(Coleccionable lista_vendedores) 
    {
        Iterador iter = lista_vendedores.CrearIterador();
        Random random = new Random();
        while (!iter.Fin()) 
        {
            for(int i = 0; i < 20; i++) 
            {
                Numero monto = new Numero(random.Next(1000, 6000));
                Vendedor v = (Vendedor)iter.Actual();
                v.venta(monto);
            }
            iter.Siguiente();
        }
    }
    public static void agregarObservador(Coleccionable coleccionable, Observador observador) 
    {
        Iterador iter = coleccionable.CrearIterador();
        while(!iter.Fin())
        {
            ((Vendedor)iter.Actual()).agregarObservador(observador);
            iter.Siguiente();
        }
    }



}
