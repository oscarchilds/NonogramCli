using NonogramCli.Data.Puzzles;
using NonogramCli.Models;
using Spectre.Console;

namespace NonogramCli.Features;

internal class MainMenu
{
    internal static void Start()
    {
        Console.Clear();

        var playing = true;

        var menu = new Menu<Action>
        {
            Title = "Nonogram CLI",
            Choices =
            [
                (Play, "Play"),
                (() => playing = false, "Quit"),
            ]
        };

        while (playing)
        {
            var action = menu.Prompt();
            action();
        }

        Console.WriteLine("Thanks for playing!");
    }

    private static void Play()
    {
        var menu = new Menu<List<Puzzle>>
        {
            Title = "Catagory",
            Choices =
            [
                (FiveByFive.Puzzles, "5x5"),
                (TenByTen.Puzzles, "10x10")
            ]
        };

        var puzzles = menu.Prompt();
        var puzzle = ChoosePuzzle(puzzles);
        var game = new Game(puzzle);
        game.Start();
    }

    private static Puzzle ChoosePuzzle(List<Puzzle> puzzles)
    {
        var menu = new Menu<Puzzle>
        {
            Title = "Select a puzzle to play",
            Choices = [.. puzzles.Select(x => (x, x.IncrementalId.ToString()))]
        };

        return menu.Prompt();
    }
}
