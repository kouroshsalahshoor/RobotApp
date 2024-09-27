using RobotApp.Validating;

namespace RobotApp.LineReading;

public class CommandLineReader
{
    public static string GetValidLine()
    {
        var message = "Please enter a valid command line like: RFRFFRFRF";
        Console.WriteLine(message);

        string? line = null;
        var isValid = false;

        isValid = false;
        while (isValid == false)
        {
            line = Console.ReadLine();
            var error = CommandValidator.Validate(line!);
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
