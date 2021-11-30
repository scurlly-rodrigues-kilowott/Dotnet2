using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2
{
    internal class Challenge4
    {
        public static void showOutput()
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
        }
    }
}
