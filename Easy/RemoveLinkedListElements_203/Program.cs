//var input = new ListNode(1);
//input.next = new ListNode(2);
//input.next.next = new ListNode(6);
//input.next.next.next = new ListNode(3);
//input.next.next.next.next = new ListNode(4);
//input.next.next.next.next.next = new ListNode(5);
//input.next.next.next.next.next.next = new ListNode(6);

var input = new ListNode(7);
input.next = new ListNode(7);
input.next.next = new ListNode(7);
input.next.next.next = new ListNode(7);
var result = RemoveElements(input, 7);
var current = result;
while (current is not null)
{
	Console.WriteLine(current.val);
	current = current.next;
}

ListNode RemoveElements(ListNode head, int val)
{
	var plug = new ListNode();
	plug.next = head;
	var current = plug;
	while (current.next is not null)
	{
		if (current.next.val == val)
		{
			current.next = current.next.next;
		}
		else
		{
			current = current.next;
		}
	}

	return plug.next;
}

class ListNode
{
	public int val { get; set; }
	public ListNode next { get; set; }

	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}