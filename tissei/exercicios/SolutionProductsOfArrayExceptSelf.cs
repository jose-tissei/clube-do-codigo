using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionProductsOfArrayExceptSelf
    {
        //public int[] ProductExceptSelf(int[] nums)
        //{
        //    var output = Enumerable.Repeat(1, nums.Length).ToArray();
        //    for (var i = 0; i < nums.Length; i++)
        //    {
        //        for (var j = 0; j < nums.Length; j++)
        //        {
        //            if (i == j) continue;

        //            output[i] = output[i] * nums[j];
        //        }
        //    }

        //    return output;
        //}

        public int[] ProductExceptSelf(int[] nums)
        {
            var output = new int[nums.Length];
            var prefix = 1;
            var suffix = 1;

            for(var i = 0; i < nums.Length;  i++)
            {
                output[i] = prefix;
                prefix *= nums[i];
            }

            for(var i = nums.Length - 1; i >= 0; i--)
            {
                output[i] = output[i] * suffix;
                suffix *= nums[i];
            }

            return output;

        }
    }
}
