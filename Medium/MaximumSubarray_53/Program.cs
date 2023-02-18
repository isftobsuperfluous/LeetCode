var nums = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
Console.WriteLine(MaxSubArray(nums));

int MaxSubArray(int[] nums)
{
	var max = int.MinValue;
	var sum = 0;
	for (var i = 0; i < nums.Length - 1; i++)
	{
		sum += nums[i];
		max = Math.Max(max, sum);
		if (sum < 0)
		{
			sum = 0;
		}
	}

	return max;
}