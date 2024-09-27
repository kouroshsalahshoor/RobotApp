using RobotApp.Models;
using RobotApp.Parsing;

namespace RobotApp.Tests.Parsing;

public class RoomParserTests
{
    [Fact]
    public void ShouldParseValidLine()
    {
        //arrange
        string validLine = "5 5";

        int expectedHeightValue = 5;
        int expectedWidthValue = 5;

        //act
        Room room = RoomParser.Parse(validLine);
        
        //assert
        Assert.NotNull(room);
        Assert.Equal(expectedHeightValue, room.Height);
        Assert.Equal(expectedWidthValue, room.Width);
    }
}