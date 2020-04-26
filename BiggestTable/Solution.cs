namespace BiggestTable
{
    public class Solution
    {
        public static int BiggestTable(char[][] grid)
        {
            int biggestTableArea = 0;
            for (int rowIndex = 0; rowIndex < grid.Length; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < grid[0].Length; columnIndex++)
                {
                    int biggetTableHere = BiggestTableAt(rowIndex, columnIndex, grid);
                    if (biggetTableHere > biggestTableArea)
                        biggestTableArea = biggetTableHere;
                }
            }
            return biggestTableArea;
        }

        private static int BiggestTableAt(int rowIndex, int columnIndex, char[][] grid)
        {
            int biggestTableArea = 0;
            for (int width = 1; width <= (grid.Length - rowIndex); width++)
            {
                for (int height = 1; height <= (grid[0].Length - columnIndex); height++)
                {
                    int tableArea = width * height;
                    if (IsTable(rowIndex, columnIndex, width, height, grid) && tableArea > biggestTableArea)
                        biggestTableArea = tableArea;
                }
            }
            return biggestTableArea;
        }

        private static bool IsTable(int startAtRow, int startAtColumn, int posibleWidth, int possibleHeight, char[][] grid)
        {
            for (int rowIndex = 0; rowIndex < posibleWidth; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < possibleHeight; columnIndex++)
                {
                    var horizontalPosition = rowIndex + startAtRow;
                    var verticalPosition = columnIndex + startAtColumn;
                    if (grid[horizontalPosition][verticalPosition] != '1')
                        return false;
                }
            }
            return true;
        }
    }
}
