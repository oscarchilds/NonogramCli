namespace NonogramCli.Models;

internal class GameState
{
    public int PlayerXPos;
    public int PlayerYPos;
    public Board Board = new();
    public Puzzle Puzzle;

    public GameState(Puzzle puzzle)
    {
        Puzzle = puzzle;
        PlayerXPos = 0;
        PlayerYPos = 0;

        SetupBoard();
    }

    public void SelectCurrentCell() => SetCellStatus(CellStatus.Filled);

    public void RuleOutCurrentCell() => SetCellStatus(CellStatus.RuledOut);

    private void SetCellStatus(CellStatus newStatus)
    {
        var x = PlayerXPos;
        var y = PlayerYPos;

        if (y < 0 || y >= Board.Rows.Count) return;
        if (x < 0 || x >= Board.Rows[y].Count) return;

        if (Board.Rows[y][x] == newStatus)
        {
            Board.Rows[y][x] = CellStatus.Empty;
        }
        else
        {
            Board.Rows[y][x] = newStatus;
        }
    }

    private void SetupBoard()
    {
        Board.Rows = Puzzle.Rows.Select(x => x.Select(y => CellStatus.Empty).ToList()).ToList();
    }

    public bool CheckWin()
    {
        return Board.IsComplete(Puzzle);
    }
}
