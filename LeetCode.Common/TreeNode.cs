namespace LeetCode.Common;

/// <summary>
/// Definition for a binary tree node.
/// </summary>
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    /// <summary>
    /// Creates a binary tree from level-order traversal array.
    /// </summary>
    public static TreeNode? FromArray(int?[] values)
    {
        if (values.Length == 0 || values[0] == null) return null;
        
        var root = new TreeNode(values[0]!.Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        int i = 1;
        while (queue.Count > 0 && i < values.Length)
        {
            var node = queue.Dequeue();
            
            if (i < values.Length && values[i] != null)
            {
                node.left = new TreeNode(values[i]!.Value);
                queue.Enqueue(node.left);
            }
            i++;
            
            if (i < values.Length && values[i] != null)
            {
                node.right = new TreeNode(values[i]!.Value);
                queue.Enqueue(node.right);
            }
            i++;
        }
        
        return root;
    }
}