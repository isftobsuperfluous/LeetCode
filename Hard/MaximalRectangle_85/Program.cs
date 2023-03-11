// Right solution, but on long data throws time limit exceeded
int MaximalRectangleTimeLimit(char[][] matrix)
{
	var rows = matrix.Length;
	var columns = matrix[0].Length;
	var scheme = new string[rows];
	for (int i = 0; i < rows; i++)
	{
		scheme[i] = new string(matrix[i]);
	}
	const char one = '1';
	var max = 0;
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			if (scheme[i][j] == one)
			{
				max = GetMaxSizeTimeLimit(scheme, i, j, max, 1);
			}
		}
	}

	return max;
}

int GetMaxSizeTimeLimit(string[] scheme, int i, int j, int max, int rowLength)
{
	var rows = scheme.Length;
	var columns = scheme[0].Length;
	var currentSize = rowLength;
	var row = i;
	var line = new string('1', rowLength);
	while (++row < rows && scheme[row].Substring(j, rowLength) == line)
	{
		currentSize += rowLength;
	}

	max = Math.Max(max, currentSize);
	if (columns >= rowLength && columns > j + rowLength && scheme[i][j + rowLength] == '1')
	{
		max = GetMaxSize(scheme, i, j, max, rowLength + 1);
	}

	return max;
}

int MaximalRectangle(char[][] matrix)
{
	var heights = new int[matrix[0].Length];
	var max = 0;
	for (int i = 0; i < matrix.Length; i++)
	{
		for (int j = 0; j < matrix[0].Length; j++)
		{
			if (matrix[i][j] == '0')
			{
				heights[j] = 0;
			}
			else
			{
				heights[j]++;
			}
		}

		max = Math.Max(max, LargestRectangleAreaTwoPointers(heights));
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