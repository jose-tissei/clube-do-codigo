//https://neetcode.io/problems/three-integer-sum?list=neetcode150
public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) 
        {
            if (i > 0 && nums[i] == nums[i - 1]) 
                continue;
            
            int left = i + 1;
            int right = nums.Length - 1;
            int target = -nums[i];
            
            while (left < right) 
            {
                int currentSum = nums[left] + nums[right];
                
                if (currentSum == target) 
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                    while (left < right && nums[left] == nums[left + 1]) 
                        left++;
                    
                    while (left < right && nums[right] == nums[right - 1]) 
                        right--;
                    
                    left++;
                    right--;
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
        }
        
        return result;
    }
}
