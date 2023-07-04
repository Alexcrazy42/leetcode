class Solution:
    def letterCombinations(self, digits: str) -> List[str]:

        if digits == "":
            return []

        def product(*args, repeat=1):
            pools = [tuple(pool) for pool in args] 
            result = [[]]
            for pool in pools:
                result = [x+[y] for x in result for y in pool]
            for prod in result:
                yield tuple(prod)


        s = {
            2: ["a", "b", "c"],
            3: ["d", "e", "f"],
            4: ["g", "h", "i"],
            5: ["j", "k", "l"],
            6: ["m", "n", "o"],
            7: ["p", "q", "r", "s"],
            8: ["t", "u", "v"],
            9: ["w", "x", "y", "z"],
            0: [" "]
        }

        res = []

        ar = []
        for i in digits:
            ar.append(s[int(i)])

        for i in product(*ar):
            res.append(''.join(j for j in i))
        
        
            

        return res


            

