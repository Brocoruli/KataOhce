using NSubstitute;

namespace KataOhce.Tests;

public class OhceShould
{
    [Theory]
    [InlineData("","")]
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