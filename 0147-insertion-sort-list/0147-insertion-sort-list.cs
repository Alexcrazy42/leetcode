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
    public ListNode InsertionSortList(ListNode head) {
        if(head == null || head.next == null)
        {
            return head;
        }

        ListNode sl = null; 
        ListNode clone = head;
        
        while(clone != null)
        {
            if(sl == null || clone.val < sl.val)
            {
                ListNode t = new ListNode(clone.val, sl);
                sl = t;
            }
            else
            {
                ListNode cur = sl;
                while(cur.next != null && cur.next.val < clone.val)
                {
                
                    cur = cur.next;
                }
                ListNode t = new ListNode(clone.val, cur.next);
                cur.next = t;
            }
            clone = clone.next;
        }
        return sl;
    }

    
}