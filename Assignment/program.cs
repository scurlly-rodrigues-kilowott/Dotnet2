using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2.Assignment
{
    public class program
    {
        public static void Start()
        {
            int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int n = a.Length;

            // Function call
            Console.WriteLine("Mean : " + stats.Mean(a, n) );
            Console.WriteLine("Median : " + stats.Median(a, n) );
            Console.WriteLine("Mode : " + stats.Mode(a, n));
        }

        
    }
}
