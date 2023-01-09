using System.Text;

var solution = new Solution().AddBinary(
	"10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101",
	"110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011");
Console.WriteLine(solution);

public class Solution
{
	public string AddBinary(string a, string b)
	{
		var sb = new StringBuilder();
		var t = 0;
		for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0 || t > 0; i--, j--)
		{
			var av = i < 0 || a[i] == '0' ? 0 : 1;
			var bv = j < 0 || b[j] == '0' ? 0 : 1;
			sb.Insert(0, (av + bv + t) % 2);
			t = (av + bv + t) / 2;
		}

		return sb.ToString();
	}
}