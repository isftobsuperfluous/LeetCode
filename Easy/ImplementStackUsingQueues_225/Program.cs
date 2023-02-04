var stack = new MyStack();
stack.Push(1);
stack.Push(2);
var top1 = stack.Top();
stack.Push(3);
var top2 = stack.Top();
Console.WriteLine(top1);
Console.WriteLine(top2);

public class MyStack
{
	private readonly Queue<int> firstQueue;
	private readonly Queue<int> secondQueue;

	public MyStack()
	{
		firstQueue = new Queue<int>();
		secondQueue = new Queue<int>();
	}

	public void Push(int x)
	{
		if (firstQueue.Count == 0)
		{
			firstQueue.Enqueue(x);
		}
		else
		{
			secondQueue.Enqueue(x);
		}
	}

	public int Pop()
	{
		if (secondQueue.Count == 0)
		{
			while (firstQueue.Count != 1)
			{
				secondQueue.Enqueue(firstQueue.Dequeue());
			}

			var lastInFirst = firstQueue.Dequeue();

			return lastInFirst;
		}

		while (secondQueue.Count != 1)
		{
			firstQueue.Enqueue(secondQueue.Dequeue());
		}

		var lastInSecond = secondQueue.Dequeue();

		return lastInSecond;
	}

	public int Top()
	{
		if (secondQueue.Count == 0)
		{
			while (firstQueue.Count != 1)
			{
				secondQueue.Enqueue(firstQueue.Dequeue());
			}

			var lastInFirst = firstQueue.Dequeue();
			secondQueue.Enqueue(lastInFirst);

			return lastInFirst;
		}

		while (secondQueue.Count != 1)
		{
			firstQueue.Enqueue(secondQueue.Dequeue());
		}

		var lastInSecond = secondQueue.Dequeue();
		firstQueue.Enqueue(lastInSecond);

		return lastInSecond;
	}

	public bool Empty()
	{
		return firstQueue.Count == 0 && secondQueue.Count == 0;
	}
}