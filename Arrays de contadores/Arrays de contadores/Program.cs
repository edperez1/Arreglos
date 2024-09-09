using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Arrays_de_contadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Número de los Vendedores 
            double salario, salariofinal;
            const int numvendedores = 8;
            int[] salarios = new int[10];
            double[] ventas = new double[numvendedores];

            // Leer las ventas de los Vendedores 
            Console.WriteLine("Son 8 vendedores ");
            for (int i = 0; i < numvendedores; i++)
            {

                Console.WriteLine("Ingrese las ventas Brutas de los Vendedores  ");
                ventas[i] = double.Parse(Console.ReadLine());
            }



            // Calcularemos los salarios de los vendedores 
            for (int i = 0; i < numvendedores; i++)
            {
                salario = 200 + (0.09 * ventas[i]);
                salariofinal = (int)salario;

                // Los rangos de el salario 
                if (salariofinal < 300)
                    salarios[0]++;
                else if (salariofinal <400)
                    salarios[1]++;
                else if (salariofinal < 500)
                    salarios[2]++;

                else if (salariofinal <600)
                    salarios[3]++;
                else if (salariofinal <700)
                    salarios[4]++;
                else if (salariofinal <800)
                    salarios[5]++;
                else if (salariofinal <900)
                    salarios[6]++;
                else if (salariofinal < 1000)
                    salarios[7]++;
                else
                    salarios[8]++;
            }

            Console.WriteLine("\nConteo de salarios por rango:");
            Console.WriteLine($"$200-$299: {salarios[0]}");
            Console.WriteLine($"$300-$399: {salarios[1]}");
            Console.WriteLine($"$400-$499: {salarios[2]}");
            Console.WriteLine($"$500-$599: {salarios[3]}");
            Console.WriteLine($"$600-$699: {salarios[4]}");
            Console.WriteLine($"$700-$799: {salarios[5]}");
            Console.WriteLine($"$800-$899: {salarios[6]}");
            Console.WriteLine($"$900-$999: {salarios[7]}");
            Console.WriteLine($"$1000 o superior: {salarios[8]}");
            //Salarios de los vendedores 
            Console.WriteLine();
            for (int i = 0; i < numvendedores; i++)
            {
                salario = 200 + (0.09 * ventas[i]);
                Console.WriteLine($"Salario del Vendedor {i + 1}: ${salario:F2}");




            }
            Console.ReadKey();
        }
    }
}
