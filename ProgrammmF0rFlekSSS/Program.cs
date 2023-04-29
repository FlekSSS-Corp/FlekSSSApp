using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammmF0rFlekSSS
{
    class Roman
    {
        static public void Array ()
        {
            int[] arr = { 1, -2, 3, -4, 5 };

            Console.WriteLine("Исходный массив:");

            PrintArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] *= 2;
                }
                else if (arr[i] < 0)
                {
                    arr[i] *= 3;
                }
            }

            Console.WriteLine("Массив после выполнения программы:");

            PrintArray(arr);

            Console.ReadKey();
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Roman.Array();
        }
    }
}
