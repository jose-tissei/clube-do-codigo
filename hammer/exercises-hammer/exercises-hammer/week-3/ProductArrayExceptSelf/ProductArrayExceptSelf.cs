namespace exercises_hammer.week_3;

// https://neetcode.io/problems/products-of-array-discluding-self?list=neetcode150
public class ProductArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        
        prefix[0] = 1;
        suffix[nums.Length - 1] = 1;
        
        for (var i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i + 1];
        }

        var answer =  new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix[i] * suffix[i];
        }
        
        return answer;
    }
}