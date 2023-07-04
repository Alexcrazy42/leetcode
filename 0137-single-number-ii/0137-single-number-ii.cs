public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> a = new Dictionary<int, int>();
        for(int i=0; i < nums.Length; i++)
        {
            if(a.ContainsKey(nums[i]) == false)
            {
                a[nums[i]] = 1;
            }
            else
            {
                a[nums[i]] += 1;
            }
        }

        foreach(var i in a)
        {
            if(i.Value == 1)
            {
                return i.Key;
            }
        }
        return -1;
    }
}