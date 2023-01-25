Console.WriteLine(MissingNumberSum(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
Console.WriteLine(MissingNumberExcept(new[] { 0, 1 }));
Console.WriteLine(MissingNumberDictionary(new[] { 3, 0, 1 }));

int MissingNumberSum(int[] nums)
{
	return Enumerable.Range(0, nums.Length + 1).Sum() - nums.Sum();
}

int MissingNumberExcept(int[] nums)
{
	var expectedNumbers = Enumerable.Range(0, nums.Length + 1);
	return expectedNumbers.Except(nums).First();
}

int MissingNumberDictionary(int[] nums)
{
	var storage = new Dictionary<int, int>();
	for (var i = 0; i < nums.Length + 1; i++)
	{
		storage.Add(i, 1);
	}
	foreach (var num in nums)
	{
		storage.Remove(num);
	}

	return storage.First().Key;
}