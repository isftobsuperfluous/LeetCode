var sortedArray = new int[] { -10, -3, 0, 5, 9 };
var bst = TreeNode.SortedArrayToBST(sortedArray);

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

	public static TreeNode SortedArrayToBST(int[] nums)
	{
		if (nums.Length == 0)
		{
			return null;
		}

		var head = Helper(nums, 0, nums.Length - 1);
		return head;
	}

	public static TreeNode Helper(int[] num, int low, int high)
	{
		if (low > high)
		{
			return null;
		}
		var mid = (low + high) / 2;
		var node = new TreeNode(num[mid]);
		node.left = Helper(num, low, mid - 1);
		node.right = Helper(num, mid + 1, high);

		return node;
	}
}