using KataOhce;

public class MyConsole : IConsole
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }

    public void WriteLine(string output)
    {
        Console.WriteLine(output);
    }
}