public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix[0].Length;

        
        int left = 0; 
        int right = rows * columns - 1;
        while(left <= right)
        {
            int mid = (left + right) / 2;
            int cur = matrix[mid / columns][mid % columns];
            if(cur == target)
            {
                return true;
            }
            else if (cur > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return false;
    }
}