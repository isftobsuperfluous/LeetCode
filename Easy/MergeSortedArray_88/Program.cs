var nums1 = new int[] { 0 };
var nums2 = new int[] { 1 };

Merge(nums1, 0, nums2, 1);

void Merge(int[] nums1, int m, int[] nums2, int n)
{
	var nums1Pointer = m - 1;
	var nums2Pointer = n - 1;
	var index = m + n - 1;
	while (nums1Pointer >= 0 && nums2Pointer >= 0)
	{
		if (nums1[nums1Pointer] < nums2[nums2Pointer])
		{
			nums1[index--] = nums2[nums2Pointer--];
		}
		else
		{
			nums1[index--] = nums1[nums1Pointer--];
		}
	}

	while (nums2Pointer >= 0)
	{
		nums1[index--] = nums2[nums2Pointer--];
	}

	foreach (var num1 in nums1)
	{
		Console.WriteLine(num1);
	}
}