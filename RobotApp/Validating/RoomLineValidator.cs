namespace RobotApp.Validating;

public static class RoomLineValidator
{
    public static string? Validate(string line)
    {
        if (string.IsNullOrWhiteSpace(line) == false)
        {
            var lineItems = line.Trim().Split(" ");
            if (lineItems.Length == 2)
            {
                if (int.TryParse(lineItems[0], out int width) && int.TryParse(lineItems[1], out int height))
                {
                    if (width > 0 && height > 0)
                    {
                        return null;
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
                return "Please enter only 2 integers";
            }
        }
        else
        {
            return "Please enter a none empty line";
        }
    }
}
