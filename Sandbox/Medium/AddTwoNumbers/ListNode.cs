namespace Sandbox.Medium.AddTwoNumbers
{
    public class ListNode
    {

        public int val;
        public ListNode next;

        public int Val
        {
            get { return val;}
            set
            {

                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "ListNode cannot be null.");
                }

                if (value is < 0 or > 9)
                {
                    throw new ArgumentException("The value of ListNode must be between 1 and 9.", nameof(value));
                }

                val = value;
            }
        }


        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.next = next;
        }

    }
}