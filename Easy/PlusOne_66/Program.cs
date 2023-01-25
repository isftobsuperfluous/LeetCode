//var plusOneResponse = new Solution().PlusOne(Enumerable.Range(1, 10).ToArray());
var plusOneResponse = new Solution().PlusOne(new int[] { 8, 9, 9, 9 });
foreach (var digit in plusOneResponse)
{
	Console.WriteLine(digit);
}

public class Solution
{
	public int[] PlusOne(int[] digits)
	{
		for (int i = digits.Length - 1; i >= 0; i--)
		{
			if (digits[i] < 9)
			{
				digits[i]++;
				return digits;
			}
			digits[i] = 0;
		}
		int[] result = new int[digits.Length + 1];
		result[0] = 1;

		return result;
	}
}