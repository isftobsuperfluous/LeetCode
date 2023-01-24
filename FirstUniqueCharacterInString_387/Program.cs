Console.WriteLine(new Solution().FirstUniqChar("loveleetcode"));


public class Solution
{
	public int FirstUniqChar(string s)
	{
		var storage = new Dictionary<char, StorageValue>();
		for (int i = 0; i < s.Length; i++)
		{
			if (!storage.TryAdd(s[i], new StorageValue(1, i)))
			{
				storage[s[i]].Count++;
			}
		}

		var nonRepeating = storage.FirstOrDefault(x => x.Value.Count == 1);
		return nonRepeating.Value is null ? -1 : nonRepeating.Value.Index;
	}

	public class StorageValue
	{
		public int Count { get; set; }
		public int Index { get; set; }

		public StorageValue(int count, int index)
		{
			Count = count;
			Index = index;
		}
	}
}