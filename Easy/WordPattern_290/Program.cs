var pattern = "abba";
var s = "dog dog dog dog";
Console.WriteLine(WordPattern(pattern, s));

bool WordPattern(string pattern, string s)
{
	var dictionary = new Dictionary<char, string>();
	var counters = new Dictionary<string, int>();
	var words = s.Split(' ');
	for (int i = 0; i < words.Length; i++)
	{
		if (!counters.TryAdd(words[i], 1))
		{
			counters[words[i]]++;
		}

		if (!dictionary.TryAdd(pattern[i], words[i]))
		{
			if (dictionary[pattern[i]] != words[i] || counters[words[i]] > 1)
			{
				return false;
			}
		}
	}

	return true;
}