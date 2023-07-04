public class Solution {
    public int FindJudge(int n, int[][] trust) {
        
        Dictionary<int, List<int>> a = new Dictionary<int, List<int>>();
        Dictionary<int, List<int>> b = new Dictionary<int, List<int>>();
        
        for(int i=0; i<n; i++)
        {
            a[i+1] = new List<int>();
            b[i+1] = new List<int>();
        }

        foreach(int[] i in trust)
        {
            a[i[0]].Add(i[1]);
            b[i[1]].Add(i[0]);
        }

        for(int i=0; i<n; i++)
        {
            if(a[i+1].Count == 0 && b[i+1].Count == n-1)
            {
                return i+1;
            }
        }

        return -1;
    }
}