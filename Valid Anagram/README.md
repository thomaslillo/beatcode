## My Stats

Runtime: 57 ms
41%
Memory Usage: 14.5 MB

## Best Solution I Saw

```python
class Solution:
    def isAnagram(self, s: str, t: str) -> bool:

        for i in range(min(len(t),len(s))):
            if len(s) == 1 and s[i] == t[i] and len(t) == 1 :
                return True
            elif  s[i] != t[i] :
               s = sorted(s)
               t = sorted(t)
               if s == t :
                   return True             
```
