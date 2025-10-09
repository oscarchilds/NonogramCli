using NonogramCli.Models;

namespace NonogramCli.Data;

internal static class Puzzles
{
    public static Puzzle PuzzleOne = new()
    {
        Board = new Board()
        {
            Rows =
            [
                new Row { Cells = [ true, true, false, false, true ] },
                new Row { Cells = [ false, false, true, false, false ] },
                new Row { Cells = [ true, true, true, false, true ] },
                new Row { Cells = [ true, false, true, false, true ] },
                new Row { Cells = [ false, true, false, true, true ] },
            ]
        }
    };
}
