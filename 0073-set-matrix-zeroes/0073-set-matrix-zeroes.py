class Solution:
    def setZeroes(self, matrix: List[List[int]]) -> None:
        """
        Do not return anything, modify matrix in-place instead.
        """

        zero_r = set()
        zero_c = set()


        def SetColumnZero(c, matrix1):
            for i in range(len(matrix1)):
                matrix1[i][c] = 0

        def SetRowZero(r, matrix1):
            for i in range(len(matrix1[r])):
                matrix1[r][i] = 0            


        for i in range(len(matrix)):
            for j in range(len(matrix[i])):
                if matrix[i][j] == 0:
                    zero_c.add(j)
                    zero_r.add(i)

        for i in zero_r:
            SetRowZero(i, matrix)
        for i in zero_c:
            SetColumnZero(i, matrix)
        
        
                
