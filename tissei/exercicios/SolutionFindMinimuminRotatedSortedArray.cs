using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionFindMinimuminRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {

            var left = 0;
            var right = nums.Length - 1;
            var mid = (int)Math.Floor(right / 2M);

            while (left <= right && left != mid)
            {
                if (nums[right] < nums[left] && nums[right] < nums[mid])
                {
                    left = mid;
                    mid = (int)Math.Floor((mid + right) / 2M);
                }
                else
                {
                    right = mid;
                    mid = (int)Math.Floor((mid + left) / 2M);
                }
            }

            return Math.Min(nums[left], nums[right]);
        }
    }
}
