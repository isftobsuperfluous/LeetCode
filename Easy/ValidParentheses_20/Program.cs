public class Solution
{
	public bool IsValid(string s)
	{
		var rightPairs = new Stack<char>();

		foreach (var c in s)
		{
			if (c == '(')
			{
				rightPairs.Push(')');
				continue;
			}

			if (c == '[')
			{
				rightPairs.Push(']');
				continue;
			}

			if (c == '{')
			{
				rightPairs.Push('}');
				continue;
			}

			if (rightPairs.Count == 0 || rightPairs.Pop() != c)
			{
				return false;
			}
		}

		return rightPairs.Count == 0;
	}
}