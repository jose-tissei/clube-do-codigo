#https://neetcode.io/problems/top-k-elements-in-list?list=neetcode150
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = Counter(nums)

        #this is a simplified way of doing:
        # buckets = []
        # for i in range (len(nums) + 1)
        # buckets[i] = []
        buckets = [[] for _ in range(len(nums) + 1)]

        for num, freq in count.items():
            buckets[freq].append(num)

        result = []

        #iterate from last buckets (buckets where frequency is higher) to first buckets
        for i in range(len(buckets) - 1, 0, -1):
            for num in buckets[i]:
                result.append(num)
                if len(result) == k:
                    return result
        
        return result