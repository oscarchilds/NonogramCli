namespace NonogramCli.Models;

internal class Board
{
    public List<Row> Rows = [];
    public int Size => Rows.Count;

    public bool IsComplete(Puzzle puzzle)
    {
        if (Rows.Count != puzzle.Rows.Count)
            return false;

        for (int i = 0; i < Rows.Count; i++)
        {
            var rowA = Rows[i];
            var rowB = puzzle.Rows[i];

            if (rowA.Cells.Count != rowB.Count)
                return false;

            for (int j = 0; j < rowA.Cells.Count; j++)
            {
                var cellIsFilled = rowA.Cells[j] == CellStatus.Filled;

                if (cellIsFilled != rowB[j])
                    return false;
            }
        }

        return true;
    }
}

internal class Row
{
    public List<CellStatus> Cells = [];
}
