Console.WriteLine(SingleNumber(new[] { 2, 2, 7 }));

int SingleNumber(int[] nums)
{
	var storage = new Dictionary<int, int>();
	foreach (var num in nums)
	{
		if (!storage.ContainsKey(num))
		{
			storage.Add(num, 1);
		}
		else
		{
			storage[num]++;
		}
	}

	return storage.First(x => x.Value == 1).Key;
}