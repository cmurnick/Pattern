using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
        
                var output = string.Empty;
                var input = Console.ReadLine();


                for (int i = 0; i < input.Length; i++)
                {
                    var letter = input[i].ToString();

                    output += letter.ToUpper();
                    for (int j = 0; j < i; j++)
                    {
                        output += letter.ToLower();
                    }

                    if (i < input.Length - 1)
                    {
                        output += "-";
                    }
                }

                Console.WriteLine(output);
                Console.ReadLine();
            }
        
    }
}
