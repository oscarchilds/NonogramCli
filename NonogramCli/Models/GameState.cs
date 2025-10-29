namespace NonogramCli.Models;

internal class GameState
{
    public int PlayerXPos;
    public int PlayerYPos;
    public Board Board = new();
    public List<Row> Rows = [];
    public Puzzle Puzzle;

    public GameState(Puzzle puzzle)
    {
        Puzzle = puzzle;
        PlayerXPos = 0;
        PlayerYPos = 0;

        Board.Rows = [.. puzzle.Rows.Select(x => new Row
        {
            Cells = [.. x.Select(x => CellStatus.Empty) ]
        })];
    }

    public void SelectCurrentCell() => SetCellStatus(CellStatus.Filled);

    public void RuleOutCurrentCell() => SetCellStatus(CellStatus.RuledOut);

    private void SetCellStatus(CellStatus newStatus)
    {
        var x = PlayerXPos;
        var y = PlayerYPos;

        if (y < 0 || y >= Board.Rows.Count) return;
        if (x < 0 || x >= Board.Rows[y].Cells.Count) return;

        if (Board.Rows[y].Cells[x] == newStatus)
        {
            Board.Rows[y].Cells[x] = CellStatus.Empty;
        }
        else
        {
            Board.Rows[y].Cells[x] = newStatus;
        }
    }

    public bool CheckWin()
    {
        return Board.IsComplete(Puzzle);
    }
}
