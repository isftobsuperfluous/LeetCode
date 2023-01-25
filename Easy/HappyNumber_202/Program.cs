Console.Write(IsHappy(1111111));

bool IsHappy(int n)
{
	do
	{
		n = SquareDigitsSum(n);
	} while (n > 9);

	return n == 1 || n == 7;
}

int SquareDigitsSum(int n)
{
	var sum = 0;
	while (n > 0)
	{
		sum += (int)Math.Pow(n % 10, 2);
		n /= 10;
	}

	return sum;
}