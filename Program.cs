using System;

namespace Recurs
{
    class Program
    {
        static void triangl(int[] array) 
        {
            int[] array2;
            if (array.Length <= 1)
            {
                Console.WriteLine(array[0]+"\t");
                return;
            }
            else 
            {
                array2 = new int[array.Length-1];
                for (int i = 0; i < array.Length-1; i++)
                {
                    array2[i] = array[i] + array[i + 1];
                }
                triangl(array2);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine();
                return;
            }
        }
        static void Main(string[] args)
        {
            int arrayN = 0;
            bool rangeCheck = false;
            do
            {
                Console.Write("Enter array Range : ");
                rangeCheck = Int32.TryParse(Console.ReadLine(), out arrayN);
                if (!rangeCheck || arrayN < 1) {
                    Console.WriteLine("Wrong Range Enter ; ");
                }
                
            } while (!rangeCheck);

            int[] array = new int[arrayN];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool numCheck = false;
                do
                {
                    Console.Write("Enter array["+i+"] element : ");
                    numCheck = Int32.TryParse(Console.ReadLine(), out array[i]);
                    if (!numCheck)
                    {
                        Console.WriteLine("Wrong element Enter ; ");
                    }
                } while (!numCheck);
            }
            Console.Clear();
            triangl(array);

            Console.ReadKey();
        }
    }
}
