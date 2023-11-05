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
        console.ReadLine().Returns(input);
        
        var ohce = new Ohce(console);
        
        // act
        ohce.Echo();
        
        // assert
        console.Received().WriteLine(output);
    }
}