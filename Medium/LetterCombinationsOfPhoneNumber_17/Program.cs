DisplayCombinations(LetterCombinations("23"));
//DisplayCombinations(LetterCombinations("234"));
//DisplayCombinations(LetterCombinations("297"));
//DisplayCombinations(LetterCombinations(string.Empty));

void DisplayCombinations(IList<string> combinations)
{
	foreach (var combination in combinations)
	{
		Console.Write(combination + " ");
	}

	Console.WriteLine();
}

IList<string> LetterCombinations(string digits)
{
	if (string.IsNullOrEmpty(digits))
	{
		return Array.Empty<string>();
	}
	var storage = new Dictionary<int, char[]>()
	{
		{0, Array.Empty<char>()},
		{1, Array.Empty<char>()},
		{2, new[] {'a', 'b', 'c'}},
		{3, new[] {'d', 'e', 'f'}},
		{4, new[] {'g', 'h', 'i'}},
		{5, new[] {'j', 'k', 'l'}},
		{6, new[] {'m', 'n', 'o'}},
		{7, new[] {'p', 'q', 'r', 's'}},
		{8, new[] {'t', 'u', 'v'}},
		{9, new[] {'w', 'x', 'y', 'z'}},
	};
	var queue = new Queue<string>();
	queue.Enqueue(string.Empty);
	var result = new List<string>();
	while (queue.Count > 0)
	{
		var s = queue.Dequeue();
		if (s.Length == digits.Length)
		{
			result.Add(s);
		}
		else
		{
			var chars = storage[int.Parse(digits[s.Length].ToString())];
			foreach (var c in chars)
			{
				queue.Enqueue(s + c);
			}
		}
	}

	return result;
}