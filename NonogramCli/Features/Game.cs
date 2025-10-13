using NonogramCli.Data;
using NonogramCli.Models;
using Spectre.Console;

namespace NonogramCli.Features
{
    internal class Game(Puzzle puzzle)
    {
        private readonly GameState GameState = new(puzzle);

        public void Start()
        {
            Render();

            var win = false;

            while (!win)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow) GameState.PlayerYPos--;
                if (key == ConsoleKey.DownArrow) GameState.PlayerYPos++;
                if (key == ConsoleKey.LeftArrow) GameState.PlayerXPos--;
                if (key == ConsoleKey.RightArrow) GameState.PlayerXPos++;

                if (key == ConsoleKey.Spacebar) GameState.SelectCurrentCell();
                if (key == ConsoleKey.X) GameState.RuleOutCurrentCell();

                if (key == ConsoleKey.Escape)
                {
                    break;
                }

                Render();
                win = GameState.CheckWin();
            }

            Console.WriteLine("Win!");
        }

        private void Render()
        {
            Console.Clear();

            Console.WriteLine("Move: Arrow keys");
            Console.WriteLine("Select: Space bar");
            Console.WriteLine();

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

                for (var c = 0; c < row.Cells.Count; c++)
                {
                    if (GameState.PlayerXPos == c && GameState.PlayerYPos == r) tableRow.Add("P");
                    else if (row.Cells[c] == CellStatus.Filled) tableRow.Add("■");
                    else if (row.Cells[c] == CellStatus.RuledOut) tableRow.Add("X");
                    else tableRow.Add("");
                }

                table.AddRow(tableRow.ToArray());
            }

            AnsiConsole.Write(table);
        }

        private static string GetFormattedHints(Func<int, List<int>> getHints, int i, string seperator)
        {
            var hints = getHints(i);
            return string.Join(seperator, hints.Select(h => h.ToString()).ToArray());
        }
    }
}
