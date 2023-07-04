class Solution:
    def longestPalindrome(self, s: str) -> str:
        
        if not s or len(s) == 1:
            return s 
        LEN = len(s)
        dp = [[False for c in range(LEN)] for r in range(LEN)]
        
        maxlength = 1
        maxsubstring = s[0]
        for i in range(LEN):
            dp[i][i] = True
            
        """
        2 character string -> check if they are palindromes
        start at i and end at i+1
        """
        for i in range(LEN - 1):
            if s[i] == s[i + 1]:
                dp[i][i+1] = True
                maxsubstring = s[i:i+2] #splicing is non-inclusive
         
        for l in range(2, LEN):    
            # you can picture processing diagnally strings of length l + 1
            for i in range(LEN - l): 
                #i is the start index, j is the end index.           
                length = l + 1            
                j = i + l
                
                if dp[i+1][j-1] and s[i] == s[j]:
                    dp[i][j] = True
                   
                    maxlength = length          
                    maxsubstring = s[i:j+1]
                    continue         
        return maxsubstring
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        """
        if len(s) == 1: return s

        arrayPalindromes = []
        for i in range(len(s)):
            string = ""
            for j in range(len(s[i:])):
                string += s[i:][j]
                if string == string[::-1]: 
                    arrayPalindromes.append(string)

        maxLen = 0 
        maxP = ""
        for i in arrayPalindromes:
            if len(i) > maxLen:
                maxLen = len(i)
                maxP = i 
        return maxP
        """

