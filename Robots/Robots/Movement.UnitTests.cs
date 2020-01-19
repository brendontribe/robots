using Xunit;

namespace Robots.UnitTests
{
    public class Movement_UnitTests
    {
        Table table = new Table(5, 5);

        [Fact]
        public void CanMoveForward()
        {
            var result = Movement.Move(table, new Coords(2, 2), Direction.Facing.EAST);
            Assert.Equal(result.GetCol(), new Coords(2, 3).GetCol());
            Assert.Equal(result.GetRow(), new Coords(2, 3).GetRow());
        }

        [Fact]
        public void WillStopAtRightEdge()
        {
            var result = Movement.Move(table, new Coords(2, 4), Direction.Facing.EAST);
            Assert.Equal(result.GetCol(), new Coords(2, 4).GetCol());
            Assert.Equal(result.GetRow(), new Coords(2, 4).GetRow());
        }

        [Fact]
        public void WillStopAtLeftEdge()
        {
            var result = Movement.Move(table, new Coords(2, 0), Direction.Facing.WEST);
            Assert.Equal(result.GetCol(), new Coords(2, 0).GetCol());
            Assert.Equal(result.GetRow(), new Coords(2, 0).GetRow());
        }

        [Fact]
        public void WillStopAtTopEdge()
        {
            var result = Movement.Move(table, new Coords(4, 2), Direction.Facing.NORTH);
            Assert.Equal(result.GetCol(), new Coords(4, 2).GetCol());
            Assert.Equal(result.GetRow(), new Coords(4, 2).GetRow());
        }

        [Fact]
        public void WillStopAtBottomEdge()
        {
            var result = Movement.Move(table, new Coords(0, 2), Direction.Facing.SOUTH);
            Assert.Equal(result.GetCol(), new Coords(0, 2).GetCol());
            Assert.Equal(result.GetRow(), new Coords(0, 2).GetRow());
        }
    }
}