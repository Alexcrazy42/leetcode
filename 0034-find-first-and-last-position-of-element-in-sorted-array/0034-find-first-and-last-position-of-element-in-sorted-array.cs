public class Solution {
    public int[] SearchRange(int[] nums, int target) 
    {
        int GetLastIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length -1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if(nums[mid] == target)
                {
                    if(mid != nums.Length - 1)
                    {
                        if(nums[mid+1] != target)
                        {
                            return mid;
                        }
                        else
                        {
                            left = mid+1;
                        }
                    }
                    else
                    {
                        return mid;
                    }
                }
                else if(nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left += 1;
                }
            }
            return -1;
        }

        int GetStartIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length -1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if(nums[mid] == target)
                {
                    if(mid != 0)
                    {
                        if(nums[mid-1] != target)
                        {
                            return mid;
                        }
                        else
                        {
                            right = mid - 1;
                        }
                    }
                    else
                    {
                        return mid;
                    }
                }
                else if(nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left += 1;
                }
            }
            return -1;
        }

        return new int[] {GetStartIndex(nums, target), GetLastIndex(nums, target)};
    }
}