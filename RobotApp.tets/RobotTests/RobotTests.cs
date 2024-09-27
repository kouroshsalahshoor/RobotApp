using RobotApp.Models;
using RobotApp.Parsing;

namespace RobotApp.Tests.RobotTests;

public class RobotTests
{
    private Robot _robot;
    public RobotTests()
    {
        _robot = new();

        _robot.Room = new Room(1, 1);

        _robot.Position = new Position(0, 0, "N");
    }
    [Fact]
    public void SubX_ShouldThrowException_IfPositionOutofBound()
    {
        //arrange

        //act

        //assert
        var exception = Assert.Throws<Exception>(() => _robot.SubX());
        Assert.Equal("X can not be negative", exception.Message);
    }

    [Fact]
    public void SubY_ShouldThrowException_IfPositionOutofBound()
    {
        //arrange

        //act

        //assert
        var exception = Assert.Throws<Exception>(() => _robot.SubY());
        Assert.Equal("Y can not be negative", exception.Message);
    }

    [Fact]
    public void AddX_ShouldThrowException_IfPositionOutofBound()
    {
        //arrange

        //act

        //assert
        var exception = Assert.Throws<Exception>(() => _robot.AddX());
        Assert.Equal("X can not be greater than rooms Width", exception.Message);
    }

    [Fact]
    public void AddY_ShouldThrowException_IfPositionOutofBound()
    {
        //arrange

        //act

        //assert
        var exception = Assert.Throws<Exception>(() => _robot.AddY());
        Assert.Equal("Y can not be greater than rooms Height", exception.Message);
    }
}
