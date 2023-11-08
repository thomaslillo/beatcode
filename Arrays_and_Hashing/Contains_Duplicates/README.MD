# Contains Duplicates

used a set to answer question

https://leetcode.com/problems/contains-duplicate/

Runtime: 701 ms
Memory Usage: 28.8 MB

Best solution I saw:

```python
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        check = set(nums)
        return len(check) != len(nums)
```
