// https://neetcode.io/problems/two-integer-sum?list=neetcode150
namespace clube_codigo_ha__er.week_1.two_sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                if (i != j && nums[i] + nums[j] == target)
                {
                    return new int[2] { i, j };
                }
            }
        }
        return new int[0];
    }
}