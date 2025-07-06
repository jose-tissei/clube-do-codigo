public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            var result = dict.TryAdd(num, 1);
            if (!result) return true;
        }
        return false;
    }
}