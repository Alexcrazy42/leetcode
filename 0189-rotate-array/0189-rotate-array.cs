public class Solution {
    public void Rotate(int[] nums, int k) 
    {
        int[] nums1 = new int[nums.Length];
        Array.Copy(nums, nums1, nums.Length);
        int count = nums.Length;
        for(int i = 0; i < count; i++)
        {
            nums[(i+k)%count] = nums1[i];
        }
        

    }
}