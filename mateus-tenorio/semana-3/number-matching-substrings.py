#https://leetcode.com/problems/number-of-matching-subsequences/
# Time limited exceeded
from collections import deque
import copy

class Solution:
    def numMatchingSubseq(self, s: str, words: List[str]) -> int:
        ht_chars_positions = {}
        result = 0
        for pos, char in enumerate(s):
            if char not in ht_chars_positions:
                ht_chars_positions[char] = deque()
            ht_chars_positions[char].append(pos)

        for word in words:
            if self.checkSubsequence(word, copy.deepcopy(ht_chars_positions)):
                result += 1

        return result

    def checkSubsequence(self, word: str, ht_chars_positions: dict) -> bool:
        curr_index_to_search = 0  # Fixed variable name
        for char in word:
            if char in ht_chars_positions:
                result = self.checkPosition(curr_index_to_search, ht_chars_positions[char])
                if result != -1:
                    curr_index_to_search = result 
                    if len(ht_chars_positions[char]) == 0:
                        del ht_chars_positions[char]
                else:
                    return False
            else:
                return False
        return True

    def checkPosition(self, index: int, positions: deque) -> int:
        while positions:
            pos = positions[0]
            if index <= pos:
                next_index = pos + 1
                positions.popleft()
                return next_index
            else:
                positions.popleft()
        return -1