namespace RobotApp.Models;

public class Robot
{
    public Room Room { get; set; } = new();
    public Position Position { get; set; } = new();

    public string Report()
    {
        return $"Report: {Position.X} {Position.Y} {Position.Orientation.ToString()}";
    }

    public void ExecuteCommands(string commands)
    {
        foreach (var command in commands.ToArray())
        {
            if (command == 'L')
            {
                L();
            }
            else if (command == 'R')
            {
                R();
            }
            else if (command == 'F')
            {
                F();
            }
        }
    }

    public void L()
    {
        if (Position.Orientation == Enums.Orientation.N)
        {
            Position.Orientation = Enums.Orientation.W;
        }
        else if (Position.Orientation == Enums.Orientation.S)
        {
            Position.Orientation = Enums.Orientation.E;
        }
        else if (Position.Orientation == Enums.Orientation.E)
        {
            Position.Orientation = Enums.Orientation.N;
        }
        else if (Position.Orientation == Enums.Orientation.W)
        {
            Position.Orientation = Enums.Orientation.S;
        }
    }

    public void R()
    {
        if (Position.Orientation == Enums.Orientation.N)
        {
            Position.Orientation = Enums.Orientation.E;
        }
        else if (Position.Orientation == Enums.Orientation.S)
        {
            Position.Orientation = Enums.Orientation.W;
        }
        else if (Position.Orientation == Enums.Orientation.E)
        {
            Position.Orientation = Enums.Orientation.S;
        }
        else if (Position.Orientation == Enums.Orientation.W)
        {
            Position.Orientation = Enums.Orientation.N;
        }
    }

    public void F()
    {
        if (Position.Orientation == Enums.Orientation.N)
        {
            SubY();
        }
        else if (Position.Orientation == Enums.Orientation.S)
        {
            AddY();
        }
        else if (Position.Orientation == Enums.Orientation.E)
        {
            AddX();
        }
        else if (Position.Orientation == Enums.Orientation.W)
        {
            SubX();
        }
    }

    public void SubX()
    {
        int x = Position.X - 1;
        if (x < 0)
        {
            throw new Exception("X can not be negative");
        }
        else
        {
            Position.X = x;
        }
    }

    public void AddX()
    {
        int x = Position.X + 1;
        if (x >= Room.Width)
        {
            throw new Exception("X can not be greater than rooms Width");
        }
        else
        {
            Position.X = x;
        }
    }

    public void AddY()
    {
        int y = Position.Y + 1;
        if (y >= Room.Height)
        {
            throw new Exception("Y can not be greater than rooms Height");
        }
        else
        {
            Position.Y = y;
        }
    }

    public void SubY()
    {
        int y = Position.Y - 1;
        if (y < 0)
        {
            throw new Exception("Y can not be negative");
        }
        else
        {
            Position.Y = y;
        }
    }
}
