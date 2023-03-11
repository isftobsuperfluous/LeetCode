// Right solutions, but on long data throws time limit exceeded

Console.WriteLine(LargestRectangleAreaTwoPointers(new[] { 2, 1, 5, 6, 2, 3 }));

int LargestRectangleAreaTimeLimit(int[] heights)
{
	// key = upperBound, value = count of elements which higher or on bound
	// and this elements must be together
	var dictionary = new Dictionary<int, int>();
	var upperBound = heights.Max();
	while (upperBound > 0)
	{
		dictionary.Add(upperBound, HigherOrOnBoundTimeLimit(heights, upperBound));
		upperBound--;
	}

	var largestRectangleArea = 0;
	foreach (var pair in dictionary)
	{
		largestRectangleArea = Math.Max(largestRectangleArea, pair.Key * pair.Value);
	}

	return largestRectangleArea;
}

int HigherOrOnBoundTimeLimit(int[] heights, int upperBound)
{
	var count = 0;
	var maxCount = 0;
	for (int i = 0; i < heights.Length; i++)
	{
		if (heights[i] >= upperBound)
		{
			count++;
			for (int j = i + 1; j < heights.Length; j++)
			{
				if (heights[j] < upperBound)
				{
					break;
				}

				count++;
			}
			maxCount = Math.Max(count, maxCount);
			count = 0;
		}
	}

	return maxCount;
}

int LargestRectangleAreaTwoPointersTimeLimit(int[] heights)
{
	var length = 0;
	var max = 0;
	for (int i = 0; i < heights.Length; i++)
	{
		var left = i - 1;
		var right = i + 1;
		while (left >= 0 && heights[left] >= heights[i])
		{
			left--;
		}

		while (right < heights.Length && heights[right] >= heights[i])
		{
			right++;
		}

		length = Math.Max(length, right - left - 1);
		max = Math.Max(max, heights[i] * length);
		length = 0;
	}

	return max;
}

int LargestRectangleAreaTwoPointers(int[] heights)
{
	int[] lessFromLeft = new int[heights.Length];
	int[] lessFromRight = new int[heights.Length];
	lessFromRight[heights.Length - 1] = heights.Length;
	lessFromLeft[0] = -1;
	for (int i = 1; i < heights.Length; i++)
	{
		var left = i - 1;
		while (left >= 0 && heights[left] >= heights[i])
		{
			left = lessFromLeft[left];
		}
		lessFromLeft[i] = left;
	}
	for (var i = heights.Length - 2; i >= 0; i--)
	{
		var right = i + 1;
		while (right < heights.Length && heights[right] >= heights[i])
		{
			right = lessFromRight[right];
		}
		lessFromRight[i] = right;
	}

	var max = 0;
	for (int i = 0; i < heights.Length; i++)
	{
		max = Math.Max(max, heights[i] * (lessFromRight[i] - lessFromLeft[i] - 1));
	}

	return max;
}