using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(function(a, b));
            int function(string str, int n)
            {
                string[] text2 = new string[n];
                char[] text = str.ToCharArray();
                int k = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    text2[k] = Convert.ToString(text[k]);
                    b++;
                }
                int s = 0;
                for (int i = k; i < text2.Length; i++)
                {
                    text2[i] = Convert.ToString(text[s]);
                    s++;
                    if (s == str.Length)
                    {
                        s = 0;
                    }
                }
                int counter = 0;
                for (int i = 0; i < 1; i++)
                {
                    for (int l = 0; l < text2.Length; l++)
                    {
                        if (text2[i] == text2[l])
                        {
                            counter++;
                        }
                    }

                }
                return counter;
            }
            Console.ReadKey();
        }

    }
}
