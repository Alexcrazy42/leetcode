class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        new_list = []

        i = 0 
        j = 0 

        while i < len(nums1) and j < len(nums2):
            if nums1[i] < nums2[j]:
                new_list.append(nums1[i])
                i += 1
            else:
                new_list.append(nums2[j])
                j+= 1 
        
        for i1 in range(i, len(nums1)):
            new_list.append(nums1[i1])

        for j1 in range(j, len(nums2)):
            new_list.append(nums2[j1])


        if len(new_list) % 2 == 1:
            return new_list[len(new_list) // 2]

        else:
            return (new_list[len(new_list)//2] + new_list[len(new_list) // 2 - 1]) / 2



        