var nums = new[] { 1, 0, 1 };
MoveZeroes(nums);
foreach (var num in nums)
{
	Console.WriteLine(num);
}

void MoveZeroes(int[] nums)
{
	var zeroes = 0;
	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] == 0)
		{
			zeroes++;
		}
		else if (zeroes > 0)
		{
			var temp = nums[i];
			nums[i] = 0;
			nums[i - zeroes] = temp;
		}
	}
}