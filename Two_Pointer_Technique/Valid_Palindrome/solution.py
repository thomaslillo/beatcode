class Solution:
    def isPalindrome(self, s: str) -> bool:
        """ 
        USING THE TWO POINTER TECHNIQUE
        
        > get the length of the string and divide by 2
        > odd numbers are fine because the middle letter should be the same
        > have two pointers work in towards eachother
        > check each time if they match, if they don't it ain't a palindrome
        > once they cross, if the fail condition has not been hit, we found a palindrome
        """
        # clean input
        cs = (re.sub("[^A-Za-z0-9]","",s)).upper()
        # early exits
        if (len(cs) == 1):
            return True
        if (len(cs) <= 3 and len(cs) >= 1):
            if (cs[0] == cs[-1]):
                return True
        # full and half len
        slen = len(cs)
        # starts
        p1 = 0
        p2 = slen-1
        # loop
        while (p1 < slen//2):
            if (cs[p1] != cs[p2]):
                return False
            p1 += 1
            p2 -= 1
        # else
        return True
