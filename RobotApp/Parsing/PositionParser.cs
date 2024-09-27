using RobotApp.Models;
using RobotApp.Models.Enums;

namespace RobotApp.Parsing;

public class PositionParser
{
    public static Position Parse(string? validLine)
    {
        Position position = new();

        var lineItems = validLine!.Split(" ");

        position.X = int.Parse(lineItems[0]);
        position.Y = int.Parse(lineItems[1]);
        position.Orientation = (Orientation)Enum.Parse(typeof(Orientation), lineItems[2]);

        return position;
    }
}
