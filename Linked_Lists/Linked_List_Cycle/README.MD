# Linked List Cycle

https://leetcode.com/problems/linked-list-cycle/

- used a hashset to check if I had seen a node before and just iterated through till I found one, otherwise said there were no links
- O(n) which isn't too bad but I have to store a lot of nodes

## Best Solutions

Two-Pointers Method (Floyd's Cycle-Finding Algorithm):
Also known as the "hare and tortoise" algorithm, this method employs two pointers that move at different speeds. If there is a cycle, the fast pointer will eventually catch up to the slow pointer, confirming the cycle's existence.

```cs
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        var fast = head;
        var slow = head;

        while(slow != null && fast != null)
        {
            slow = slow.next;
            fast = fast.next?.next;
            if (slow == fast)
                return slow != null;
        }

        return false;
    }
}
```
Explainer vid

https://www.youtube.com/watch?v=PvrxZaH_eZ4
