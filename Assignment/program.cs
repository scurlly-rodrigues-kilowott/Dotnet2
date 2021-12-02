using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2.Assignment
{
    public class Prog
    {
       static int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        public static void Start()
        {
            var object1 = new StatsProcessor();

            object1.Numbers = a;
            
           

            // Function call

            var result  = object1.GetStatsProcessorResult();
            
            

            
            Console.WriteLine($"Mean : {result.Mean}");
            Console.WriteLine($"Median : {result.Median}");
            Console.WriteLine($"Mode : {result.Mode}");
        }

        
    }
}
