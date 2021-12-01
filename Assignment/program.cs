using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2.Assignment
{
    public class program
    {
       static int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        public static void Start()
        {
            var object1 = new stats();

            object1.Numbers = a;
            
           

            // Function call

            var sum  = object1.CalculateSum();
            var mean = object1.Mean();
            var mode = object1.Mode();
            var median = object1.Median();
            

            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Mean : {mean}");
            Console.WriteLine($"Median : {median}");
            Console.WriteLine($"Mode : {mode}");
        }

        
    }
}
