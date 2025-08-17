// https://neetcode.io/problems/duplicate-integer?list=neetcode150
namespace clube_codigo_hammer.week_1.contains_duplicate;

public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                if (i != j && nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}