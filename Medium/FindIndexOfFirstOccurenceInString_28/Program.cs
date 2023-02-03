var index = StrStr("satbutsad", "sad");
Console.WriteLine(index);

int StrStr(string haystack, string needle)
{
	for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
	{
		if (haystack[i] == needle[0] && haystack.Substring(i, needle.Length) == needle)
		{
			return i;
		}
	}

	return -1;
}