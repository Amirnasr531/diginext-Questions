using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 1, 2, 3, 4, 5, 6, };
            Console.WriteLine(function(numbers));
            int function(int[] array)
            {
                int counter = 0;
                int n = array.Length;
                for (int j = 1; j < n; j++)
                {
                    int k = array[j];
                    int i = j - 1;
                    while ((i > -1) && (array[i] > k))
                    {
                        array[i + 1] = array[i];
                        i--;
                    }
                    counter++;
                    array[i + 1] = k;
                }
                return counter;
            }
            Console.ReadKey();
        }
    }
}
