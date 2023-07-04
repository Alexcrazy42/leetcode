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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        List<ListNode> l = new List<ListNode>();
        
        while(head!= null)
        {
            l.Add(head);
            head = head.next;
        }

        if(l.Count == 0 || n > l.Count)
        {
            return null;
        }
        if(n == l.Count)
        {
            return l[0].next;
        }

        l[l.Count - n - 1].next = l[l.Count - n].next;
        return l[0];

    }
}