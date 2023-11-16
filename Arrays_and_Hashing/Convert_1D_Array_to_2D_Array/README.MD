https://leetcode.com/problems/convert-1d-array-into-2d-array/

had a slow runtime compared to the average so I should improve my approach to this one

# best solution

```python
def construct2DArray(self, original: List[int], m: int, n: int) -> List[List[int]]:
    if (m*n) != len(original):
        return list()
    matrix = list()      
    for i in range(m):
        matrix.append(original[i*n:(i*n)+n])
    return matrix
```
