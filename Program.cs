using System;

namespace Club
{
  public class ErrorException : Exception {}
  public class Programa {
    public static void Main(string[] args)
    {
      // Datos guardados
      Persona.personas[0] = new Persona("Jose", 2313442,23,23423.45);
      Persona.personas[1] = new Persona("Juse", 2312344,13,123.45);
      Persona.personas[2] = new Persona("Pepe", 2314556,31,2344.99);
      Persona.personas[3] = new Persona("Lol", 1234554,12,4123.23);
      // Objeto aux
      Persona aux = new Persona("",0,0,0);

      Console.WriteLine("Menú: 1. Listado de personas.");
      try
      {
        Console.Write("Ingresa la opción: ");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
          case 1:
            aux.ListadoPersonas();
            break;
          case 2:
            Console.WriteLine("Ingreso el numero 2.");
            break;
          default:
            Console.WriteLine("Ingreso un número que raro.");
            break;
        }
        //for (int i = 0; i <= 10; i++)
        //{
        //  Console.WriteLine("Secuencia de números: {0}",i);
        //}

      } catch(FormatException) {
        Console.WriteLine("Valores incorrecto.");
      } catch(ErrorException){
        Console.WriteLine("Otro Error.");
      }
      finally{
        Console.WriteLine("Esta parte siempre se ejecuta.");
      }
    }
  }
    public class Persona 
    {
      public int dni;
      public string nombre;
      public int edad;
      public double dinero;
      public static Persona[] personas = new Persona[10];
      public static int contador = 3;

      public Persona(string nombre, int dni, int edad, double dinero) 
      {
        this.dni = dni;
        this.nombre = nombre;
        this.edad = edad;
        this.dinero = dinero;
      }

      public void ListadoPersonas()
      {
        Console.WriteLine("Listado de personas: ");
        for (int i = 0; i < contador; i++)
        {
          Console.WriteLine("Nombre: {0}, DNI: {1}, Edad: {2}, Dinero: {3}", personas[i].nombre, personas[i].dni, personas[i].edad, personas[i].dinero);
        }
        Console.WriteLine("Listado completo...");
      }
    }
  }
