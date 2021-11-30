using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2
{
    internal class Challenge2
    {
        public static void showOutput()
        {
            string name = "Ben";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" new messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");
        }
    }
}
