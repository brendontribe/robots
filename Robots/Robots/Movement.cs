namespace Robots
{
    static class Movement
    {
        public static Coords Move(Table table, Coords coords, Direction.Facing facing)
        {
            Coords newCoords = NewCoords(coords, facing);
            if (table.IsOnBoard(newCoords)) return newCoords;
            else return coords;
        }

        private static Coords NewCoords(Coords coords, Direction.Facing facing)
        {
            Coords newCoords = new Coords(coords.GetRow(), coords.GetCol());
            switch (facing)
            {
                case Direction.Facing.NORTH:
                    newCoords.SetRow(newCoords.GetRow() + 1);
                    break;
                case Direction.Facing.EAST:
                    newCoords.SetCol(newCoords.GetCol() + 1);
                    break;
                case Direction.Facing.SOUTH:
                    newCoords.SetRow(newCoords.GetRow() - 1);
                    break;
                case Direction.Facing.WEST:
                    newCoords.SetCol(newCoords.GetCol() - 1);
                    break;
                default:
                    break;
            }
            return newCoords;
        }
    }
}
