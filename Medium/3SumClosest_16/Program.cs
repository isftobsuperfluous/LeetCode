﻿// 2
//var nums = new[]
//{
//	4, 0, 5, -5, 3, 3, 0, -4, -5
//};

// 292

var nums = new[]
{
	40, -53, 36, 89, -38, -51, 80, 11, -10, 76, -30, 46, -39, -15, 4, 72, 83, -25, 33, -69, -73, -100, -23, -37, -13, -62, -26, -54, 36, -84, -65,
	-51, 11, 98, -21, 49, 51, 78, -58, -40, 95, -81, 41, -17, -70, 83, -88, -14, -75, -10, -44, -21, 6, 68, -81, -1, 41, -61, -82, -24, 45, 19, 6,
	-98, 11, 9, -66, 50, -97, -2, 58, 17, 51, -13, 88, -16, -77, 31, 35, 98, -2, 0, -70, 6, -34, -8, 78, 22, -1, -93, -39, -88, -77, -65, 80, 91, 35,
	-15, 7, -37, -96, 65, 3, 33, -22, 60, 1, 76, -32, 22
};

var dictionary = new Dictionary<int, int>(10);


// 1
//var nums = new[]
//{
//	-1, 2, 1, -4
//};
Console.WriteLine(ThreeSumClosest(nums, 292));

int ThreeSumClosest(int[] nums, int target)
{
	Array.Sort(nums);
	var difference = int.MaxValue;
	for (int i = 0; i < nums.Length; i++)
	{
		var left = i + 1;
		var right = nums.Length - 1;
		while (left < right)
		{
			var sum = nums[i] + nums[left] + nums[right];

			if (Math.Abs(target - sum) < Math.Abs(difference))
			{
				difference = target - sum;
			}

			if (sum > target)
			{
				right--;
			}
			else
			{
				left++;
			}
		}
	}

	return target - difference;
}