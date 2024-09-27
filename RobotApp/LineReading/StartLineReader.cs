using RobotApp.Validating;

namespace RobotApp.LineReading;

public class StartLineReader
{
    public static string GetValidLine()
    {
        var message = "Please enter a valid start position like: 1 2 N";
        Console.WriteLine(message);

        string? line = null;
        var isValid = false;

        while (isValid == false)
        {
            line = Console.ReadLine();
            var error = PositionLineValidator.Validate(line!);
            if (error is null)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        return line!;
    }
}
