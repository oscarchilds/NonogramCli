using NonogramCli.Models;

namespace NonogramCli.Data;

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

        Board.Rows = [.. puzzle.Board.Rows.Select(x => new Row
        {
            Cells = [.. x.Cells.Select(x => false)]
        })];
    }

    public void SelectCurrentCell()
    {
        var x = PlayerXPos;
        var y = PlayerYPos;

        if (y < 0 || y >= Board.Rows.Count) return;
        if (x < 0 || x >= Board.Rows[y].Cells.Count) return;
        Board.Rows[y].Cells[x] = !Board.Rows[y].Cells[x];
    }

    public bool CheckWin()
    {
        return Board.Equals(Puzzle.Board);
    }
}
