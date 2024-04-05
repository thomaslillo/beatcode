class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        # pointer s slow and f fast
        # if return is negative or lower than max move slow
        # move fast

        if len(prices) == 1:
            return 0

        slow = 0
        fast = 0   
        largest_return = 0 

        while fast < len(prices):            
            product = prices[fast] - prices[slow]
            largest_return = max(largest_return, product)
            if prices[slow] > prices[fast]:
                slow = fast
            fast += 1

        return largest_return
