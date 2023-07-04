public class Solution {
    public int FindMin(int[] nums) 
    {
        if(nums[0] < nums[nums.Length - 1])
        {
            return nums[0];
        }

        int left = 0; 
        int right = nums.Length - 1; 
        int mid = 0;
        
        while(left <= right)
        {
            mid = (left+right)/2;
            if(nums[mid] >= nums[0])
            {
                if(mid != nums.Length -1 )
                {
                    if(nums[mid+1] < nums[mid])
                    {
                        return nums[mid+1];
                    }
                }
                
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return nums[mid];
    }
}