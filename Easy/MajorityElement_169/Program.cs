Console.Write(MajorityElement(new[] { 2, 2, 1, 1, 1, 2, 2 }));

int MajorityElement(int[] nums)
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

	return storage.First(x => x.Value > nums.Length / 2).Key;
}