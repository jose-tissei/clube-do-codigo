using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionSlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var result = new int[nums.Length - k + 1];
            var i = 0;
            do
            {
                var slides = 0;
                var max = nums[i + slides];
                do
                {
                    max = Math.Max(max, nums[i + slides]);
                    slides++;
                } while (slides < k && i + slides < nums.Length);
                result[i] = max;
                i++;
            } while (i + k <= nums.Length);

            return result;
        }
    }

}
