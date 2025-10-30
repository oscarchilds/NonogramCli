namespace NonogramCli.Models;

internal class Puzzle
{
    public required Guid Id { get; set; }
    public required int IncrementalId { get; set; }
    public required string Name { get; set; }
    public List<List<bool>> Rows { get; set; } = [];

    public List<int> GetYHints(int yIndex)
    {
        var column = Rows.Select(r => r[yIndex]).ToList();
        return GetHints(column);
    }

    public List<int> GetXHints(int xIndex)
    {
        var row = Rows[xIndex];
        return GetHints(row);
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
        if (result.Count == 0) result.Add(0);

        return result;
    }
}