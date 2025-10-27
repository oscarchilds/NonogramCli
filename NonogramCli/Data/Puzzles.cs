using NonogramCli.Models;

namespace NonogramCli.Data;

internal static class Puzzles
{
    public static Puzzle PuzzleOne = new()
    {
        Id = new Guid("9b01dfef-69f8-4692-b539-c295b7370e42"),
        Name = "Cup",
        Rows =
        [
            new PuzzleRow { Cells = [ false, true, false, true, true ] },
            new PuzzleRow { Cells = [ false, true, true, true, true ] },
            new PuzzleRow { Cells = [ false, true, true, true, true ] },
            new PuzzleRow { Cells = [ false, false, true, false, false ] },
            new PuzzleRow { Cells = [ false, true, true, true, false ] },
        ]
    };

    public static Puzzle PuzzleTwo = new()
    {
        Id = new Guid("6600df7c-f8f6-4f7f-b675-447eb0fe8e11"),
        Name = "Heart",
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
        Id = new Guid("7db0552c-3118-4269-8955-f9d8ec451fc6"),
        Name = "Rocket",
        Rows =
        [
            new PuzzleRow { Cells = [ false, false, true, false, false ] },
            new PuzzleRow { Cells = [ false, true, true, true, false ] },
            new PuzzleRow { Cells = [ false, true, false, true, false ] },
            new PuzzleRow { Cells = [ true, true, true, true, true ] },
            new PuzzleRow { Cells = [ true, false, true, false, true ] },
        ]
    };

    public static Puzzle PuzzleFour = new()
    {
        Id = new Guid("3ce6164b-6539-4005-ba38-759762dfe0a7"),
        Name = "Tree",
        Rows =
        [
            new PuzzleRow { Cells = [ false, false, false, true, false ] },
            new PuzzleRow { Cells = [ false, false, true, true, true ] },
            new PuzzleRow { Cells = [ false, false, false, true, false ] },
            new PuzzleRow { Cells = [ false, true, false, true, false ] },
            new PuzzleRow { Cells = [ true, true, true, true, true ] },
        ]
    };

    public static Puzzle PuzzleFive = new()
    {
        Id = new Guid("ab27f43a-f287-48fd-9060-09d48ba0ca2f"),
        Name = "Dog",
        Rows =
        [
            new PuzzleRow { Cells = [ true, false, true, false, false ] },
            new PuzzleRow { Cells = [ true, true, true, false, true ] },
            new PuzzleRow { Cells = [ true, true, true, true, true ] },
            new PuzzleRow { Cells = [ true, true, true, true, true ] },
            new PuzzleRow { Cells = [ true, false, true, false, true ] },
        ]
    };
}

