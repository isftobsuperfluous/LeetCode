var testTree = new TreeNode(1);
testTree.left = new TreeNode(2);
testTree.right = new TreeNode(2);
testTree.left.left = new TreeNode(3);
testTree.left.right = new TreeNode(4);
testTree.right.left = new TreeNode(4);
testTree.right.right = new TreeNode(3);

Console.WriteLine(TreeNode.IsSymmetric(testTree));

public class TreeNode
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
	public static bool IsSymmetric(TreeNode root)
	{
		if (root is null)
		{
			return true;
		}

		return IsMirror(root, root);
	}

	public static bool IsMirror(TreeNode leftNode, TreeNode rightNode)
	{
		if (leftNode is null || rightNode is null)
		{
			return leftNode == rightNode;
		}

		if (leftNode.val == rightNode.val)
		{
			return IsMirror(leftNode.left, rightNode.right)
				   && IsMirror(leftNode.right, rightNode.left);
		}

		return false;
	}
}