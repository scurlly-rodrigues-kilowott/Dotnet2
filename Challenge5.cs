using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2
{
    internal class Challenge5
    {
        public static void showOutput()
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine("The larger value is " + largerValue);
        }
    }
}
