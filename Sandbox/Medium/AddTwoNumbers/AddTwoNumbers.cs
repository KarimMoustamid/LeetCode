namespace Sandbox.Medium.AddTwoNumbers
{
    public class AddTwoNumbers
    {
        public ListNode l1 { get; set; }
        public ListNode l2 { get; set; }

        public AddTwoNumbers(ListNode l1, ListNode l2)
        {
            this.l1 = l1;
            this.l2 = l2;
        }


        public void ResultLinkedList()
        {
            var l1Pointer = l1;
            var l2Pointer = l2;

            var resultListNode = new ListNode();
            while (l1Pointer.next != null && l2Pointer.next != null)
            {
                resultListNode.val = l1Pointer.val + l2Pointer.val;
                Print(resultListNode);

                l1Pointer = l1Pointer.next;
                l2Pointer = l2Pointer.next;

                if (l1Pointer.next == null || l2Pointer.next == null)
                {
                    resultListNode.val = l1Pointer.val + l2Pointer.val;
                    Console.Write($" {resultListNode.val} ");
                    break;
                }
            }
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