var foo = new Foo();

var firstThread = new Thread(() => foo.First(() => Console.WriteLine("first")));
var secondThread = new Thread(() => foo.Second(() => Console.WriteLine("second")));
var thirdThread = new Thread(() => foo.Third(() => Console.WriteLine("third")));
firstThread.Start();
secondThread.Start();
thirdThread.Start();

public class Foo
{
	private readonly Semaphore _secondRun;
	private readonly Semaphore _thirdRun;

	public Foo()
	{
		_secondRun = new Semaphore(0, 3);
		_thirdRun = new Semaphore(0, 3);
	}

	public void First(Action printFirst)
	{
		printFirst();
		_secondRun.Release();
	}

	public void Second(Action printSecond)
	{
		_secondRun.WaitOne();
		printSecond();
		_thirdRun.Release();
	}

	public void Third(Action printThird)
	{
		_thirdRun.WaitOne();
		printThird();
	}
}