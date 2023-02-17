string ReverseVowels(string s)
{
	var vowels = "aeiouAEIOU";
	var stack = new Stack<char>();
	var array = s.ToCharArray();
	for (var i = 0; i < array.Length; i++)
	{
		if (vowels.Contains(array[i]))
		{
			stack.Push(array[i]);
		}
	}

	for (var i = 0; i < array.Length; i++)
	{
		if (vowels.Contains(array[i]))
		{
			array[i] = stack.Pop();
		}
	}

	return new string(array);
}