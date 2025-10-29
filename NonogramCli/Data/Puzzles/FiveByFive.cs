using NonogramCli.Models;

namespace NonogramCli.Data.Puzzles;

internal static class FiveByFive
{
    public static List<Puzzle> Puzzles =
    [
        new()
        {
            Id = new Guid("9b01dfef-69f8-4692-b539-c295b7370e42"),
            IncrementalId = 1,
            Name = "Cup",
            Rows =
            [
                [ false, true, false, true, true ],
                [ false, true, true, true, true ],
                [ false, true, true, true, true ],
                [ false, false, true, false, false ],
                [ false, true, true, true, false ],
            ]
        },
        new()
        {
            Id = new Guid("6600df7c-f8f6-4f7f-b675-447eb0fe8e11"),
            IncrementalId = 2,
            Name = "Heart",
            Rows =
            [
                [ false, true, false, true, false ],
                [ true, true, true, true, true ],
                [ true, true, true, true, true ],
                [ false, true, true, true, false ],
                [ false, false, true, false, false ],
            ]
        },
        new()
        {
            Id = new Guid("7db0552c-3118-4269-8955-f9d8ec451fc6"),
            IncrementalId = 3,
            Name = "Rocket",
            Rows =
            [
                [ false, false, true, false, false ],
                [ false, true, true, true, false ],
                [ false, true, false, true, false ],
                [ true, true, true, true, true ],
                [ true, false, true, false, true ],
            ]
        },
        new()
        {
            Id = new Guid("3ce6164b-6539-4005-ba38-759762dfe0a7"),
            IncrementalId = 4,
            Name = "Tree",
            Rows =
            [
                [ false, false, false, true, false ],
                [ false, false, true, true, true ],
                [ false, false, false, true, false ],
                [ false, true, false, true, false ],
                [ true, true, true, true, true ],
            ]
        },
        new()
        {
            Id = new Guid("ab27f43a-f287-48fd-9060-09d48ba0ca2f"),
            IncrementalId = 5,
            Name = "Dog",
            Rows =
            [
                [ true, false, true, false, false ],
                [ true, true, true, false, true ],
                [ true, true, true, true, true ],
                [ true, true, true, true, true ],
                [ true, false, true, false, true ],
            ]
        }
    ];
}
