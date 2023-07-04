public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxH = 0;


        while (left <= right) 
        {
            int area = Math.Min(height[left], height[right]) * (right - left);
            maxH = Math.Max(area, maxH);
            if (height[left] > height[right])
            {
                right--;
            }
            else 
            {
                left++;
            }
        }
        return maxH;
    }
}