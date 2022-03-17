namespace leetcode
{
    static class Solution5
    {
        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int num1, n = 0;
            bool  first = true;

            ListNode l, result = new();
            l = result;

            while ( l1 != null || l2 != null || n != 0)
            {
                if (first) first = false;
                else
                {
                    l.next = new();
                    l = l.next;
                } 

                int i = l1?.val ?? 0;
                int j = l2?.val ?? 0;
                num1 = i + j + n;
                
                if (num1 > 9)
                {
                    l.val = num1 - 10;
                    n = 1;
                }
                else
                {
                    l.val = num1;
                    n = 0;
                }

                l1 = l1?.next;
                l2 = l2?.next;
            }
            return result;
        }
    }
    
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
         this.val = val;
         this.next = next;
      }
  }
}
