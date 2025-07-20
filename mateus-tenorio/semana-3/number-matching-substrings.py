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

#Time exceeded
from collections import deque

class Solution:
    def numMatchingSubseq(self, s: str, words: List[str]) -> int:
        ht_chars_positions = {}
        result = 0
        for pos, char in enumerate(s):
            if char not in ht_chars_positions:
                ht_chars_positions[char] = deque()
            ht_chars_positions[char].append(pos)

        for word in words:
            if self.checkSubsequence(word, ht_chars_positions):
                result += 1

        return result

    def checkSubsequence(self, word: str, char_positions: dict) -> bool:
        char_indices = {}
        curr_pos = 0

        for char in word:
            if char not in char_positions:
                return False
            if char not in char_indices:
                char_indices[char] = 0
            
            positions = char_positions[char]
            available_indices = len(positions)
            while (char_indices[char] < available_indices and 
                   positions[char_indices[char]] < curr_pos):
                char_indices[char] += 1
            
            if char_indices[char] >= available_indices:
                return False
            
            curr_pos = positions[char_indices[char]] + 1
            char_indices[char] += 1
        
        return True

#Working one using binary search
import bisect

class Solution:
    def numMatchingSubseq(self, s: str, words: List[str]) -> int:
        char_positions = defaultdict(list)
        for i in range(len(s)):
            char_positions[s[i]].append(i)

        result = 0
        for word in words:
            if self.isSubsequence(word, char_positions):
                result += 1

        return result

    def isSubsequence(self, word: str, char_positions: dict) -> bool:
        prev_char = word[0]
        if prev_char not in char_positions:
            return False
        prev_char_index = char_positions[prev_char][0]

        for i in range(1, len(word)):
            curr_char = word[i]
            if curr_char not in char_positions:
                return False
            
            positions = char_positions[curr_char]
            curr_char_index = bisect.bisect_right(positions, prev_char_index)

            if curr_char_index >= len(positions):
                return False
            
            prev_char_index = positions[curr_char_index]
        
        return True