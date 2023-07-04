class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        

        

        def canEat(speed):
            time = 0
            for i in piles:
                time += ((i+speed-1) // speed)
            return time <= h


        left = 1 
        right = max(piles)

        while left < right:

            mid = (left + right) // 2 

            if canEat(mid):
                right = mid 
            else:
                left = mid + 1 
        return left
        
        



        