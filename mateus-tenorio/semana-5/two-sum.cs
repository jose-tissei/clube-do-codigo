//https://neetcode.io/problems/two-integer-sum-ii?list=neetcode150
//typical solution
public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numIndexMap.ContainsKey(complement))
            {
                return new int[] { nums[numIndexMap[complement]], nums[i] };
            }

            numIndexMap[nums[i]] = i;
        }

        return new int[0]; 
    }
}

//because array is already sorted
public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int currentSum = nums[left] + nums[right];

            if (currentSum == target)
            {
                return new int[] { nums[left], nums[right] };
            }
            else if (currentSum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return new int[0];
    }
}
