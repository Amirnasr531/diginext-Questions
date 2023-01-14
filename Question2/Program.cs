using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(function(text));
            int function(string str)
            {
                int counter = 0;
                char[] letter = str.ToCharArray();
                for (int i = 0; i < letter.Length-1; i++)
                {
                    if (letter[i]==letter[i+1])
                    {
                        counter++;
                    }
                }
                return counter;
            }
            Console.ReadKey();
        }
    }
}
