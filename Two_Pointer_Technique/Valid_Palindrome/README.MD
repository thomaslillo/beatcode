# Valid Palindrome

need to clean then check a string if there is a valid palindrome
used the two pointer technique to work inwards from each end saving time

did it in O(n)

https://leetcode.com/problems/valid-palindrome/

### Coolest Soluton - using a list and reverse list
```python
class Solution:
    def isPalindrome(self, s: str) -> bool:
        s=[x.lower() for x in s if x.isalnum()]
        return s==s[::-1]
```
I've never seen someone use isalnum() but its so good, you turn it into a list then compare it to the reversed list (s[::-1]), incredible work.
