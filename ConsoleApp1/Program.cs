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

        }
    }
}
