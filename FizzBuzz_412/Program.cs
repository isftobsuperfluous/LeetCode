var result = FizzBuzz(15);
foreach (var s in result)
{
	Console.WriteLine(s);
}

IList<string> FizzBuzz(int n)
{
	var result = new string[n];
	for (int i = 1; i < n + 1; i++)
	{
		if (i != 0 && i % 15 == 0)
		{
			result[i - 1] = "FizzBuzz";
		}
		else if (i != 0 && i % 3 == 0)
		{
			result[i - 1] = "Fizz";
		}
		else if (i != 0 && i % 5 == 0)
		{
			result[i - 1] = "Buzz";
		}
		else
		{
			result[i - 1] = $"{i}";
		}
	}

	return result;
}