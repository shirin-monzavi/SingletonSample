namespace SingletonSample;

public class Singleton
{
    private static Singleton _instance;

    private static readonly object _instanceLock = new object();

    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (_instance is null)
        {
            lock (_instanceLock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                }
            }
        }

        return _instance;
    }

    public void DoSomething()
    {
        Console.WriteLine("Iam doing something.");
    }
}
