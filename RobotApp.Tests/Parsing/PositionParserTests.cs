using RobotApp.Parsing;

namespace RobotApp.Tests.Parsing
{
    public class PositionParserTests
    {
        [Fact]
        public void ShouldParseValidLine()
        {
            //arrange
            var validLine = "1 2 N";

            //act
            var position = PositionParser.Parse(validLine);
            
            //assert
        }
    }
}