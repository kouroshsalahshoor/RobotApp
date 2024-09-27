using RobotApp.LineReading;
using RobotApp.Models;
using RobotApp.Parsing;

Console.WriteLine("-----------");
Console.WriteLine(" Robot App ");
Console.WriteLine("-----------");
Console.WriteLine();

Robot robot = new();

var validRoomLine = RoomLineReader.GetValidLine();
robot.Room = RoomParser.Parse(validRoomLine);

var validStartLine = StartLineReader.GetValidLine();
robot.Position = PositionParser.Parse(validStartLine);

var validCommandLine = CommandLineReader.GetValidLine();

try
{
    robot.ExecuteCommands(validCommandLine);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine(robot.Report());
