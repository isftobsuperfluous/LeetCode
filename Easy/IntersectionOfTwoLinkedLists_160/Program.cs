var ll1 = new ListNode(4);
ll1.next = new ListNode(1);
var ll2 = new ListNode(5);
ll2.next = new ListNode(6);
ll2.next.next = new ListNode(1);
ll1.next.next = new ListNode(8);
ll2.next.next.next = ll1.next.next;
Console.WriteLine(ListNode.GetIntersectionNode(ll1, ll2));

class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}

	public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
	{
		var firstLlStorage = new List<ListNode>();
		var secondLlStorage = new List<ListNode>();
		var currentA = headA;
		var currentB = headB;
		while (currentA is not null)
		{
			firstLlStorage.Add(currentA);

			currentA = currentA.next;
		}
		while (currentB is not null)
		{
			secondLlStorage.Add(currentB);

			currentB = currentB.next;
		}

		return firstLlStorage.FirstOrDefault(f => secondLlStorage.Contains(f));
	}
}