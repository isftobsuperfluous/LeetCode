var sortedLinkedList = new ListNode(
	1, new ListNode(
		1, new ListNode(
			2, new ListNode(
				2, new ListNode(
					3, new ListNode(4))))));

var sortedLinkedListWithoutDuplicates = ListNode.DeleteDuplicates(sortedLinkedList);

while (sortedLinkedListWithoutDuplicates is not null)
{
	Console.WriteLine(sortedLinkedListWithoutDuplicates.val);
	sortedLinkedListWithoutDuplicates = sortedLinkedListWithoutDuplicates.next;
}

public class ListNode
{
	public int val { get; set; }
	public ListNode? next { get; set; }

	public ListNode(int val = 0, ListNode? next = null)
	{
		this.val = val;
		this.next = next;
	}
	public static ListNode? DeleteDuplicates(ListNode? head)
	{
		if (head is not null)
		{
			var storage = new Dictionary<int, int>();
			var currentNode = head;
			var key = currentNode.val;
			storage.TryAdd(key, currentNode.val);
			while (currentNode is not null)
			{
				currentNode = currentNode.next;
				if (currentNode is not null && storage.ContainsValue(currentNode.val))
				{
					var n = head;
					while (n.next != null)
					{
						if (n.next.val == currentNode.val)
						{
							n.next = n.next.next;
							break;
						}

						n = n.next;
					}
				}
				else if (currentNode is not null)
				{
					storage.Add(++key, currentNode.val);
				}
			}
		}

		return head;
	}
}