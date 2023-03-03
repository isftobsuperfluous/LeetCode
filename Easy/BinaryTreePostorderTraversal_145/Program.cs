var treeNode = new TreeNode(3);
treeNode.left = new TreeNode(1);
treeNode.right = new TreeNode(2);

var result = PostorderTraversal(treeNode);
foreach (var i in result)
{
	Console.WriteLine(i);
}

IList<int> PostorderTraversal(TreeNode root)
{
	var list = new LinkedList<int>();
	var stack = new Stack<TreeNode>();
	var pointer = root;
	while (stack.Count > 0 || pointer is not null)
	{
		if (pointer is not null)
		{
			stack.Push(pointer);
			list.AddFirst(pointer.val);
			pointer = pointer.right;
		}
		else
		{
			var node = stack.Pop();
			pointer = node.left;
		}
	}

	return list.ToList();
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
