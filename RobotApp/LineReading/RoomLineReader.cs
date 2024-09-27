using RobotApp.Validating;

namespace RobotApp.LineReading;

public class RoomLineReader
{
    public static string GetValidLine()
    {
        var message = "Please enter a valid room like: 5 5";
        Console.WriteLine(message);

        string? line = null;
        bool isValid = false;

        while (isValid == false)
        {
            line = Console.ReadLine();
            var error = RoomLineValidator.Validate(line!);
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
