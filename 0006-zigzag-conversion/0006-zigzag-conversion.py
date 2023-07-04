class Solution:
    def convert(self, s: str, numRows: int) -> str:
        
        if numRows == 1 or numRows >= len(s):
            return s

        lenght = len(s)
        ar = [[] for i in range(numRows)]
        cur = 0

        q = {}

        for i in range(2 * numRows - 2):
            if i >= 0 and i < numRows:
                q[i] = i 
            else:
                q[i] = numRows - 1 - i % (numRows - 1)
            

        for i in range(len(s)):
            ar[q[i%(2 * numRows - 2)]].append(s[i])
            
        res = ""
        for i in ar:
            res += ''.join(j for j in i)
        return res
                    


