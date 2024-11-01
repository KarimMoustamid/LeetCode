namespace Sandbox.Medium.AddTwoNumbers
{
    public class AddTwoNumbers
    {
        public ListNode L1;
        public ListNode L2;

        public AddTwoNumbers(ListNode l1, ListNode l2)
        {
            this.L1 = l1;
            this.L2 = l2;
        }


        public void ResultLinkedList()
        {
            var remainder = 0;

        }


        #region Print
        public static void PrintLinkedListValues(ListNode linkedList)
        {
            var head = linkedList;
            while (head.next != null)
            {
                Print(head);
                head = head.next;

                if (head.next == null)
                {
                    Console.Write($" {head.val} ");
                }
            }
        }

        private static void Print(ListNode lastNode)
        {
            Console.Write($" {lastNode.val} ->");
        }
        #endregion
    }
}