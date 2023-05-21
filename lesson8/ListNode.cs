public class ListNode
{
    int data;
    ListNode next;

    public ListNode(int data, ListNode next)
    {
        this.data = data;
        this.next = next;
    }
}

public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        if(list1 is null)
            return list2;
        else if(list2 is null)
            return list1;

        ListNode head = null;
        ListNode current = null;

        while(list1 != null || list2 != null)
        {
            if(head is null)
            {
                if(list1.val < list2.val)
                {
                    head = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    head = new ListNode(list2.val);
                    list2 = list2.next;
                }

                current = head;
            }
            else
            {
                if(list1 is null || list1.val > list2?.val)
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                else
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                }

                current = current.next;
            }
        }

        return head;
    }
}