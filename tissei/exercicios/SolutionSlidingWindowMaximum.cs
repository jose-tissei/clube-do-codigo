using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionSlidingWindowMaximum
    {
        public int[] MaxSlidingWindow2(int[] nums, int k)
        {
            var result = new List<int>();
            var q = new LinkedList<int>();
            var i = 0;

            while (i < nums.Length)
            {
                if (q.Count != 0 && q.First() <= i - k)
                {
                    q.RemoveFirst();
                }

                while (q.Count != 0 && nums[q.Last()] <= nums[i])
                {
                    q.RemoveLast();
                }

                q.AddLast(i);

                if (i >= k - 1)
                {
                    result.Add(nums[q.First()]);
                }

                i++;
            }

            return result.ToArray();
        }

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
