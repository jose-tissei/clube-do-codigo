#https://neetcode.io/problems/anagram-groups?list=neetcode150
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        groupedAnagrams = []
        anagramsDict = {}
        for word in strs:
            charCount = [0] * 26
            for char in word:
                charCount[ord(char) - ord('a')] += 1
            
            hashedValue = tuple(charCount)
            
            if hashedValue in anagramsDict:
                anagramsDict[hashedValue].append(word)
            else:
                anagramsDict[hashedValue] = []
                anagramsDict[hashedValue].append(word)
        
        for value in anagramsDict.values():
            groupedAnagrams.append(value)

        return groupedAnagrams