namespace Singleton;


public class Singleton
{

    private static Singleton instance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

public static class Program
{
    static void Main(string[] args)
    {


        Singleton a1 = Singleton.GetInstance();

      

        Console.ReadLine();

    }
}