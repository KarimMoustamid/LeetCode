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

        public static void PrintlinkedList(ListNode linkedList)
        {
            var head = linkedList;

            do
            {
                Print(head);
                head = head.next;
            } while (head.next != null);
        }

        private static void Print(ListNode lastNode)
        {
            Console.WriteLine(lastNode.val);
        }
    }
}