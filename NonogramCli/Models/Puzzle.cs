namespace NonogramCli.Models;

internal class Puzzle
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public List<PuzzleRow> Rows { get; set; } = [];

    public List<int> GetYHints(int yIndex)
    {
        var column = Rows.Select(r => r.Cells[yIndex]).ToList();
        return GetHints(column);
    }

    public List<int> GetXHints(int xIndex)
    {
        var row = Rows[xIndex];
        return GetHints(row.Cells);
    }

    private static List<int> GetHints(List<bool> cells)
    {
        var result = new List<int>();
        var currentCount = 0;

        foreach (var cell in cells)
        {
            if (cell) currentCount++;
            else if (currentCount > 0)
            {
                result.Add(currentCount);
                currentCount = 0;
            }
        }

        if (currentCount > 0) result.Add(currentCount);

        return result;
    }
}

internal class PuzzleRow
{
    public List<bool> Cells { get; set; } = [];
}
