var sequence = Storage.Convert("AAA");
foreach (var number in sequence)
{
	Console.Write($"{number} ");
}
// FXS = 4699 (6, 24, 19)
// AAA = 703
// BAA = 1379

// Math.Pow(26, )

//FXSHRXW
Console.WriteLine(Storage.TitleToNumber("BAA"));

public class Storage
{
	public static Dictionary<char, int> storage = new Dictionary<char, int>()
	{
		{ 'A', 1 },
		{ 'B', 2 },
		{ 'C', 3 },
		{ 'D', 4 },
		{ 'E', 5 },
		{ 'F', 6 },
		{ 'G', 7 },
		{ 'H', 8 },
		{ 'I', 9 },
		{ 'J', 10 },
		{ 'K', 11 },
		{ 'L', 12 },
		{ 'M', 13 },
		{ 'N', 14 },
		{ 'O', 15 },
		{ 'P', 16 },
		{ 'Q', 17 },
		{ 'R', 18 },
		{ 'S', 19 },
		{ 'T', 20 },
		{ 'U', 21 },
		{ 'V', 22 },
		{ 'W', 23 },
		{ 'X', 24 },
		{ 'Y', 25 },
		{ 'Z', 26 }
	};

	public static IEnumerable<int> Convert(string columnTitle)
	{
		foreach (var ch in columnTitle)
		{
			yield return storage[ch];
		}
	}

	// 6 * 1 * 24 * 2 * 19 * 3 * 8 * 4 * 18 * 5 * 24 * 6 * 23 * 7

	public static int TitleToNumber(string columnTitle)
	{
		var index = 0;
		var number = 0;
		for (var i = columnTitle.Length - 1; i >= 0; i--)
		{
			number += index > 0 ? (int)Math.Pow(26, index) * storage[columnTitle[i]] : storage[columnTitle[i]];
			index++;
		}

		return number;
	}
}