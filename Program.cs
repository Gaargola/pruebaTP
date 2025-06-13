using System;

namespace Club
{
  public class ErrorException : Exception {}
  public class Programa {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hola mundo");
      try
      {
        Console.Write("Ingrese un numero: ");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
          case 1:
            Console.WriteLine("Ingreso el número 1.");
            break;
          case 2:
            Console.WriteLine("Ingreso el numero 2.");
            break;
          default:
            Console.WriteLine("Ingreso un número que raro.");
            break;
        }
        for (int i = 0; i <= 10; i++)
        {
          Console.WriteLine("Secuencia de números: {0}",i);
        }

      } catch(FormatException) {
        Console.WriteLine("Valores incorrecto.");
      } catch(ErrorException){
        Console.WriteLine("Otro Error.");
      }
      finally{
        Console.WriteLine("Esta parte siempre se ejecuta.");
      }

      //Console.Write("Presione una tecla para finalizar...");
      //Console.ReadKey(true);
    }
  }
 }
