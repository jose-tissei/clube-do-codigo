#https://neetcode.io/problems/string-encode-and-decode?list=neetcode150
class Solution:

    def encode(self, strs: List[str]) -> str:
        result = ''
        for word in strs:
            word_length = len(word)
            result += f"{word_length}#{word}"
        return result

    def decode(self, s: str) -> List[str]:
        total_size = len(s)
        current_index = 0
        word_list = []
        while current_index < total_size:
            word_length = ''
            while s[current_index] != '#':
                word_length += s[current_index]
                current_index += 1
            current_index += 1
            word_length = int(word_length)
            current_word = ''
            for i in range (current_index, current_index + word_length):
                current_word += s[i]
            word_list.append(current_word)
            current_index += word_length
        return word_list
