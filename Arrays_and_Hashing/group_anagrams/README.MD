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

To determine the Big O notation of this code, lets analyze its major components:

Initial Check (if (strs.Count() == 1)): This is a constant time operation, O(1).

Dictionary Creation and Population:
    Iterating over each string in strs array: This is O(N), where N is the number of strings in the array.
    Sorting each string: The time complexity of sorting each string is O(K log K), where K is the length of the longest string. This is because Array.Sort uses an O(n log n) sorting algorithm.
    Checking and adding to the dictionary: Checking if a key exists in a dictionary is O(1) on average. Adding a new key-value pair is also O(1) on average.
    Therefore, the total time complexity for this part is O(N * K log K).

Converting Dictionary Values to List: Converting the values of the dictionary to a list is O(N), as it iterates over all the values once.

Combining these, the overall time complexity of the method is dominated by the foreach loop where strings are sorted and added to the dictionary, resulting in O(N * K log K).

The space complexity is worth noting as well:

    Space for the dictionary: At most, this will hold N lists (in the worst case, where no words are anagrams of each other). This is O(N).
    Space for sorted strings: This is also O(N * K) since each word is transformed into a sorted string.

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
