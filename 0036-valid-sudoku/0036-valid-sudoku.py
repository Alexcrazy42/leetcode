class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:

        def NormalRows(board):
            
            for i in board:
                array = []
                for j in i:
                    if j != ".":
                        if j in array:
                            return False
                        array.append(j)

            return True
        
        def NormalColumns(board):
            for i in range(len(board[0])):
                array = []
                for j in range(len(board)):

                    
                    if board[j][i] != ".":
                        if board[j][i] in array:
                            return False
                        
                        array.append(board[j][i])
            return True 
        
        def NormalSquares(board):
            squares = {
                (0, 0) : [],
                (0, 1) : [],
                (0, 2) : [],
                (1, 0) : [],
                (1, 1) : [],
                (1, 2) : [],
                (2, 0) : [],
                (2, 1) : [],
                (2, 2) : []
            }
            for rows in range(len(board)):
                for columns in range(len(board[rows])):
                    if board[rows][columns] != ".":
                        if board[rows][columns] in squares[(rows // 3, columns // 3)]:
                            return False
                        squares[(rows // 3, columns // 3)].append(board[rows][columns])
            return True
    

        if NormalRows(board) and NormalColumns(board) and NormalSquares(board):
            return True 
            
        else: 
            return False


                    


