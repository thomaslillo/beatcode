class Solution:
    def construct2DArray(self, original: List[int], m: int, n: int) -> List[List[int]]:
        
        base_array = []
        
        if (m * n) == len(original):
            
            lower = 0
            upper = 0
            
            num_rows = len(original) // n

            for rows in range(num_rows):
                upper = n + upper
                base_array.append(original[lower:upper])
                lower += n

        return base_array
