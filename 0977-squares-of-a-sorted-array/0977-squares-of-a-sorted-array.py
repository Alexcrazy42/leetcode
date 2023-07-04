class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        left = 0
        right = len(nums) - 1

        n = []

        while(left <= right):
            left1 = abs(nums[left])
            right1 = abs(nums[right])
            if (left1 < right1):
                n.append(right1 ** 2)
                right -= 1
            else:
                n.append(left1 ** 2)
                left += 1
        
        return reversed(n)
