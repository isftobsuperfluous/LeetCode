var node1 = new TreeNode(1);
node1.left = new TreeNode(2);
var node2 = new TreeNode(1);
node2.right = new TreeNode(2);
Console.WriteLine(TreeNode.IsSameTree(node1, node2));

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

	public static bool IsSameTree(TreeNode p, TreeNode q)
	{
		var firstTreeNodeValues = TreeTraversal(p);
		var secondTreeNodeValues = TreeTraversal(q);

		return firstTreeNodeValues.values.SequenceEqual(secondTreeNodeValues.values) && firstTreeNodeValues.sequence.SequenceEqual(secondTreeNodeValues.sequence);
	}

	public static (List<int> values, List<char> sequence) TreeTraversal(TreeNode node)
	{
		var storage = new Stack<TreeNode>();
		storage.Push(node);

		List<int> values = new();
		List<char> sequence = new();
		while (storage.Count > 0)
		{
			var current = storage.Pop();

			if (current is null)
			{
				break;
			}

			values.Add(current.val);

			if (current.left is not null)
			{
				storage.Push(current.left);
				sequence.Add('l');
			}

			if (current.right is not null)
			{
				storage.Push(current.right);
				sequence.Add('r');
			}
		}

		return (values, sequence);
	}
}