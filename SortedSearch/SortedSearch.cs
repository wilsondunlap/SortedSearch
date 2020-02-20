using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSearch
{
    internal class SortedSearch
    {
        static internal int CountNumbersLessThan(int[] sortedNumbers, int lessThan)
        {
            if(sortedNumbers.Length == 0) 
            {
                return 0;
            }

            if(sortedNumbers[0] >= lessThan)
            {
                return 0;
            }

            if(sortedNumbers.Last() < lessThan)
            {
                return sortedNumbers.Length;
            }

            return ConductBinarySearch(sortedNumbers, lessThan, 0, sortedNumbers.Length - 1);
        }

        static internal int ConductBinarySearch(int[] sortedNumbers, int max, int lowerBound, int upperBound)
        {
            int i = Convert.ToInt32(Math.Floor(((decimal)lowerBound + (decimal)upperBound) / 2));

            if(max > sortedNumbers[i] &&
                (i == sortedNumbers.Length - 1 ||  max <= sortedNumbers[i + 1])
            )
            {
                return i + 1;
            }

            if(max <= sortedNumbers[i] && i > 0 && max > sortedNumbers[i - 1])
            {
                return i;
            }

            //i is the lower bound
            if(max > sortedNumbers[i])
            {
                return ConductBinarySearch(sortedNumbers, max, i, upperBound);
            }

            //i is the upper bound
            return ConductBinarySearch(sortedNumbers, max, lowerBound, i);
        }
}
}
