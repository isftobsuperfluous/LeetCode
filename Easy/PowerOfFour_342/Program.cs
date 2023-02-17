Console.WriteLine(IsPowerOfFour(16));
Console.WriteLine(IsPowerOfFour(17));

bool IsPowerOfFour(int n)
{
	var degree = -1;
	var pow = 0.0;
	while (pow <= n)
	{
		pow = Math.Pow(4, degree++);
		if (pow == n)
		{
			return true;
		}
	}

	return false;
}