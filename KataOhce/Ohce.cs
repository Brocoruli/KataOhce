using Microsoft.VisualBasic;

namespace KataOhce;

public class Ohce
{
    private readonly IConsole _console;

    public Ohce(IConsole console, IClock clock)
    {
        _console = console;
    }

    public void Echo()
    {
        var readLine = _console.ReadLine();
        _console.WriteLine(Strings.StrReverse(readLine));
    }

    public void Greet(string arg)
    {
        throw new NotImplementedException();
    }
}