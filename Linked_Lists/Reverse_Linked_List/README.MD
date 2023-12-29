# Reverse Linked List

- A foundation for other problems
- example of a recursive solution to a problem
- can also be done iteratively

the problem:
https://leetcode.com/problems/reverse-linked-list

learning explainer:
https://www.youtube.com/watch?v=G0_I-ZF0S38

## Clear Example with Python

The time complexity is O(N) for the number of nodes in the list, same with space.

```python

def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
    
    if not head :
        return None

    newHead = head
    if head.next :
        newHead = self.reverseList(head.next)
        head.next.next = head
    head.next = None    

    return newHead    

```

### Breakdown of How The Code Works

Input: 1 -> 2 -> 3 -> 4 -> 5

**First call (head=1):**

  - head != NULL, so it goes into the recursion.
  - Recursively calls reverseList(2).

**Second call (head=2):**

  - head != NULL, so it goes into the recursion.
  - Recursively calls reverseList(3).

**Third call (head=3):**

  - head != NULL, so it goes into the recursion.
  - Recursively calls reverseList(4).

**Fourth call (head=4):**

  - head != NULL, so it goes into the recursion.
  - Recursively calls reverseList(5).

**Fifth call (head=5):**

  - head != NULL, but there is no next node (head->next == NULL), so it returns 5 itself.

**Back to the fourth call (head=4):**

  - Now, newHead is 5.
  - head->next->next points to 4 (which is 5->4 now).
  - head->next is set to NULL (making 4->NULL).
  - newHead (which is 5) is returned to the third call.
  
**Back to the third call (head=3):**

  - Now, newHead is 5.
  - head->next->next points to 3 (which is 4->3->NULL now).
  - head->next is set to NULL (making 3->NULL).
  - newHead (which is 5) is returned to the second call.

**Back to the second call (head=2):**

  - Now, newHead is 5.
  - head->next->next points to 2 (which is 3->2->NULL now).
  - head->next is set to NULL (making 2->NULL).
  - newHead (which is 5) is returned to the first call.

**Back to the first call (head=1):**

  - Now, newHead is 5.
  - head->next->next points to 1 (which is 2->1->NULL now).
  - head->next is set to NULL (making 1->NULL).
  - newHead (which is 5) is returned as the new head of the reversed list.


