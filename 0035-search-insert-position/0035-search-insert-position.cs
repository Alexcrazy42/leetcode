public class Solution {
    public int SearchInsert(int[] nums, int target) 
    {
        int left = 0; 
        int right = nums.Length;
        int mid = 0;

        while (left < right)
        {
            mid = (left + right) / 2;
            

            if (nums[mid] < target)
            {
                left = mid + 1;
            }

            else 
            {
                right = mid;
            }

            
        }
        return left;
    }
}