public class Solution {
    public int FindPeakElement(int[] nums) 
    {
        int n = nums.Length - 1;
        int l = 0; 
        int r = n;

        while(l < r)
        {
            int m = (l+r)/2;

            if(nums[m] > nums[m+1])
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }

        }
        return l;
    }
}