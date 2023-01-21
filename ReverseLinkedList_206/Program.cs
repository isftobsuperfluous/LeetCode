var list = new ListNode(1);
list.next = new ListNode(2);
list.next.next = new ListNode(3);
list.next.next.next = new ListNode(4);
list.next.next.next.next = new ListNode(5);
var reversedList = ListNode.ReverseList(list);
var current = reversedList;
while (current is not null)
{
	Console.WriteLine(current.val);
	current = current.next;
}

class ListNode
{
	public int val { get; set; }
	public ListNode? next { get; set; }

	public ListNode(int val = 0, ListNode? next = null)
	{
		this.val = val;
		this.next = next;
	}

	public static ListNode ReverseList(ListNode head)
	{
		var storage = new Stack<int>();
		var current = head;
		while (current is not null)
		{
			storage.Push(current.val);
			current = current.next;
		}

		current = head;
		while (storage.TryPop(out int nodeValue))
		{
			current.val = nodeValue;
			current = current.next;
		}

		return head;
	}
}