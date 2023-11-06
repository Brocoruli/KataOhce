using Microsoft.VisualBasic;

namespace KataOhce;

public class Ohce
{
    private readonly IConsole _console;
    private string _name;
    private IClock _clock;

    public Ohce(IConsole console, IClock clock)
    {
        _console = console;
        _clock = clock;
    }

    public void Echo()
    {
        var readLine = _console.ReadLine();
        PrintPalindrome(readLine);
        SayGoodBye(readLine);
    }
    
    private void SayGoodBye(string readLine)
    {
        if (readLine.Equals("Stop!"))
        {
            _console.WriteLine("Adios " + _name);
            
        }
    }
    
    private void PrintPalindrome(string readLine)
    {
        _console.WriteLine(Strings.StrReverse(readLine));

        if (readLine.Equals(Strings.StrReverse(readLine)))
        {
            _console.WriteLine("¡Bonita palabra!");
        }
    }

    public void Greet(string arg)
    {
        _name = arg;
        var hour = _clock.GetHour();
        if (hour > 6 && hour <= 12)
        {
            _console.WriteLine("¡Buenos dias " + _name + "!");
        }
        else if (hour > 12 && hour <= 20)
        {
            _console.WriteLine("¡Buenas tardes " + _name + "!");
        }
        else
        {
            _console.WriteLine("¡Buenas noches " + _name + "!");
        }
    }
}