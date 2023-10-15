using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
    class Triagular
    {
        public void TriangularDisplay()
        {


           
            int v = 3;
            int k = v;
            for (int i = 1; i <= k; i++)
            {
                for (int j = 1; j < v; j++)
                {
                    Console.Write(" ");
                }
                v = v - 1;
                for (int t = 1; t < i * 2; t++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

    
    }
}
