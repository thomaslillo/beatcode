# Single Number

https://leetcode.com/problems/single-number

- I used a dict and had O(N) because I loop through the array only once ever

## Best Solution

this absolute chad used a HashSet in C# and then summed this up, multiplied by two, then summed up the original array, and got the diff between the expected and the actual, which is the only value without a double.

very fast, very clean, amazing

```csharp
  public int SingleNumber(int[] nums) {
      return new HashSet<int>(nums).ToArray().Sum() * 2 - nums.Sum();
  }
```
