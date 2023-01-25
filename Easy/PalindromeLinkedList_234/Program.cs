var list = new ListNode(1);
list.next = new ListNode(2);
list.next.next = new ListNode(2);
list.next.next.next = new ListNode(1);
Console.WriteLine(ListNode.IsPalindrome(list));

class ListNode
{
	public int val { get; set; }
	public ListNode? next { get; set; }

	public ListNode(int val = 0, ListNode? next = null)
	{
		this.val = val;
		this.next = next;
	}

	public static bool IsPalindrome(ListNode head)
	{
		var storage = new List<int>();
		var current = head;
		while (current is not null)
		{
			storage.Add(current.val);
			current = current.next;
		}

		for (int i = 0; i < storage.Count / 2; i++)
		{
			if (storage[i] != storage[storage.Count - i - 1])
			{
				return false;
			}
		}

		return true;
	}
}