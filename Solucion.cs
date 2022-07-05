using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
    
        static void Main(string[] args)
        {
            
            int[] arr = { 4, 2, 19, 12, 5, 15 };

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            for(int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != arr.Length - 1)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            int valor_actual = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = valor_actual;
                        }
                    }
                }
            }





            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();




            // Ejercicio #2
            int[] arr = new int[5];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                int n = Convert.ToInt32(Console.ReadLine());
                arr[i] = n;
            }


            
            for(int i = 0; i < arr.Length; i++)
            {
                for(int k = 0; k < arr.Length; k++)
                {
                    if (i != arr.Length - 1)
                    {
                        if (arr[i] < arr[i + 1])
                        {
                            int valor_actual = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = valor_actual;
                        }
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }






            Console.ReadKey();
        }
    }
}
