using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_unidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cp = 0, ci = 0;
            int[] numeros = new int [10];
            Console.WriteLine("Digite los datos de el Arreglo");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresa un Numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Estos son los datos de el arreglo");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {if (numeros[i] %2 == 0)
                {
                    cp++;
                }
                else
                {
                    ci++;
                }

                Console.Write(numeros[i] + " " );
            }
             Console.WriteLine();
             Console.WriteLine("Cantidad de Pares "+cp) ;
            Console.WriteLine("Cantidad de impares " + ci);


            Console.ReadKey();

        }
    }
}
