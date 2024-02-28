def search(self, nums: List[int], target: int) -> int:        
    # search function
    def binary_search(nums, target, low, high):
        if low <= high:
            mid = (low + high) // 2
            if nums[mid] == target:
                return mid
            elif nums[mid] < target:
                return binary_search(nums, target, mid + 1, high)
            else:
                return binary_search(nums, target, low, mid - 1)
        else:
            return -1
    
    return binary_search(nums, target, 0, len(nums) - 1)
