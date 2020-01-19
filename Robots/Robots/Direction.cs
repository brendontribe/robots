using System;

namespace Robots
{
    class Direction
    {
        public enum Facing
        {
            NORTH,
            EAST,
            SOUTH,
            WEST
        }

        public static Facing Left(Facing facing)
        {
            return Rotate(facing, 3);
        }

        public static Facing Right(Facing facing)
        {
            return Rotate(facing, 1);
        }

        private static Facing Rotate(Facing facing, int rotation)
        {
            int facingAsInt = ((int)facing + rotation) % 4;
            return (Facing)facingAsInt;
        }

        public static Facing GetFacing(string direction)
        {
            return (Facing)Enum.Parse(typeof(Facing), direction);
        }
    }
}
