Console.WriteLine(MySqrt(2147483647));

int MySqrt(int x)
{
	long result = x / 46341;
	while (result * result <= x)
	{
		result++;
	}

	if (result * result == x)
	{
		return (int)result;
	}

	return (int)--result;
}