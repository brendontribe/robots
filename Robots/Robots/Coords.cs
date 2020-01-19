namespace Robots
{
    class Coords
    {
        private int Row;
        private int Col;

        public Coords(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int GetRow()
        {
            return Row;
        }

        public int GetCol()
        {
            return Col;
        }

        public void SetRow(int row)
        {
            Row = row;
        }

        public void SetCol(int col)
        {
            Col = col;
        }
    }
}