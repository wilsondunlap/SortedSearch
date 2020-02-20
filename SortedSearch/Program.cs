using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int count = SortedSearch.CountNumbersLessThan(
                new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110 } , 15);
        }
    }
}
