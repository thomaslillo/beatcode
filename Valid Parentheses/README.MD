## My Stats

Runtime: 61 ms
87%
Memory Usage: 37.9 MB
73%

## BEST ANSWER I SAW

```csharp
public class Solution {
    public bool IsValid(string s) {
         while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        }

        return s.Length == 0;
}}
```
