var s = new[] { 'h', 'e', 'l', 'l', 'o' };
ReverseString(s);
Console.WriteLine(s);

void ReverseString(char[] s)
{
	var i = 0;
	var j = s.Length - 1;
	while (i < j)
	{
		var temp = s[i];
		s[i++] = s[j];
		s[j--] = temp;
	}
}