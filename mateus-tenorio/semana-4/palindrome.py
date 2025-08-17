#https://neetcode.io/problems/is-palindrome?list=neetcode150
class Solution:
    def isPalindrome(self, s: str) -> bool:
        first_position = 0
        last_position = len(s) - 1

        while first_position < last_position:
            if not s[first_position].isalnum():
                first_position += 1
                continue
            if not s[last_position].isalnum():
                last_position -= 1
                continue
            
            if s[first_position].lower() != s[last_position].lower():
                return False
            
            first_position += 1
            last_position -= 1
        
        return True
