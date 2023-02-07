bool IsPowerOfTwo(int n)
{
	var degree = 0;
	while (Math.Pow(2, degree) <= n)
	{
		if (Math.Pow(2, degree) == n)
		{
			return true;
		}
		degree++;
	}

	return false;
}