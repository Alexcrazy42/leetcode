public class Solution {
    public void MoveZeroes(int[] nums) {
        int start = 0; 
        int end = nums.Length - 1;
        int cur = 0;

        while(cur <= end)
        {
            if(nums[cur] != 0)
            {
                (nums[start], nums[cur]) = (nums[cur], nums[start]);
                start++;
            }
            cur++;
        }
        
    }
}