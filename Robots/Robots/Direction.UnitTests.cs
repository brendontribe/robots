using Xunit;

namespace Robots.UnitTests
{
    public class Direction_UnitTests
    {
        private Direction.Facing facing;

        [Fact]
        public void CanRotateLeft()
        {
            facing = Direction.Facing.EAST;
            var result = Direction.Left(facing);
            Assert.Equal(Direction.Facing.NORTH, result);
        }

        [Fact]
        public void CanRotateRight()
        {
            facing = Direction.Facing.EAST;
            var result = Direction.Right(facing);
            Assert.Equal(Direction.Facing.SOUTH, result);
        }

        [Fact]
        public void CanLoopLeft()
        {
            facing = Direction.Facing.EAST;
            var result = facing;
            for (int i = 0; i < 9; i++)
            {
                result = Direction.Left(result);
            }
            Assert.Equal(Direction.Facing.NORTH, result);
        }

        [Fact]
        public void CanLoopRight()
        {
            facing = Direction.Facing.EAST;
            var result = facing;
            for (int i = 0; i < 9; i++)
            {
                result = Direction.Right(result);
            }
            Assert.Equal(Direction.Facing.SOUTH, result);
        }
    }
}
