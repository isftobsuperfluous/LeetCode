int HammingWeight(uint n)
{
	var setBitCount = 0;

	while (n != 0)
	{
		n &= (n - 1);
		++setBitCount;
	}

	return setBitCount;
}