class Solution:
    def romanToInt(self, s: str) -> int:
        def getKeyByValue(value, a):
            for k, v in a.items():
                if a.get(k) == value:
                    return k
            return 0
        
        
        a = {
            1: "I", 
            5: "V", 
            10: "X", 
            50: "L", 
            100: "C", 
            500: "D", 
            1000: "M"
        }

        res = 0
        prev = 0
        for i in range(len(s)-1, -1, -1):
            cur = getKeyByValue(s[i], a)
            if cur < prev:
                res -= cur 

            else:
                res += cur
            prev = cur


        
        return res