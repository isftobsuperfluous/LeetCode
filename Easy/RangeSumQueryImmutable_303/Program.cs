var numArray = new NumArray(new[] { -2, 0, 3, -5, 2, -1 });
Console.WriteLine(numArray.SumRange(0, 2));
Console.WriteLine(numArray.SumRange(2, 5));
Console.WriteLine(numArray.SumRange(0, 5));

class NumArray
{
	private readonly int[] _nums;

	public NumArray(int[] nums)
	{
		for (int i = 1; i < nums.Length; i++)
		{
			nums[i] += nums[i - 1];
		}

		_nums = nums;
	}

	public int SumRange(int left, int right)
	{
		if (left == 0)
		{
			return _nums[right];
		}

		return _nums[right] - _nums[left - 1];
	}
}