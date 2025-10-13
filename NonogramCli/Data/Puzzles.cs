using NonogramCli.Models;

namespace NonogramCli.Data;

internal static class Puzzles
{
    public static Puzzle PuzzleOne = new()
    {
        Rows =
        [
            new PuzzleRow { Cells = [ true, true, false, false, true ] },
            new PuzzleRow { Cells = [ true, false, true, false, true ] },
            new PuzzleRow { Cells = [ true, false, true, true, true ] },
            new PuzzleRow { Cells = [ true, true, false, false, false ] },
            new PuzzleRow { Cells = [ true, true, true, true, false ] },
        ]
    };
}
