Console.WriteLine(IsPalindrome("`l;`` 1o1 ??;l`"));

bool IsPalindrome(string s)
{
	var symbols = s.ToCharArray().Where(char.IsLetterOrDigit);
	Console.WriteLine(new string(symbols.ToArray()));
	return string.Equals(
		new string(symbols.ToArray()),
		new string(symbols.Reverse().ToArray()),
		StringComparison.InvariantCultureIgnoreCase);
}