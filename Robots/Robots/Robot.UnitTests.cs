using Xunit;

namespace Robots.UnitTests
{
    public class Robot_UnitTests
    {
        Table table = new Table(5, 5);

        [Fact]
        public void CoordsSetWhenPlacedOnTable()
        {
            Robot robot = new Robot(table);
            robot.Place(3, 3, Direction.Facing.NORTH);
            Assert.Equal("Output: 3,3,NORTH", robot.Report());
        }

        [Fact]
        public void WillStopAtTableEdge()
        {
            Robot robot = new Robot(table);
            robot.Place(3, 3, Direction.Facing.EAST);
            robot.Move();
            robot.Move();
            Assert.Equal("Output: 4,3,EAST", robot.Report());
        }
        [Fact]
        public void CanMoveAroundTable()
        {
            Robot robot = new Robot(table);
            robot.Place(3, 3, Direction.Facing.EAST);
            robot.Move();
            robot.Move();
            robot.Left();
            robot.Move();
            robot.Left();
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Right();
            robot.Move();
            Assert.Equal("Output: 1,4,NORTH", robot.Report());
        }
    }
}
