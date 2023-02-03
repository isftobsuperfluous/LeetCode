Console.WriteLine(Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0));

int Search(int[] nums, int target)
{
	var left = 0;
	var right = nums.Length - 1;
	while (left < right)
	{
		var mid = (left + right) / 2;
		if (nums[mid] > nums[right])
		{
			left = mid + 1;
		}
		else
		{
			right = mid;
		}
	}

	var start = left;
	left = 0;
	right = nums.Length - 1;

	if (target >= nums[start] && target <= nums[right])
	{
		left = start;
	}
	else
	{
		right = start;
	}

	while (left <= right)
	{
		var mid = (left + right) / 2;
		if (target == nums[mid])
		{
			return mid;
		}
		if (target < nums[mid])
		{
			right = mid - 1;
		}
		else
		{
			left = mid + 1;
		}
	}

	return -1;
}