Console.WriteLine(Solution.IsIsomorphic("paper", "title"));

public class Solution
{
	public static bool IsIsomorphic(string s, string t)
	{
		if (s.Length != t.Length)
		{
			return false;
		}
		var ltrMap = new Dictionary<char, char>();
		var rtlMap = new Dictionary<char, char>();
		for (var i = 0; i < s.Length; i++)
		{
			if (!ltrMap.TryAdd(s[i], t[i]))
			{
				if (ltrMap[s[i]] != t[i])
				{
					return false;
				}
			}

			if (!rtlMap.TryAdd(t[i], s[i]))
			{
				if (rtlMap[t[i]] != s[i])
				{
					return false;
				}
			}
		}

		return true;
	}
}