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
  public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    // protects against edge cases where lists empty
    // by having this dummy node at the start
    ListNode dummy = new ListNode(-1);

    // start at the dummy head
    ListNode current = dummy;

    // loop through while we still have items and depending on
    // their value, add them to a new linked list
    while (list1 != null && list2 != null)
    {
      // take the lowest or item from list1 if a tie
      if (list1.val <= list2.val)
      {
        current.next = list1;
        // move down the list 1 node
        list1 = list1.next;
      }
      else {
        current.next = list2;
        list2 = list2.next;
      }
      current = current.next;
    }

    // for any remaining nodes, add to end
    if (list1 != null)
    {
      current.next = list1;
    }
    else {
      current.next = list2;
    }

    // return everything after the dummy head
    return dummy.next;
  }
}
