bool ContainsDuplicate(int[] nums)
{
	var storage = new Dictionary<int, int>();
	foreach (var number in nums)
	{
		if (!storage.TryAdd(number, 1))
		{
			return true;
		}
	}

	return false;
}