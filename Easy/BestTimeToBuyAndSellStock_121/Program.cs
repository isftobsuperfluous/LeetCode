Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));

int MaxProfit(int[] prices)
{
	var min = prices[0];
	var maxDifference = 0;
	for (int i = 1; i < prices.Length; i++)
	{
		if (prices[i] - min > maxDifference)
		{
			maxDifference = prices[i] - min;
		}

		if (prices[i] < min)
		{
			min = prices[i];
		}
	}

	return maxDifference;
}