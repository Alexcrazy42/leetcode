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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode res = new ListNode(); 
        ListNode tail = res;
        ListNode cur1 = list1; 
        ListNode cur2 = list2; 

        while(cur1 != null && cur2 != null)
        {
            if(cur1.val <= cur2.val)
            {
                tail.next = cur1;
                cur1 = cur1.next;
            }
            else
            {
                tail.next = cur2;
                cur2 = cur2.next;
            }

            tail = tail.next;
        }

        tail.next = cur1 ?? cur2;


        return res.next;
    }
}