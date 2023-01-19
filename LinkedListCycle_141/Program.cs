var linkedList = new ListNode(3);
linkedList.next = new ListNode(2);
linkedList.next.next = new ListNode(0);
linkedList.next.next.next = new ListNode(-4);
linkedList.next.next.next.next = linkedList.next;
Console.WriteLine(ListNode.HasCycle(linkedList));

class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}

	public static bool HasCycle(ListNode head)
	{
		var current = head;
		var storage = new List<ListNode> { current };
		while (current is not null)
		{
			current = current.next;
			if (storage.Any(x => object.ReferenceEquals(x, current)))
			{
				return true;
			}
			storage.Add(current);
		}

		return false;
	}
}