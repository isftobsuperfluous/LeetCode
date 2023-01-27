Console.WriteLine(ReverseBadSolution(1534236469));
Console.WriteLine(ReverseGoodSolution(-123));

int ReverseBadSolution(int x)
{
	var str = x.ToString();
	if (x < 0)
	{
		return int.TryParse("-" + new string(
				str.Substring(1, str.Length - 1).Reverse().ToArray()),
			out int negativeResult) ? negativeResult : 0;
	}

	return int.TryParse(new string(str.Reverse().ToArray()), out int nonNegativeResult) ? nonNegativeResult : 0;
}

int ReverseGoodSolution(int x)
{
	var chars = x.ToString().ToCharArray();
	int i = 0, j = chars.Length - 1;
	if (x < 0)
	{
		i = 1;
	}
	while (i < j)
	{
		(chars[i], chars[j]) = (chars[j], chars[i]);
		i++;
		j--;
	}

	return int.TryParse(new string(chars), out int result) ? result : 0;
}

