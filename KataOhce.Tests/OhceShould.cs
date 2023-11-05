using NSubstitute;

namespace KataOhce.Tests;

public class OhceShould
{
    [Theory]
    [InlineData("","")]
    [InlineData("a","a")]
    [InlineData("la","al")]
    [InlineData("las","sal")]
    [InlineData("alas","sala")]
    public void PrintReverseString(string input, string output)
    {
        // arrange
        var console = Substitute.For<IConsole>();
        var clock = Substitute.For<IClock>();
        console.ReadLine().Returns(input);
        
        var ohce = new Ohce(console, clock);
        
        // act
        ohce.Echo();
        
        // assert
        console.Received().WriteLine(output);
    }
    
    [Theory]
    [InlineData(10, "¡Buenos dias raul!")]
    public void PrintGreet(int hour, string output)
    {
        // arrange
        var console = Substitute.For<IConsole>();
        var clock = Substitute.For<IClock>();
        clock.GetHour().Returns(hour);
        var ohce = new Ohce(console, clock);
        
        // act
        ohce.Greet("raul");
        
        // assert
        console.Received().WriteLine(output);
    }
    
}