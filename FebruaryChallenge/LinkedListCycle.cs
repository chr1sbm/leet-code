using Common;

namespace Solutions.FebruaryChallenge
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {

            if (head == null) return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;

        }
    }
}
