using System;

namespace Robots
{
    class Actor
    {
        protected Table table;
        protected Coords coords;
        protected Direction.Facing facing;

        public Actor(Table t)
        {
            table = t;
        }

        public void Place(int row, int column, Direction.Facing facing)
        {
            Coords coords = new Coords(row, column);
            if (table.IsOnBoard(coords))
            {
                this.coords = coords;
                this.facing = facing;
            }
            else
            {
                Console.WriteLine("Invalid Place Command - coordinates must be on the table");
            }
        }

        public void Left()
        {
            facing = Direction.Left(facing);
        }
        public void Right()
        {
            facing = Direction.Right(facing);
        }

        public void Move()
        {
            coords = Movement.Move(table, coords, facing);
        }
    }
}