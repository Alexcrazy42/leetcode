public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        int target = 0; 
        Array.Sort(nums);

        //List<IList<int>> res1 = new List<IList<int>>();
        HashSet<IList<int>> res = new HashSet<IList<int>>(); 

        for(int i=0; i < nums.Length; i++)
        {
            int j = i+1; 
            int k = nums.Length-1; 

            while(j < k)
            {
                int sum = nums[i]+nums[j]+nums[k];
                if(sum == target)
                {
                    AddIfNotContain(new List<int>() {nums[i], nums[j], nums[k]}, res);
                    j++;
                    k--;
                }
                else if(sum < target)
                {
                    j++;
                }
                else
                {
                    k--;
                }
            }
        }

        return res.Distinct().ToList();
    }

    public bool AddIfNotContain(List<int> l, HashSet<IList<int>> n)
    {
        foreach(List<int> l1 in n)
        {
            if(l[0] == l1[0] && l[1] == l1[1] && l[2] == l1[2])
            {
                return false;
            }
        }
        n.Add(l);
        return true;
    }
}