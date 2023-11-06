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
    [InlineData(18, "¡Buenas tardes raul!")]
    [InlineData(4, "¡Buenas noches raul!")]
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
    
    [Fact]
    public void PrintPalindromeAndGoodWord()
    {
        // arrange
        var console = Substitute.For<IConsole>();
        var clock = Substitute.For<IClock>();
        console.ReadLine().Returns("oto");
        
        var ohce = new Ohce(console, clock);
        
        // act
        ohce.Echo();
        console.ReadLine().Returns("Stop!");
        ohce.Echo();
        
        // assert
        Received.InOrder(() =>
        {
            console.WriteLine("oto");
            console.WriteLine("¡Bonita palabra!");
        });
    }
    
    [Fact]
    public void SayGoodBye()
    {
        // arrange
        var console = Substitute.For<IConsole>();
        var clock = Substitute.For<IClock>();
        var ohce = new Ohce(console, clock);
        
        // act
        ohce.Greet("raul");
        console.ReadLine().Returns("Stop!");
        ohce.Echo();
        
        // assert
        console.Received().WriteLine("Adios raul");
    }
}