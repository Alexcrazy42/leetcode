class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:




        
        maxValue = 0
        for i in range(len(s)):
            array = []
            for j in range(len(s[i:])):
                if s[i:][j] not in array:
                    array.append(s[i:][j])
                    maxValue = len(array) if len(array) > maxValue else maxValue
                else:
                    maxValue = len(array) if len(array) > maxValue else maxValue
                    break
        return maxValue
    
                