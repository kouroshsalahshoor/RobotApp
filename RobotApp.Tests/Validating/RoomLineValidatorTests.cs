using RobotApp.Validating;

namespace RobotApp.Tests.Validating;

public class RoomLineValidatorTests
{
    [Fact]
    public void ShouldReturnNoErrorForValidLine()
    {
        //arrange
        string validLine = "5 5";

        //act
        string? error = RoomLineValidator.Validate(validLine);

        //assert
        Assert.Null(error);
    }

    [Theory]
    [InlineData("", "Please enter a none empty line")]
    [InlineData("  ", "Please enter a none empty line")]
    [InlineData("5 5 5", "Please enter only 2 integers")]
    [InlineData("5 x", "Please enter 2 integers")]
    [InlineData("-5 5", "Please enter 2 positive integers")]
    public void ShouldReturnErrorForInvalidLine(string line, string expectedError)
    {
        //arrange

        //act
        string? error = RoomLineValidator.Validate(line);

        //assert
        Assert.NotNull(error);
        Assert.Equal(expectedError, error);
    }
}
