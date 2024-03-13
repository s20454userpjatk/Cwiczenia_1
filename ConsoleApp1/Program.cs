using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Przykładowa pętla for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Wartość zmiennej i: " + i);
            }


            // Przykładowa pętla while
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("Wartość zmiennej j: " + j);
                j++;
            }



            // Przykładowa pętla do-while
            int k = 0;
            do
            {
                Console.WriteLine("Wartość zmiennej k: " + k);
                k++;
            } while (k < 5);



            int[] numbers = { 5, 10, 15, 20, 25 };
            double average = CalculateAverage(numbers);
            Console.WriteLine("Średnia liczb w tablicy: " + average);


        }

        static double CalculateAverage(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta.");
            }

            int suma = 0;
            foreach (int number in array)
            {
                suma += number;
            }

            return (double)suma / array.Length;
        }


    }
}
