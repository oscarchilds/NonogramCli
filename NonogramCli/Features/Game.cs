using NonogramCli.Models;
using Spectre.Console;

namespace NonogramCli.Features;

internal class Game(Puzzle puzzle)
{
    private readonly GameState GameState = new(puzzle);

    internal void Start()
    {
        Console.Clear();

        Console.WriteLine("Move: Arrow keys");
        Console.WriteLine("Select: Space bar");
        Console.WriteLine("Rule out a cell: X");
        Console.WriteLine("Quit: Q");
        Console.WriteLine();

        var table = CreateTable();

        AnsiConsole.Live(table)
            .Start(ctx =>
            {
                var playing = true;
                ctx.Refresh();

                while (playing)
                {
                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.UpArrow || key == ConsoleKey.K) GameState.PlayerYPos = Math.Max(GameState.PlayerYPos - 1, 0);
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.J) GameState.PlayerYPos = Math.Min(GameState.PlayerYPos + 1, GameState.Board.Size - 1);
                    else if (key == ConsoleKey.LeftArrow || key == ConsoleKey.H) GameState.PlayerXPos = Math.Max(GameState.PlayerXPos - 1, 0);
                    else if (key == ConsoleKey.RightArrow || key == ConsoleKey.L) GameState.PlayerXPos = Math.Min(GameState.PlayerXPos + 1, GameState.Board.Size - 1);

                    else if (key == ConsoleKey.Spacebar) GameState.SelectCurrentCell();
                    else if (key == ConsoleKey.X) GameState.RuleOutCurrentCell();

                    else if (key == ConsoleKey.Escape || key == ConsoleKey.Q)
                    {
                        playing = false;
                    }

                    UpdateTable(table);
                    ctx.Refresh();

                    if (GameState.CheckWin())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Win! Press any key to continue");
                        Console.ReadKey();
                        playing = false;
                    }
                }
            });
    }

    private Table CreateTable()
    {
        var table = new Table();
        table.ShowRowSeparators();
        table.AddColumn("");

        for (var r = 0; r < GameState.Board.Rows.Count; r++)
        {
            var hints = GetFormattedHints(GameState.Puzzle.GetYHints, r, "\n");
            table.AddColumn(hints);
        }

        for (var r = 0; r < GameState.Board.Rows.Count; r++)
        {
            var tableRow = new List<string>();

            var hints = GetFormattedHints(GameState.Puzzle.GetXHints, r, " ");
            tableRow.Add(hints);

            var row = GameState.Board.Rows[r];

            foreach (var cell in row.Cells)
            {
                tableRow.Add("");
            }

            table.AddRow(tableRow.ToArray());
        }

        UpdateTable(table);
        return table;
    }

    private static string GetFormattedHints(Func<int, List<int>> getHints, int i, string seperator)
    {
        var hints = getHints(i);
        return string.Join(seperator, hints.Select(h => h.ToString()).ToArray());
    }

    private void UpdateTable(Table table)
    {
        for (var y = 0; y < GameState.Board.Rows.Count; y++)
        {
            var row = GameState.Board.Rows[y];
            for (var x = 0; x < row.Cells.Count; x++)
            {
                var newValue = "";

                if (GameState.PlayerXPos == x && GameState.PlayerYPos == y) newValue = "P";
                else if (row.Cells[x] == CellStatus.Filled) newValue = "■";
                else if (row.Cells[x] == CellStatus.RuledOut) newValue = "X";

                table.UpdateCell(y, x + 1, newValue);
            }
        }
    }
}
