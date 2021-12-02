using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet2.Assignment
{
    internal class StatsProcessor
    {
        internal int[] Numbers { private get; set; }

        internal StatsResult GetStatsProcessorResult()
        {
            var result = new StatsResult();
            result.Mean = CalculateAverage();
            result.Median = CalculateMedian();
            result.Mode = CalculateMode();
            return result;
        }

        private int CalculateAverage() => Numbers.Sum() / Numbers.Length;

        private int CalculateMedian()
        {
            var sortedData = Numbers.OrderBy(i => i).ToArray();
            var n = sortedData.Length;
            var median = n % 2 == 0
                ? (sortedData[n / 2 - 1] + sortedData[n / 2]) / 2
                : sortedData[n / 2];
            return median;
        }

        private int CalculateMode()
        {
            int n = Numbers.Length;
            // stores max value of input array
            int max = Numbers.Max();

            
            int t = max + 1;
            int[] count = new int[t];
            for (int i = 0; i < t; i++)
                count[i] = 0;

            // Stores count of each element of input array
            for (int i = 0; i < n; i++)
                count[Numbers[i]]++;

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
