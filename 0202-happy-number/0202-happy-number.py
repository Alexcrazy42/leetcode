class Solution:
    def isHappy(self, n: int) -> bool:
        
        n1 = n
        history = [n]
        while True: 
            ranks = []
            while n1 != 0:
                ranks.append(n1%10)
                n1 //= 10 
            n1 = sum(list(map(lambda x: x**2, ranks)))
            if n1 == 1:
                return True
            if n1 in history: 
                return False
            history.append(n1)
            
            
            
