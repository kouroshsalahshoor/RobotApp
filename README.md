# RobotApp

## a programming assignment for DevoTeam

based on the description in: [robot-assignment-backend](https://github.com/kouroshsalahshoor/RobotApp/blob/master/RobotApp/robot-assignment-backend.md.pdf)

This program reads and validates 3 lines:
* Room line: the boundries of the plane that robot can move on like: 5 5
* Start position: where to start and orientation (N|S|E|W) like: 1 2 N
* commands: a string containing a series of 3 commands like: RFRFFRFRF
  * R: right
  * L: Left
  * F: Forward

The result of commands is printed on screen:
Report: {Position.X} {Position.Y} {Position.Orientation}
