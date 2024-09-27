namespace RobotApp.Models;

public class Room
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Room()
    {
        Height = 0;
        Width = 0;
    }

    public Room(int height, int width)
    {
        Height = height; 
        Width = width;
    }
}
