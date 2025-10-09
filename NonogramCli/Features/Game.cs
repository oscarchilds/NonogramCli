using NonogramCli.Data;
using NonogramCli.Models;

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

            for (var x = 0; x < 3; x++)
            {
                Console.Write("         ");
                for (var r = 0; r < GameState.Board.Rows.Count; r++)
                {
                    Console.Write($" {GameState.Puzzle.Board.GetYHints(r).ElementAtOrDefault(x)} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (var r = 0; r < GameState.Board.Rows.Count; r++)
            {
                for (var x = 0; x < 3; x++)
                {
                    Console.Write($" {GameState.Puzzle.Board.GetXHints(r).ElementAtOrDefault(x)} ");
                }

                var row = GameState.Board.Rows[r];

                for (var c = 0; c < row.Cells.Count; c++)
                {
                    if (GameState.PlayerXPos == c && GameState.PlayerYPos == r) Console.Write(" P ");
                    else if (row.Cells[c]) Console.Write(" ■ ");
                    else Console.Write(" . ");
                }

                Console.WriteLine();
            }
        }
    }
}
