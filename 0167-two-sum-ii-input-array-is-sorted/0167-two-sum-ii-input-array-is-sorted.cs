public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length -1;

        while (left < right)
        {
            if(numbers[left] + numbers[right] == target)
            {
                return new int[2] {left + 1, right + 1};
            }
            else if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
            else 
            {
                left ++;
            }
        }

        return new int[] {1, 1};

    }
}