int FirstBadVersion(int n)
{
	var mid = (1 + n) / 2;
	var m = mid;
	while (IsBadVersion(mid) && mid != 0)
	{
		mid--;
	}
	if (mid != 0 && m != mid)
	{
		return mid + 1;
	}
	while (IsBadVersion(n))
	{
		n--;
	}

	return n + 1;
}