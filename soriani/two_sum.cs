public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            dic[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            var difference = target - nums[i];
            if (dic.ContainsKey(difference))
            {
                return new int[] {i, dic[difference]};
            }
        }
        return new int[0];
    }
}
