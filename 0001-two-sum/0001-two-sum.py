class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]: 
        
        for i in nums: 
            nums1 = []
            nums1.extend(nums)
            nums1[nums1.index(i)] = float('INF')
            if target - i in nums1:
                return [nums.index(i), nums1.index(target-i)]
        
        

