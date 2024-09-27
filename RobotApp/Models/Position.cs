using RobotApp.Models.Enums;

namespace RobotApp.Models;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }
    public Orientation Orientation { get; set; }

    public Position()
    {
        
    }

    public Position(int x, int y, string orientation)
    {
        X= x;
        Y = y;
        Orientation = (Orientation)Enum.Parse(typeof(Orientation), orientation);
    }
}
