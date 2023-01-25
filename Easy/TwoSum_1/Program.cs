public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		var storage = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			if (storage.TryGetValue(target - nums[i], out var index))
			{
				return new int[] { index, i };
			}

			storage.TryAdd(nums[i], i);
		}

		return Array.Empty<int>();
	}
}