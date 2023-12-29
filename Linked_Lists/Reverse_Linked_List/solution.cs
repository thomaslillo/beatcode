/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {

        // Recursive Problem !!

        // check if linked list is empty
        // we wont hit this recursively because we stop at head.next == null
        if (head == null)
        {
            return head;
        }

        // set the new head 
        ListNode newListHead = head;

        // if there is a next node, call the function again
        if (head.next != null)
        {            
            // call the function on the new start, so 2
            // this will return a ListNode of everything after 1
            newListHead = ReverseList(head.next);

            // set the new head to the one after the next one
            head.next.next = head;
        }
        // after we set the head.next to null, because it should be the end
        head.next = null;

        return newListHead;
    }
}
