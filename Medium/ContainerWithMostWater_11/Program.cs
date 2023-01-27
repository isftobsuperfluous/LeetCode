var heights1 = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
var heights2 = new[] { 1, 1 };
var heights3 = new[] { 1, 2 };
var heights4 = new[] { 1, 8, 100, 2, 100, 4, 8, 3, 7 };

//Console.WriteLine(MaxArea(heights1));
//Console.WriteLine(MaxArea(heights2));
//Console.WriteLine(MaxArea(heights3));
Console.WriteLine(MaxArea(heights4));
// Time Limit Exceeded
int MaxAreaTimeLimit(int[] heights)
{
	var maxArea = -1;
	for (var i = 0; i < heights.Length - 1; i++)
	{
		for (var j = i + 1; j < heights.Length; j++)
		{
			maxArea = Math.Max(Math.Min(heights[j], heights[i]) * (j - i), maxArea);
		}
	}

	return maxArea == -1 ? 0 : maxArea;
}

int MaxArea(int[] heights)
{
	var maxArea = -1;
	var pointer1 = 0;
	var pointer2 = heights.Length - 1;
	while (pointer1 < pointer2)
	{
		maxArea = Math.Max(Math.Min(heights[pointer1], heights[pointer2]) * (pointer2 - pointer1), maxArea);
		if (heights[pointer1] < heights[pointer2])
		{
			pointer1++;
		}
		else
		{
			pointer2--;
		}
	}

	return maxArea == -1 ? 0 : maxArea;
}