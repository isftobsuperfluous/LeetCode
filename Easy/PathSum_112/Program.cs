var root = new TreeNode(5);
root.left = new TreeNode(4);
root.right = new TreeNode(8);
root.left.left = new TreeNode(11);
root.right.left = new TreeNode(13);
root.right.right = new TreeNode(4);
root.left.left.left = new TreeNode(7);
root.left.left.right = new TreeNode(2);
root.right.right.right = new TreeNode(1);
Console.WriteLine(TreeNode.HasPathSum(root, 22));

public class TreeNode
{
	public int val { get; set; }
	public TreeNode left { get; set; }
	public TreeNode right { get; set; }

	public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
	{
		this.val = val;
		this.left = left;
		this.right = right;
	}

	public static bool HasPathSum(TreeNode root, int targetSum)
	{
		var stack = new Stack<TreeNode>();
		stack.Push(root);
		while (stack.Count > 0)
		{
			var current = stack.Pop();
			if (current.left is null && current.right is null)
			{
				if (current.val == targetSum)
				{
					return true;
				}
			}

			if (current.right is not null)
			{
				current.right.val += current.val;
				stack.Push(current.right);
			}

			if (current.left is not null)
			{
				current.left.val += current.val;
				stack.Push(current.left);
			}
		}

		return false;
	}
}