using RobotApp.Models.Enums;

namespace RobotApp.Validating;

public static class PositionLineValidator
{
    public static string? Validate(string line)
    {
        if (string.IsNullOrWhiteSpace(line) == false)
        {
            var lineItems = line.Trim().Split(" ");
            if (lineItems.Length == 3)
            {
                if (int.TryParse(lineItems[0], out int x) && int.TryParse(lineItems[1], out int y))
                {
                    if (x >= 0 && y >= 0)
                    {
                        if (lineItems[2] == "N" || lineItems[2] == "S" || lineItems[2] == "E" || lineItems[2] == "W")
                        {
                            return null;
                        }
                        else
                        {
                            return "Please enter an orientation: N|S|E|W";
                        }
                    }
                    else
                    {
                        return "Please enter 2 positive integers";
                    }
                }
                else
                {
                    return "Please enter 2 integers";
                }
            }
            else
            {
                return "Please enter only 3 values: 2 integers and an orientation: N|S|E|W";
            }
        }
        else
        {
            return "Please enter a none empty line";
        }
    }
}
