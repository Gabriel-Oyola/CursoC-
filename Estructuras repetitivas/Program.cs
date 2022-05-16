using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_repetitivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int numero =1;
            while (numero !=0)
            {
                Console.WriteLine("Ingrese un numero y calcule su triple"); 
                numero = int.Parse(Console.ReadLine());
                int resultado = numero * 3; 
                Console.WriteLine("Su triple es: "+resultado);
            }
            */

            /*
            int numero = 1; 

            while (numero>=0)
            {
                Console.WriteLine("Ingresa un numero para saber si es par o impar");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0) break;
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Es par");
                }
                else
                {
                    Console.WriteLine("Es impar");
                }
            }
            */

            /*
            int c = 0; 
            int numero = 1;
            do
            {
                Console.WriteLine("INGRESA UN NUMERO:"); 
                numero = int.Parse(Console.ReadLine());
                if (numero < 0) break; 
                c++; 
                 
            } while (numero>=0);
            Console.WriteLine("La cantidad de numero positivos ingresados es: " + c); 
            Console.WriteLine("El programa finalizo");

            */
            /*
            Console.WriteLine("Tabla del 2:");
            for (int i = 1; i <=12; i++)
            {
                int multiplicacion = 2 * i;
               
                Console.WriteLine("2x"+i+"= "+multiplicacion);
            }
            */

            Console.WriteLine("Ingrese el numero 1"); 
            int numero1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2"); 
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Los numero pares son: ");
            int max = Math.Max(numero1, numero2); 
            int min = Math.Min(numero1, numero2);

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                   
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine(); 
        }
    }
}
