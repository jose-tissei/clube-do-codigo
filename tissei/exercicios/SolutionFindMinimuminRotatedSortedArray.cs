using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionDoBixao
    {
        public int FindMin(int[] nums)
        {

            var left = 0;
            var right = nums.Length - 1;
            var result = nums[0];

            while (left <= right)
            {
                if (nums[left] < nums[right])
                {
                    return Math.Min(nums[left], result);
                }

                var mid = (left + right) / 2;
                result = Math.Min(nums[mid], result);

                if (nums[mid] >= nums[left])
                {
                    result = Math.Min(nums[left], result);
                    left = mid + 1;
                }
                else
                {
                    result = Math.Min(nums[right], result);
                    right = mid - 1;
                }

            }

            return result;
        }
    }


    public class SolutionFindMinimuminRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {

            var left = 0;
            var right = nums.Length - 1;
            var mid = right / 2;

            while (left <= right && left != mid)
            {
                if (nums[right] < nums[left] && nums[right] < nums[mid])
                {
                    left = mid;
                    mid = (mid + right) / 2;
                    // Division between two ints uses integer division, which truncates (rounds toward zero)
                }
                else
                {
                    right = mid;
                    mid = (mid + left) / 2;
                }
            }

            return Math.Min(nums[left], nums[right]);
        }
    }
}
