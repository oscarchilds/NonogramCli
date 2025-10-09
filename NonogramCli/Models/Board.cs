namespace NonogramCli.Models;

internal class Board : IEquatable<Board>
{
    public List<Row> Rows = [];

    public bool Equals(Board? other)
    {
        if (other is null)
            return false;

        if (ReferenceEquals(this, other))
            return true;

        if (Rows.Count != other.Rows.Count)
            return false;

        for (int i = 0; i < Rows.Count; i++)
        {
            var rowA = Rows[i];
            var rowB = other.Rows[i];

            if (rowA.Cells.Count != rowB.Cells.Count)
                return false;

            for (int j = 0; j < rowA.Cells.Count; j++)
            {
                if (rowA.Cells[j] != rowB.Cells[j])
                    return false;
            }
        }

        return true;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Board);
    }

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

    private List<int> GetHints(List<bool> cells)
    {
        var result = new List<int>();
        var currentCount = 0;

        foreach (var value in cells)
        {
            if (value) currentCount++;
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

internal class Row
{
    public List<bool> Cells = [];
}
