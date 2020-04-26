using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BiggestTable
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void First_Scenario()
        {
            char[][] matrix = new char[4][]
            {
                new char[]{ '1', '0', '1', '1', '1' },
                new char[]{ '1', '0', '1', '1', '1' },
                new char[]{ '1', '1', '1', '1', '1' },
                new char[]{ '1', '0', '0', '1', '0' },
            };
            var biggestTableArea = Solution.BiggestTable(matrix);
            Assert.AreEqual(9, biggestTableArea);
        }

        [TestMethod]
        public void Second_Scenario()
        {
            char[][] matrix = new char[4][]
            {
                new char[]{ '1', '0', '1', '1', '1', '0', '0', '1', '1', '1', '0', '0', '1', '0', '1' },
                new char[]{ '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '0', '1' },
                new char[]{ '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1' },
                new char[]{ '1', '0', '1', '1', '1', '1', '0', '0', '0', '1', '1', '0', '1', '1', '1' }
            };
            var biggestTableArea = Solution.BiggestTable(matrix);
            Assert.AreEqual(18, biggestTableArea);
        }
    }
}
