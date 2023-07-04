class Solution:
    def multiply(self, num1: str, num2: str) -> str:
        nums = {}
        for i in range(10):
            nums[str(i)] = i 
        n1 = []
        n2 = []
        for i in range(0, len(num1)):
            n1.append(num1[len(num1)-1-i])
        for i in range(0, len(num2)):
            n2.append(num2[len(num2)-1-i])

        num1, num2 = 0, 0

        for i in range(len(n1)):
            num1 += int(n1[i]) * 10 ** i

        for i in range(len(n2)):
            num2 += int(n2[i]) * 10 ** i

        print(n1)
        print(n2)
        return str(num1 * num2)



        
