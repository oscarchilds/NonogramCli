
using NonogramCli.Models;

namespace NonogramCli.Data.Puzzles;

internal static class TenByTen
{
    public static List<Puzzle> Puzzles =
    [
        new()
        {
            Id = new Guid("2d3c7f8e-1dde-4e96-8452-9b56b25f40ad"),
            IncrementalId = 1,
            Name = "Plant",
            Rows =
            [
                [ false, false, false, false, true, true, false, false, false, false ],
                [ false, false, false, true, true, true, true, false, false, false ],
                [ false, false, false, true, true, true, true, false, false, false ],
                [ false, false, false, false, true, true, false, false, false, false ],
                [ false, false, false, false, false, true, false, false, false, false ],
                [ false, false, false, false, true, true, true, false, false, false ],
                [ false, false, false, false, false, true, false, false, false, false ],
                [ false, true, true, true, true, true, true, true, true, false ],
                [ false, false, true, true, true, true, true, true, false, false ],
                [ false, false, true, true, true, true, true, true, false, false ]
            ]
        },
        new()
        {
            Id = new Guid("01c9484b-4931-4b66-b217-a2a6811a3b97"),
            IncrementalId = 2,
            Name = "Skyline",
            Rows =
            [
                [ false, false, false, false, false, false, false, false, false, false ],
                [ false, false, false, false, true, true, false, false, false, false ],
                [ true, true, false, false, true, true, true, false, false, false ],
                [ true, true, false, false, true, false, true, false, true, true ],
                [ true, true, true, true, true, true, true, false, true, true ],
                [ false, false, true, true, true, false, true, true, true, false ],
                [ true, true, true, true, true, true, true, true, true, true ],
                [ false, false, true, true, true, false, true, true, true, false ],
                [ true, true, true, true, true, true, true, true, true, true ],
                [ true, true, true, true, true, true, true, true, true, true ]
            ]
        },
    ];
}
