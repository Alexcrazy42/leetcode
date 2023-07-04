public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int res = Int32.MaxValue;

        Array.Sort(nums);

        for(int i=0; i < nums.Length; i++)
        {
            int j = i+1;
            int k = nums.Length-1; 

            
            while(j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];
                if(sum == target)
                {
                    return target;
                }
                else if (sum > target)
                {
                    
                    if(Math.Abs(sum - target) < Math.Abs(res - target)){
                        res = sum;
                    }
                    k--;
                }
                else
                {
                    if(Math.Abs(sum - target) < Math.Abs(res - target)){
                        res = sum;
                    }
                    j++;
                }
            }
            

        }

        return res;
    }
}