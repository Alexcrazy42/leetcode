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
    public ListNode DeleteDuplicates(ListNode head) 
    {
        var prev = new ListNode(next: head);
        head = prev;
        var cur = head.next;
        bool remove = false;

        while(cur != null)
        {
            if(cur.val == cur.next?.val)
            {
                prev.next = cur.next;
                remove = true;
            }
            else if (remove)
            {
                prev.next = cur.next;
                remove = false;
            }
            else
            {
                prev = cur;
            }
            cur = cur.next;

        }
        return head.next;
    }
}
