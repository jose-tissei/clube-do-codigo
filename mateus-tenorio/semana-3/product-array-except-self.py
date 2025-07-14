#https://neetcode.io/problems/products-of-array-discluding-self?list=neetcode150
class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        list_size = len(nums)
        prefix = [1] * list_size
        suffix = [1] * list_size
        result = [0] * list_size

        #The prefix and suffix approach works like this:
        #Example : [1, 2, 3, 4]

        for i in range (1, list_size):
            prefix[i] = prefix[i - 1] * nums[i - 1]
        #Prefix : [1, 1, 2, 6]
        #Suffix : [1, 1, 1, 1]

        for j in range (list_size - 2, -1, -1):
            suffix[j] = suffix[j + 1] * nums[j + 1]
        #Prefix : [1, 1, 2, 6]
        #Suffix : [24, 12, 4, 1]

        for i in range (0, list_size):
            result[i] = suffix[i] * prefix[i]
        #Result = [24, 12, 8, 6]

        return result
