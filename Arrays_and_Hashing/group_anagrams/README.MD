# Group Anagrams - M

https://leetcode.com/problems/group-anagrams

## Results 

Runtime Details:
144ms
Beats 99.45%of users with C#

Memory Details:
74.48MB
Beats 92.71%of users with C#

#### Big O

- Initial Check (if (strs.Count() == 1)): This is a constant time operation, O(1).
- Iterating over each string in strs array: O(N)
- Sorting each string: O(K log K), where K is the length of the longest string. 
- Checking and adding to the dict: O(1) on average.
- Converting Dictionary Values to List: O(N)

Combining these, the overall time complexity of the method is dominated by the foreach loop where strings are sorted and added to the dictionary, resulting in O(N * K log K).

*The space complexity is worth noting as well:*

- Space for the dictionary: At most, this will hold N lists (in the worst case, where no words are anagrams of each other). This is O(N).
- Space for sorted strings: This is also O(N * K) since each word is transformed into a sorted string.

Therefore, the space complexity is O(N * K), considering both the dictionary and the space for sorted strings.

## Best Answer

```CS

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        return strs
            .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
            .Select(g => g.ToList() as IList<string>)
            .ToList();
    }
}
               
```
