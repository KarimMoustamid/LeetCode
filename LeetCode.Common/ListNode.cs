namespace LeetCode.Common;

/// <summary>
/// Definition for singly-linked list.
/// </summary>
public class ListNode
{
    public int val;
    public ListNode? next;
    
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    /// <summary>
    /// Creates a linked list from an array of values.
    /// </summary>
    public static ListNode? FromArray(int[] values)
    {
        if (values.Length == 0) return null;
        
        var head = new ListNode(values[0]);
        var current = head;
        
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        
        return head;
    }

    /// <summary>
    /// Converts the linked list to an array.
    /// </summary>
    public int[] ToArray()
    {
        var result = new List<int>();
        var current = this;
        
        while (current != null)
        {
            result.Add(current.val);
            current = current.next;
        }
        
        return result.ToArray();
    }
}