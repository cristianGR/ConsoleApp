using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 18, 4, 9, 3, 2 };
            int cuenta = 0;
            int promedio = 0;

            for (int i = 0; i < array.Length; i++)
            {
                cuenta += array[i];
            }
            promedio = cuenta / array.Length;

            Console.WriteLine(promedio);
        }
    }
}
