using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionLongestConsecutive
    {
        public int LongestConsecutive(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);
            var longest = 0;

            foreach (var num in nums)
            {
                if (hashSet.Contains(num - 1)) continue;

                var counter = 1;

                while (hashSet.Contains(num + counter)) counter++;

                longest = Math.Max(longest, counter);
            }

            return longest;
        }
    }
}
