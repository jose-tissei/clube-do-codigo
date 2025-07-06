public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i <= nums.Length; i++)
        {
            for(int y = 1; y < nums.Length; y++)
            {
                if((nums[i] + nums[y]) == target && i != y) return new [] { i , y};
            }
        }
        return null;
    }
}
