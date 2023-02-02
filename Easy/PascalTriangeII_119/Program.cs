var result = Generate(3);
foreach (var number in result)
{
	Console.Write($"{number} ");
}

IList<int> Generate(int rowIndex)
{
	if (rowIndex == 0)
	{
		return new[] { 1 };
	}

	if (rowIndex == 1)
	{
		return new[] { 1, 1 };
	}

	var rows = 3;
	var result = new List<IList<int>>() { new[] { 1 }, new[] { 1, 1 } };
	var prevRowIndex = 1;
	while (rows < rowIndex + 2)
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

	return result[rowIndex];
}