Console.WriteLine(ClimbingStairs(6));

int ClimbingStairs(int n)
{
	if (n < 3)
	{
		return n;
	}

	var allWays = 0;
	var oneStep = 2;
	var twoSteps = 1;

	for (int i = 2; i < n; i++)
	{
		allWays = oneStep + twoSteps;
		twoSteps = oneStep;
		oneStep = allWays;
	}

	return allWays;
}