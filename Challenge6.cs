﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2
{
    internal class Challenge6
    {
        public static void showOutput()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine(daysUntilExpiration);
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");

            }
            else if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                Console.WriteLine("Your subscription expires within a day!Renew now and save " + discountPercentage + "%!");

            }
            else if (daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                Console.WriteLine("Your subscription expires in " + daysUntilExpiration + " days.Renew now and save " + discountPercentage + "%!");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }


            if (daysUntilExpiration > 10)
            {

            }
        }
    }
}
