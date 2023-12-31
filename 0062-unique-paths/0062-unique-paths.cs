public class Solution {
    public int UniquePaths(int m, int n) {
        if(n == 1)
        {
            return 1;
        }
        if(m==1)
        {
            return 1;
        }
        int[,] res = new int[m,n];
        res[m-1, n-1] = 1;
        for(int i=0; i < n; i++)
        {
            res[m-1, i] = 1;
        }
        for(int i=0; i < m; i++)
        {
            res[i, n-1] = 1;
        }
        for(int i=m-2; i >= 0; i--)
        {
            for(int j=n-2; j >= 0; j--)
            {
                res[i, j] = res[i+1, j] + res[i, j+1]; 
            }
        }

        return res[0, 0];
        
    }
}