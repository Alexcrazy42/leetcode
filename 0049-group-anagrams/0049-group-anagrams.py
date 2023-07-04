class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        anagrams = {}

        for i in strs: 
            array = []
            for j in i:
                array.append(j)
            array.sort()
            anagrams[tuple(array)] = []
        
        for i in strs:
            array = []
            for j in i:
                array.append(j)
            array.sort()
            anagrams[tuple(array)].append(i)

        res = []

        for k, v in anagrams.items():
            res.append(v)
        
        return res

