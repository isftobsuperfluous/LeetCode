class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;

	public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
	{
		this.val = val;
		this.left = left;
		this.right = right;
	}

	public static bool IsBalanced(TreeNode root)
	{
		if (root is null)
		{
			return true;
		}

		var leftDepth = GetDepth(root.left);
		var rightDepth = GetDepth(root.right);

		return Math.Abs(leftDepth - rightDepth) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
	}

	public static int GetDepth(TreeNode root)
	{
		if (root is null)
		{
			return 0;
		}

		return Math.Max(GetDepth(root.left), GetDepth(root.right)) + 1;
	}
}