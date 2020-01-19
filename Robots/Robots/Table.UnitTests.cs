using Xunit;

namespace Robots.UnitTests
{
    public class Table_UnitTests
    {
        Table table = new Table(5, 10);

        [Fact]
        public void IsOnTable()
        {
            var result = table.IsOnBoard(new Coords(0, 0));
            Assert.True(result);
            result = table.IsOnBoard(new Coords(0, 4));
            Assert.True(result);
            result = table.IsOnBoard(new Coords(4, 0));
            Assert.True(result);
            result = table.IsOnBoard(new Coords(4, 9));
            Assert.True(result);
        }

        [Fact]
        public void IsNotOnTable()
        {
            var result = table.IsOnBoard(new Coords(-1, 0));
            Assert.False(result);
            result = table.IsOnBoard(new Coords(0, -1));
            Assert.False(result);
            result = table.IsOnBoard(new Coords(5, 0));
            Assert.False(result);
            result = table.IsOnBoard(new Coords(0, 10));
            Assert.False(result);
        }
    }
}