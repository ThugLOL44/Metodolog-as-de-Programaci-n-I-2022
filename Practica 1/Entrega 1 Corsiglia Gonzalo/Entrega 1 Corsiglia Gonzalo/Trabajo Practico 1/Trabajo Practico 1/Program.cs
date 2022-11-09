using Trabajo_Practico_1;

public class Program 
{
public static void Main(string[] args) 
    {
        //Numero num1 = new Numero(2);
        //Numero num2 = new Numero(5);
        //Console.WriteLine(num1.SosIgual(num2));

        //Pila pila = new Pila();
        //pila.Agregar(num1);
        //pila.Agregar(num2);
        //Console.WriteLine(((Numero)pila.Maximo()).GetValor());

        //List<Numero> list = new List<Numero>();
        //for(int i = 0; i < 20; i++)
        //{
        //    list.Add(new Numero(new Random().Next()));
        //}

        //Pila pila = new Pila();
        //Pila cola = new Pila();
        //ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        //Llenar(pila);
        //Llenar(cola);
        //Informar(pila);
        //Informar(cola);
        //Informar(multiple);

        //Pila pila = new Pila();
        //Pila cola = new Pila();
        //ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        //LlenarPersonas(pila);
        //LlenarPersonas(cola);
        //Informar(multiple);

        Pila pila = new Pila();
        Pila cola = new Pila();
        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        LlenarAlumnos(pila);
        LlenarAlumnos(cola);
        pila.Agregar(new Alumno("gonzalo", new Numero(44042480),new Numero(10), new Numero(10)));
        Informar(multiple);

                

                
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
            coleccionable.Agregar(new Alumno(lista_nombres[i],new Numero(new Random().Next()),new Numero(new Random().Next(200)),new Numero(new Random().Next(10))));
        }
    }

    public static void Informar(Coleccionable coleccionable)
    {
        Console.WriteLine(coleccionable.Cuantos()); 
        Console.WriteLine(((Persona)coleccionable.Minimo()).GetDni().GetValor());
        Console.WriteLine(((Persona)coleccionable.Maximo()).GetDni().GetValor());
        Console.WriteLine("A continuacion ingrese los datos del alumno que quiere buscar (Nombre, Dni, Legajo, Promedio): ");
        Comparable c = new Alumno(Console.ReadLine(),new Numero(int.Parse(Console.ReadLine())),new Numero(int.Parse(Console.ReadLine())),new Numero(int.Parse(Console.ReadLine())));
        if (coleccionable.Contiene((c)))
            Console.WriteLine("El elemento leido esta en la coleccion");
        else
            Console.WriteLine("El elemento leido no esta en la coleccion");
    }
}
