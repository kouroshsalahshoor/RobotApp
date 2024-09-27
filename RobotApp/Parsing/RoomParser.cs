using RobotApp.Models;

namespace RobotApp.Parsing
{
    public class RoomParser
    {
        public static Room Parse(string validLine)
        {
            var lineItems = validLine!.Split(" ");

            return new Room(int.Parse(lineItems[0]), int.Parse(lineItems[1]));
        }
    }
}
