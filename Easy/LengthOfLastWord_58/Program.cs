public class Solution
{
	public int LengthOfLastWord(string s)
	{
		var trimmed = s.Trim();
		return trimmed.Length - trimmed.LastIndexOf(' ') - 1;
	}
}