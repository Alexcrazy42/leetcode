class Solution:
    def reverse(self, x: int) -> int:
        flag = False
        s = 0

        string = str(x)
        
        
        if string[0] == "-":
            string = string[1:]
            flag = True
        
        
        
        for i in range(len(string)):
            s += 10 ** i * int(string[i])
        if flag: 
            s *= -1
        if s >= - 2 ** 31 and s <= 2 ** 31 - 1:
            return s
        else: 
            return 0


