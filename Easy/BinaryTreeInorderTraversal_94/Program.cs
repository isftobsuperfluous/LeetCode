var node = new TreeNode(
	1, null, new TreeNode(
		2, new TreeNode(
			3)));
new TreeNode().InorderTraversal(node);

class TreeNode
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

	private List<int> result = new();

	public IList<int> InorderTraversal(TreeNode node)
	{
		if (node is not null)
		{
			InorderTraversal(node.left);
			result.Add(node.val);
			Console.WriteLine(node.val);
			InorderTraversal(node.right);
		}

		return result;
	}
}