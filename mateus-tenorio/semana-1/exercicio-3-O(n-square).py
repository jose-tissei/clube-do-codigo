#https://neetcode.io/problems/two-integer-sum?list=neetcode150
# O(n^2) in time complexity and O(1) in space
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in range (len(nums)):
            for j in range (i + 1, len(nums)):
                if nums[i] + nums[j] == target:
                    return [i, j]