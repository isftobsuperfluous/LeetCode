var result = SearchRange(new[] { 1, 1, 2 }, 1);
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);

int[] SearchRange(int[] nums, int target)
{
	if (nums is null || nums.Length == 0)
	{
		return new[] { -1, -1 };
	}

	var firstIndex = FindFirst(nums, target);
	var lastIndex = FindLast(nums, target);

	return new[] { firstIndex, lastIndex };
}

int FindFirst(int[] nums, int target)
{
	var index = -1;
	var start = 0;
	var end = nums.Length - 1;
	while (start <= end)
	{
		var mid = (start + end) / 2;
		if (nums[mid] == target)
		{
			index = mid;
		}
		if (nums[mid] >= target)
		{
			end = mid - 1;
		}
		else
		{
			start = mid + 1;
		}
	}

	return index;
}

int FindLast(int[] nums, int target)
{
	var index = -1;
	var start = 0;
	var end = nums.Length - 1;
	while (start <= end)
	{
		var mid = (start + end) / 2;
		if (nums[mid] == target)
		{
			index = mid;
		}
		if (nums[mid] <= target)
		{
			start = mid + 1;
		}
		else
		{
			end = mid - 1;
		}
	}

	return index;
}