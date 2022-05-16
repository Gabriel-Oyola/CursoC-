using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Ingresa 4 provincias de la argentina");
            string[] Provincias = new string[4];

            for (int i = 0; i < 4; i++)
            {
                Provincias[i] = Console.ReadLine();
            }
            Console.WriteLine("Las provincias son: ");
            foreach (string provincia in Provincias)
            {

                Console.WriteLine(provincia); 
            }
            */

            /*
            int[] numeros = { 31, 37, 34, 46, 20, 42 };

            foreach (int numero in numeros)
            {
                if (numero>18 && numero < 35)
                {
                    Console.WriteLine(numero);
                }
            }
            */

            /*
            int[] numeros = { -100, 56, -20, 15, -12, -20 }; 

            int c = 0;

            foreach (int numero in numeros)
            {
                if (numero>0)
                {
                    Console.WriteLine(numero);
                    c++; 
                }
            }

            Console.WriteLine("La cantidad de numeros positivos es: "+c);
            */
            /*
            int[] numeros = { 1, 3, 2, 4, 11, 19 };
            int suma = 0;

            foreach (int numero in numeros)
            {
                if (numero%2==0)
                {
                    suma += numero; 
                }
            }

            Console.WriteLine("El resultado de la suma es: "+ suma);
            Console.ReadLine();
            */
            /*
            int[] numeros = { 4, 5, -4, 7, 8, -2, 12, 176, -6 };
            int pos = 0;
            int sumaPos = 0;    
            int neg = 0;
            int SumaNeg = 0;
            
            foreach (int numero in numeros)
            {
                if (numero>0)
                {
                    pos++;
                    sumaPos+=numero;
                }
                else
                {
                    SumaNeg+=numero;
                    neg++;

                }
            }

            Console.WriteLine("La cantidad de numeros positivos es: " + pos);
            Console.WriteLine("La suma de numeros positivos es: "+ sumaPos);
            Console.WriteLine("La cantidad de numeros negativos es: "+neg);
            Console.WriteLine("La suma de numeros negativos es: " + SumaNeg);
            */
            //cantidad de numeros positivos de una cifra
            int[] numeros = { 10, 4, 6, 11, 145, 3453, 22, 44, 1, -6, -8 };

            int numCifra1 = 0; 
            int numCifra2 = 0;

            foreach (int numero in numeros)
            {
                if (numero>=0&&numero<=9)
                {
                    numCifra1++;
                }
                else if(numero>=10&&numero<100)
                {
                    numCifra2++;
                }
            }

            Console.WriteLine("La cantidad de numeros de una cifra son: "+numCifra1);
            Console.WriteLine("La cantidad de numeros de dos cifras son: "+numCifra2); 


            Console.ReadLine();
        }
    }
}
