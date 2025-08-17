#https://neetcode.io/problems/longest-consecutive-sequence?list=neetcode150
class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        ht = Counter(nums)
        current_count = 0
        max_count = 0
        for i in range(0, len(nums)):
            if nums[i] - 1 in ht:
                continue
            num_to_find = nums[i]
            while num_to_find in ht:
                current_count += 1
                num_to_find += 1
            
            if current_count > max_count:
                max_count = current_count
            
            current_count = 0
        
        return max_count