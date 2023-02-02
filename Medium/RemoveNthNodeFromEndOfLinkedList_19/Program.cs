var head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);
var newHead = ListNode.RemoveNthFromEnd(head, 1);
var current = newHead;
while (current is not null)
{
	Console.Write($"{current.val} ");
	current = current.next;
}

public class ListNode
{
	public int val { get; set; }
	public ListNode next { get; set; }

	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}

	public static ListNode RemoveNthFromEnd(ListNode head, int n)
	{
		if (head is null)
		{
			return null;
		}

		var originalSequence = new List<int>();
		var current = head;
		while (current is not null)
		{
			originalSequence.Add(current.val);
			current = current.next;
		}

		var index = originalSequence.Count - n;
		var newHead = new ListNode();
		current = newHead;
		for (var i = 0; i < originalSequence.Count; i++)
		{
			if (i != index)
			{
				current.next = new ListNode(originalSequence[i]);
				current = current.next;
			}
		}

		return newHead.next;
	}
}