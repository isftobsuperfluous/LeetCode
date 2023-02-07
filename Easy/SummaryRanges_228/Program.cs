//var test = new int[] { 0, 1, 2, 4, 5, 7 };
// var test = new int[] { -1 };
var test = new int[] { -2, -1, 1, 2, 2147483646, 2147483647 };
var result = SummaryRanges(test);
foreach (var s in result)
{
	Console.WriteLine(s);
}

IList<string> SummaryRanges(int[] nums)
{
	if (nums is null || nums.Length == 0)
	{
		return Array.Empty<string>();
	}

	if (nums.Length == 1)
	{
		return new List<string>() { nums[0].ToString() };
	}

	int start;
	var end = 0;
	var result = new List<string>();
	int lastAdded = 0;
	for (var i = 0; i < nums.Length - 1; i++)
	{
		start = nums[i];

		while (i < nums.Length - 1 && nums[i] == nums[i + 1] - 1)
		{
			if (nums[i] == nums[i + 1] - 1)
			{
				i++;
				end = nums[i];
			}
		}

		if (start != nums[i])
		{
			result.Add($"{start}->{end}");
			lastAdded = end;
		}
		else
		{
			result.Add($"{start}");
			lastAdded = start;
		}
	}

	if (lastAdded != nums[nums.Length - 1])
	{
		result.Add($"{nums[nums.Length - 1]}");
	}

	return result;
}