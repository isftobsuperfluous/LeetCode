var result = Intersection(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 });
foreach (var num in result)
{
	Console.WriteLine(num);
}

int[] Intersection(int[] nums1, int[] nums2)
{
	var storage = new Dictionary<int, int>();
	foreach (var num in nums1)
	{
		if (!storage.TryAdd(num, 1))
		{
			storage[num]++;
		}
	}
	var result = new int[Math.Min(nums1.Length, nums2.Length)];
	var index = 0;
	foreach (var num in nums2)
	{
		if (storage.ContainsKey(num) && storage[num] > 0)
		{
			storage[num] -= 1;
			result[index] = num;
			index++;
		}
	}

	return result.Take(index).ToArray();
}