using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int[,] matriz = new int[2, 2];

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write("numero: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                int mult = 1;
                for (int j = 0; j < 2; j++)
                {
                    mult *= matriz[i, j];

                }
                Console.WriteLine("#" + i + " -- " + mult);
            }
            
            //Ejercicio 2
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write("numero: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                int suma = 0;
                for (int j = 0; j < 2; j++)
                {
                    suma = suma +  matriz[j, i];

                }
                Console.WriteLine("#" + i + " -- " + suma);
            }

            //Ejercicio 3
            int[,] matriz = new int[3, 3];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("numero: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("Filas");
            for (int i = 0; i < 3; i++)
            {
                int suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma = suma + matriz[i, j];

                }
                Console.WriteLine("#" + i + " -- " + suma);
            }


            Console.WriteLine("Columnas");
            for (int i = 0; i < 3; i++)
            {
                int suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma = suma +  matriz[j, i];

                }
                Console.WriteLine("#" + i + " -- " + suma);
            }

            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum = sum + matriz[i, i];
            }
            Console.WriteLine("Cruzada: " + sum);


            Console.ReadKey();
        }
    }
}
