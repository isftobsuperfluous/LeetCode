var test = Generate(5);
foreach (var list in test)
{
	foreach (var number in list)
	{
		Console.WriteLine(number);
	}
}

IList<IList<int>> Generate(int numRows)
{
	if (numRows == 0)
	{
		return null!;
	}

	if (numRows == 1)
	{
		return new List<IList<int>>() { new[] { 1 } };
	}

	if (numRows == 2)
	{
		return new List<IList<int>>() { new[] { 1 }, new[] { 1, 1 } };
	}
	//AFK
	var rows = 3;
	var result = new List<IList<int>>() { new[] { 1 }, new[] { 1, 1 } };
	var prevRowIndex = 1;
	while (numRows - rows >= 0)
	{
		var list = new int[rows++];
		list[0] = 1;
		list[list.Length - 1] = 1;

		for (int i = 0; i < result[prevRowIndex].Count - 1; i++)
		{
			list[i + 1] = result[prevRowIndex][i] + result[prevRowIndex][i + 1];
		}

		result.Add(list);
		++prevRowIndex;
	}

	return result;
}