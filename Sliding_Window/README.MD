# Sliding Window Approach

Using two pointers, a slow and fast, to figure out what section of an array meets some requirement.

https://www.youtube.com/watch?v=nKhteIRZ2Ok

a template for solving a problem where you need to find the longest set of 1s in an array of 1s and 0s but can also swithc K 0s to 1s.

```
# j is the fast pointer, i is the slow one
for (int j = 0; j < nums.length; j++)
{
  if (nums[j] == 0) {
    k--;
  }

  while (k < 0) {
    if (nums[i] == 0) {
      k++;
    }
    i++;
  }
  # could be the already reached result or j - i
  result = Math.max(result, j - i);
}
```
