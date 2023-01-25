var s = "anagram";
var t = "nagaram";
Console.WriteLine(IsAnagram("rat", "car"));

bool IsAnagram(string s, string t)
{
	if (s.Length != t.Length)
	{
		return false;
	}

	var storage = new Dictionary<char, int>();
	foreach (var ch in s)
	{
		if (!storage.TryAdd(ch, 1))
		{
			storage[ch]++;
		}
	}

	foreach (var ch in t)
	{
		if (!(storage.ContainsKey(ch) && storage[ch] > 0))
		{
			return false;
		}

		storage[ch]--;
	}

	return true;
}