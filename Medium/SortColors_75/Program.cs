var nums = new int[] { 2, 0, 2, 1, 1, 0 };
SortColors(nums);
foreach (var num in nums)
{
	Console.WriteLine(num);
}

void SortColors(int[] nums)
{
	while (!nums.IsSorted())
	{
		Sort(nums);
	}
}

void Sort(int[] nums)
{
	var slow = 0;
	var fast = 1;
	while (fast != nums.Length)
	{
		if (nums[slow] > nums[fast])
		{
			(nums[slow], nums[fast]) = (nums[fast], nums[slow]);
			slow++;
		}
		else
		{
			fast++;
			slow++;
		}
	}
}

public static class ArrayExtensions
{
	public static bool IsSorted(this int[] array)
	{
		for (var i = 1; i < array.Length; i++)
		{
			if (array[i] < array[i - 1])
			{
				return false;
			}
		}

		return true;
	}
}