public class Solution
{
	public string LongestCommonPrefix(string[] strs)
	{
		var prefix = string.Empty;

		foreach (var c in strs[0])
		{
			prefix += c;
			if (!strs.All(s => s.StartsWith(prefix)))
			{
				return prefix.Substring(0, prefix.Length - 1);
			}

		}

		return prefix;
	}
}