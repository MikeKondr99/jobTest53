using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Task1
{
    public class NumberSumFinder
    {

        public bool CanRepresentNumber(IEnumerable<int> numbers, int target)
        {
            HashSet<int> sums = [0];
            foreach(var num in numbers) {
                var found2 = sums.ToArray();
                for (var j = 0; j < found2.Length; j++)
                {
                    sums.Add(found2[j] + num);
                }
                if(sums.Contains(target)) {
                    return true;
                }
            }
            return false;
        }

    }
}