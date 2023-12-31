public class Solution 
{
    public int Search(int[] nums, int target) {
        int left = 0; 
        int right = nums.Length - 1;

        while(left <= right)
        {
            int mid = (left + right) / 2;
            if(nums[mid] == target)
            {
                return mid;
            }
            if(nums[left] <= nums[mid]) // on the left side 
            {
                if(nums[left] <= target && nums[mid] >= target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if(nums[right] >= target && nums[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return -1;
    }
}