namespace Robots
{
    internal class Table
    {
        private int rows;
        private int columns;

        public Table(int r, int c)
        {
            rows = r;
            columns = c;
        }

        public bool IsOnBoard(Coords coords)
        {
            return (
                   coords.GetCol() < columns
                && coords.GetCol() >= 0
                && coords.GetRow() < rows
                && coords.GetRow() >= 0
                );
        }
    }
}