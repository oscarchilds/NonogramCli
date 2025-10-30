namespace NonogramCli.Models;

internal class Board
{
    public List<List<CellStatus>> Rows = [];
    public int Size => Rows.Count;

    public bool IsComplete(Puzzle puzzle)
    {
        if (Rows.Count != puzzle.Rows.Count)
            return false;

        for (int i = 0; i < Rows.Count; i++)
        {
            var rowA = Rows[i];
            var rowB = puzzle.Rows[i];

            if (rowA.Count != rowB.Count)
                return false;

            for (int j = 0; j < rowA.Count; j++)
            {
                var cellIsFilled = rowA[j] == CellStatus.Filled;

                if (cellIsFilled != rowB[j])
                    return false;
            }
        }

        return true;
    }
}
