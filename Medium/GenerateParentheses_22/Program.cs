var result = GenerateParentheses(3);
foreach (var s in result)
{
	Console.WriteLine(s);
}

IList<string> GenerateParentheses(int n)
{
	var result = new List<string>();

	Backtrack(result, string.Empty, 0, 0, n);

	return result;
}

void Backtrack(List<string> list, string currentString, int open, int close, int max)
{
	if (currentString.Length == max * 2)
	{
		list.Add(currentString);
		return;
	}

	if (open < max)
	{
		Backtrack(list, currentString + '(', open + 1, close, max);
	}

	if (close < open)
	{
		Backtrack(list, currentString + ')', open, close + 1, max);
	}
}