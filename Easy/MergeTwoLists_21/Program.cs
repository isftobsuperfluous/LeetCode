public class ListNode
{
	public int Value;
	public ListNode? Next;

	public ListNode(int value, ListNode? next = null)
	{
		Value = value;
		Next = next;
	}
}

public class Solution
{
	public ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
	{
		if (list1 == null) return list2;
		if (list2 == null) return list1;

		if (list1.Value <= list2.Value)
		{
			list1.Next = MergeTwoLists(list1.Next, list2);
			return list1;
		}

		list2.Next = MergeTwoLists(list1, list2.Next);
		return list2;
	}
}