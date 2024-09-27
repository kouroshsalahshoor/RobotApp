namespace RobotApp.Validating;

public static class CommandValidator
{
    public static string? Validate(string line)
    {
        if (string.IsNullOrWhiteSpace(line) == false)
        {
            char[] allowedChars = { 'R', 'L', 'F' };

            if (line.Trim().All(c => allowedChars.Contains(c)))
            {
                return null;
            }
            else
            {
                return "Please enter a Command: R|F|L";
            }
        }
        else
        {
            return "Please enter a none empty line";
        }
    }
}
