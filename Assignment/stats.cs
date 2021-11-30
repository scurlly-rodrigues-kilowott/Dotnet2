using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2.Assignment
{
    internal class stats
    {
        public static double Mean(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];

            return (double)sum / (double)n;
        }

        public static double Median(int[] a, int n)
        {
           // Checks if input array has even or odd number of elements
            if (n % 2 != 0)
                return (double)a[n / 2];

            // Gets position of the median
            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;
        }

        public static int Mode(int[] a, int n)
        {
            // stores max value of input array
            int max = a.Max();

            
            int t = max + 1;
            int[] count = new int[t];
            for (int i = 0; i < t; i++)
                count[i] = 0;

            // Stores count of each element of input array
            for (int i = 0; i < n; i++)
                count[a[i]]++;

            // mode is the index with maximum count
            int mode = 0;
            int k = count[0];
            for (int i = 1; i < t; i++)
            {
                if (count[i] > k)
                {
                    k = count[i];
                    mode = i;
                }
            }

            return mode;
            
        }
    }
}
