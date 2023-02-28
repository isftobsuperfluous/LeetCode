var result = Intersection(new[] { 1, 2, 2, 1 }, new[] { 2, 2 });
foreach (var i in result)
{
	Console.WriteLine(i);
}

int[] Intersection(int[] nums1, int[] nums2)
{
	var numsSet1 = new HashSet<int>();
	var numsSet2 = new HashSet<int>();
	foreach (var num1 in nums1)
	{
		if (!numsSet1.Contains(num1)) numsSet1.Add(num1);
	}

	foreach (var num2 in nums2)
	{
		if (!numsSet2.Contains(num2)) numsSet2.Add(num2);
	}

	var intersection = new List<int>();
	if (numsSet1.Count < numsSet2.Count)
	{
		for (int i = 0; i < numsSet1.Count; i++)
		{
			var element = numsSet1.ElementAt(i);
			if (numsSet2.Contains(element))
			{
				intersection.Add(element);
			}
		}
	}
	else
	{
		for (int i = 0; i < numsSet2.Count; i++)
		{
			var element = numsSet1.ElementAt(i);
			if (numsSet1.Contains(element))
			{
				intersection.Add(element);
			}
		}
	}

	return intersection.ToArray();
}