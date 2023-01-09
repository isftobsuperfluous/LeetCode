public class Solution
{
	public int RomanToInt(string s)
	{
		var pairs = new Dictionary<char, int>()
		{
			{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000},
		};

		var parsedNumber = 0;

		for (int i = 1; i < s.Length; i++)
		{
			if (pairs[s[i]] > pairs[s[i - 1]])
			{
				parsedNumber -= pairs[s[i - 1]];
			}
			else
			{
				parsedNumber += pairs[s[i - 1]];
			}
		}
		parsedNumber += pairs[s[s.Length - 1]];

		return parsedNumber;
	}
}