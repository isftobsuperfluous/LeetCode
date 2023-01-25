Console.Write(LengthOfLongestSubstring("pwwkew"));
Console.Write(LengthOfLongestSubstringBadSolution("pwwkew"));

int LengthOfLongestSubstringBadSolution(string s)
{
	if (s.Length < 2)
	{
		return s.Length;
	}

	var storage = new HashSet<char>();
	var maxLength = 0;
	var length = 0;
	for (int i = 0; i < s.Length; i++)
	{
		for (int j = i; j < s.Length; j++)
		{
			if (!storage.Contains(s[j]))
			{
				storage.Add(s[j]);
				length++;
			}
			else
			{
				storage = new HashSet<char>();
				if (length > maxLength)
				{
					maxLength = length;
				}
				length = 0;
				break;
			}
		}
	}

	return maxLength;
}

int LengthOfLongestSubstring(string s)
{
	if (s.Length < 2)
	{
		return s.Length;
	}

	int i = 0, j = 0, max = 0;
	var storage = new HashSet<char>();
	while (j < s.Length)
	{
		if (!storage.Contains(s[j]))
		{
			storage.Add(s[j++]);
			max = Math.Max(max, storage.Count);
		}
		else
		{
			storage.Remove(s[i++]);
		}
	}

	return max;
}