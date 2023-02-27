Console.WriteLine(ConvertToTitle(731)); // ABC

Console.WriteLine(ConvertToTitle(701)); // ZY

Console.WriteLine(ConvertToTitle(24568)); // AJHX

string ConvertToTitle(int columnNumber)
{
	var dictionary = new Dictionary<int, char>()
	{
		{ 1, 'A' }, { 2, 'B' }, { 3, 'C' }, { 4, 'D' }, { 5, 'E' },
		{ 6, 'F' }, { 7, 'G' }, { 8, 'H' }, { 9, 'I' }, { 10, 'J' },
		{ 11, 'K' }, { 12, 'L' }, { 13, 'M' }, { 14, 'N' }, { 15, 'O' },
		{ 16, 'P' }, { 17, 'Q' }, { 18, 'R' }, { 19, 'S' }, { 20, 'T' },
		{ 21, 'U' }, { 22, 'V' }, { 23, 'W' }, { 24, 'X' }, { 25, 'Y' },
		{ 26, 'Z' }
	};

	if (columnNumber <= 26)
	{
		return dictionary[columnNumber].ToString();
	}

	var resultLength = 2;
	var d = 2;
	var prev = 26;
	while (Math.Pow(26, d) + prev < columnNumber)
	{
		prev = (int)Math.Pow(26, d) + prev;
		d++;
		resultLength++;
	}

	var degree = 0;
	var result = string.Empty;
	while (resultLength-- > 1)
	{
		while (Math.Pow(26, resultLength) < columnNumber)
		{
			degree++;
			if (Math.Pow(26, resultLength) * (degree + 1) >= columnNumber)
			{
				columnNumber -= (int)Math.Pow(26, resultLength) * degree;
				result += dictionary[degree];
				degree = 0;
				break;
			}
		}
	}

	return result + dictionary[columnNumber];
}