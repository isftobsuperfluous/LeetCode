int AddDigits(int num)
{
	var n = num;
	var sum = 0;
	while (num > 9)
	{
		while (n > 0)
		{
			sum += n % 10;
			n /= 10;
		}

		num = sum;
		n = num;
		sum = 0;
	}

	return num;
}