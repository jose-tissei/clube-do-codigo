#https://neetcode.io/problems/two-integer-sum?list=neetcode150
# O(n) in space and time complexity
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        number_to_index = {}

        for i, num in enumerate(nums):
            needed_number = target - num

            if needed_number in number_to_index:
                previous_index = number_to_index[needed_number]
                return [previous_index, i]

            number_to_index[num] = i

        return []
