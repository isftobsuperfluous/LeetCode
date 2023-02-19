LRUCache obj = new LRUCache(2);
obj.Put(1, 1);
obj.Put(2, 2);
var g1 = obj.Get(1);
obj.Put(3, 3);
var g2 = obj.Get(2);
obj.Put(4, 4);
var g3 = obj.Get(1);
var g4 = obj.Get(3);
var g5 = obj.Get(4);
Console.WriteLine(g1);
Console.WriteLine(g2);
Console.WriteLine(g3);
Console.WriteLine(g4);
Console.WriteLine(g5);

class LRUCache
{
	private readonly int _capacity;
	private readonly Dictionary<int, int> _cache;
	private readonly List<int> _keys;

	public LRUCache(int capacity)
	{
		_cache = new Dictionary<int, int>(capacity);
		_capacity = capacity;
		_keys = new List<int>();
	}

	public int Get(int key)
	{
		if (_cache.ContainsKey(key))
		{
			_keys.Remove(key);
			_keys.Add(key);

			return _cache[key];
		}

		return -1;
	}

	public void Put(int key, int value)
	{
		if (_cache.Keys.Count == _capacity && !_cache.ContainsKey(key))
		{
			var first = _keys.First();
			_cache.Remove(first);
			_keys.Remove(first);
		}

		if (!_cache.TryAdd(key, value))
		{
			_cache[key] = value;
		}

		_keys.Remove(key);
		_keys.Add(key);
	}
}