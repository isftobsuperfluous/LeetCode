bool IsPowerOfThree(int n)
{
	var degree = 0;
	while (Math.Pow(3, degree) != n)
	{
		if (Math.Pow(3, degree++) > n)
		{
			return false;
		}
	}

	return true;
}