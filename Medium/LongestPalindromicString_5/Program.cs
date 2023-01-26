Console.WriteLine(LongestPalindrome("racecar"));
Console.WriteLine(1534236469 > int.MaxValue);
Console.WriteLine(1534236469);
Console.WriteLine(int.MaxValue);

string LongestPalindrome(string s)
{
	if (s is null || s.Length < 1)
	{
		return string.Empty;
	}

	var start = 0;
	var end = 0;

	for (int i = 0; i < s.Length; i++)
	{
		var len1 = ExpandFromMiddle(s, i, i);
		var len2 = ExpandFromMiddle(s, i, i + 1);
		var len = Math.Max(len1, len2);
		if (len > end - start)
		{
			start = i - ((len - 1) / 2);
			end = i + (len / 2);
		}
	}

	return s.Substring(start, end + 1);
}

int ExpandFromMiddle(string s, int left, int right)
{
	if (s is null || left > right)
	{
		return 0;
	}

	while (left >= 0 && right < s.Length && s[left] == s[right])
	{
		left--;
		right++;
	}

	return right - left - 1;
}