class Solution:
    def majorityElement(self, nums: List[int]) -> List[int]:
        def Count(array, elem):
            count = 0 
            for i in array:
                if i == elem:
                    count += 1 
            return count 
        
        nums1 = list(set(nums))
        n = []
        for i in nums1:
            if Count(nums, i) > len(nums) // 3:
                n.append(i)

        return n