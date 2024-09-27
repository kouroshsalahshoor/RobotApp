using RobotApp.Validating;

namespace RobotApp.Tests.Validating;

public class PositionLineValidatorTests
{
    [Fact]
    public void ShouldReturnNoErrorForValidLine()
    {
        //arrange
        string validLine = "1 2 N";

        //act
        string? error = PositionLineValidator.Validate(validLine);

        //assert
        Assert.Null(error);
    }

    [Theory]
    [InlineData("", "Please enter a none empty line")]
    [InlineData("   ", "Please enter a none empty line")]
    [InlineData("5", "Please enter only 3 values: 2 integers and an orientation: N|S|E|W")]
    [InlineData("5 5", "Please enter only 3 values: 2 integers and an orientation: N|S|E|W")]
    [InlineData("5 5 5 5", "Please enter only 3 values: 2 integers and an orientation: N|S|E|W")]
    [InlineData("5 x 5", "Please enter 2 integers")]
    [InlineData("-5 5 5", "Please enter 2 positive integers")]
    [InlineData("5 5 5", "Please enter an orientation: N|S|E|W")]
    public void ShouldReturnErrorForInvalidLine(string line, string expectedError)
    {
        //arrange

        //act
        string? error = PositionLineValidator.Validate(line);

        //assert
        Assert.NotNull(error);
        Assert.Equal(expectedError, error);
    }
}
