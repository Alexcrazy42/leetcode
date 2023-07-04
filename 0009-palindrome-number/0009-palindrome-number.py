class Solution:

    def isPalindrome(self, x: int) -> bool:
        string = str(x)
        string1 = string[::-1]
        if string == string1: 
            return True
        else: 
            return False
        