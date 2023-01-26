//var ll1 = new ListNode(9);
//ll1.next = new ListNode(9);
//ll1.next.next = new ListNode(9);
//ll1.next.next.next = new ListNode(9);
//ll1.next.next.next.next = new ListNode(9);
//ll1.next.next.next.next.next = new ListNode(9);
//ll1.next.next.next.next.next.next = new ListNode(9);

//var ll2 = new ListNode(9);
//ll2.next = new ListNode(9);
//ll2.next.next = new ListNode(9);
//ll2.next.next.next = new ListNode(9);

var ll1 = new ListNode(9);
ll1.next = new ListNode(9);
ll1.next.next = new ListNode(9);

var ll2 = new ListNode(9);
ll2.next = new ListNode(9);

var result = ListNode.AddTwoNumbers(ll1, ll2);
var current = result;
while (current is not null)
{
	Console.WriteLine(current.val);
	current = current.next;
}

public class ListNode
{
	public int val { get; set; }
	public ListNode next { get; set; }

	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val; this.next = next;
	}

	public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		var current = new ListNode();
		ListNode head = current;
		var sum = 0;
		while (l1 is not null || l2 is not null)
		{
			sum /= 10;
			if (l1 is not null)
			{
				sum += l1.val;
				l1 = l1.next;
			}
			if (l2 is not null)
			{
				sum += l2.val;
				l2 = l2.next;
			}

			current.next = new ListNode(sum % 10);
			current = current.next;
		}

		if (sum / 10 == 1)
		{
			current.next = new ListNode(1);
		}

		return head.next;
	}
}