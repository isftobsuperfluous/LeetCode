Console.WriteLine(Solution.ContainsNearbyDuplicate(new[] { 1, 0, 1, 1 }, 1));

public class Solution
{
	public static bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		var dictionary = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			if (!dictionary.TryAdd(nums[i], i))
			{
				if (Math.Abs(i - dictionary[nums[i]]) <= k)
				{
					return true;
				}

				dictionary[nums[i]] = i;
			}
		}

		return false;
	}
}