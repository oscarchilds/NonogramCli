using NonogramCli.Models;

namespace NonogramCli.Data;

internal static class Puzzles
{
    public static Puzzle PuzzleOne = new()
    {
        Name = "One",
        Rows =
        [
            new PuzzleRow { Cells = [ true, true, false, false, true ] },
            new PuzzleRow { Cells = [ true, false, true, false, true ] },
            new PuzzleRow { Cells = [ true, false, true, true, true ] },
            new PuzzleRow { Cells = [ true, true, false, false, false ] },
            new PuzzleRow { Cells = [ true, true, true, true, false ] },
        ]
    };

    public static Puzzle PuzzleTwo = new()
    {
        Name = "Two",
        Rows =
        [
            new PuzzleRow { Cells = [ false, true, false, true, false ] },
            new PuzzleRow { Cells = [ true, true, true, true, true ] },
            new PuzzleRow { Cells = [ true, true, true, true, true ] },
            new PuzzleRow { Cells = [ false, true, true, true, false ] },
            new PuzzleRow { Cells = [ false, false, true, false, false ] },
        ]
    };

    public static Puzzle PuzzleThree = new()
    {
        Name = "Three",
        Rows =
        [
            new PuzzleRow { Cells = [ true, true, false, false, true ] },
            new PuzzleRow { Cells = [ true, true, true, true, true ] },
            new PuzzleRow { Cells = [ false, true, true, false, true ] },
            new PuzzleRow { Cells = [ false, true, true, true, true ] },
            new PuzzleRow { Cells = [ true, true, false, false, true ] },
        ]
    };

    public static Puzzle PuzzleFour = new()
    {
        Name = "Four",
        Rows =
        [
            new PuzzleRow { Cells = [ true, true, true, true, false ] },
            new PuzzleRow { Cells = [ true, false, false, true, true ] },
            new PuzzleRow { Cells = [ true, false, true, true, true ] },
            new PuzzleRow { Cells = [ true, false, false, false, true ] },
            new PuzzleRow { Cells = [ false, true, true, true, false ] },
        ]
    };

    public static Puzzle PuzzleFive = new()
    {
        Name = "Five",
        Rows =
        [
            new PuzzleRow { Cells = [ true,  false, false, false, true ] },
            new PuzzleRow { Cells = [ true,  true,  false, false, false ] },
            new PuzzleRow { Cells = [ true,  true,  true,  false, false ] },
            new PuzzleRow { Cells = [ true,  true,  true,  true,  false ] },
            new PuzzleRow { Cells = [ true,  true,  true,  true,  true  ] },
        ]
    };
}

