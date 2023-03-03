var treeNode = new TreeNode(3);
treeNode.left = new TreeNode(1);
treeNode.right = new TreeNode(2);

var result = PreorderTraversal(treeNode);
foreach (var i in result)
{
	Console.WriteLine(i);
}

IList<int> PreorderTraversal(TreeNode root)
{
	// Recursive:

	//var list = new List<int>();
	//PreorderTrabersalRecursive(root, list);

	//return list;

	// Iterative:
	var list = new List<int>();
	var stack = new Stack<TreeNode>();
	var pointer = root;
	while (stack.Count > 0 || pointer is not null)
	{
		if (pointer is not null)
		{
			stack.Push(pointer);
			list.Add(pointer.val);
			pointer = pointer.left;
		}
		else
		{
			var node = stack.Pop();
			pointer = node.right;
		}
	}

	return list;
}

IList<int> PreorderTrabersalRecursive(TreeNode root, List<int> list)
{
	if (root is not null)
	{
		list.Add(root.val);
		PreorderTrabersalRecursive(root.left, list);
		PreorderTrabersalRecursive(root.right, list);
	}

	return list;
}

class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;

	public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
	{
		this.val = val; this.left = left; this.right = right;
	}
}
