using System.Text;

string Convert(string s, int numRows)
{
	if (numRows == 1)
	{
		return s;
	}

	StringBuilder[] sb = new StringBuilder[numRows];
	for (int i = 0; i < sb.Length; i++)
	{
		sb[i] = new StringBuilder("");   //init every sb element **important step!!!!
	}
	int incre = 1;
	int index = 0;
	for (int i = 0; i < s.Length; i++)
	{
		sb[index].Append(s[i]);
		if (index == 0) { incre = 1; }
		if (index == numRows - 1) { incre = -1; }
		index += incre;
	}
	String re = "";
	for (int i = 0; i < sb.Length; i++)
	{
		re += sb[i];
	}
	return re.ToString();
}
}