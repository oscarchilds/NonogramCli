using NonogramCli.Data;
using NonogramCli.Data.Puzzles;
using NonogramCli.Models;
using Spectre.Console;

namespace NonogramCli.Features;

internal class Menu
{
    internal static void Start()
    {
        Console.Clear();

        var playing = true;

        while (playing)
        {
            Console.Clear();

            var menuPrompt = new SelectionPrompt<(MenuOptions Value, string Label)>()
                .Title("Nonogram CLI")
                .AddChoices(
                [
                    (MenuOptions.Play, "Play"),
                    (MenuOptions.Quit, "Quit"),
                ]);

            menuPrompt.Converter = new Func<(MenuOptions Value, string Label), string>(x => x.Label);

            var action = AnsiConsole.Prompt(menuPrompt);

            switch (action.Item1)
            {
                case MenuOptions.Play:
                    PlayPuzzle();
                    break;
                case MenuOptions.Quit:
                    playing = false;
                    break;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }

    private static void PlayPuzzle()
    {
        Console.Clear();

        var puzzlePrompt = new SelectionPrompt<Puzzle>()
            .Title("Select a puzzle to play:")
            .AddChoices(FiveByFive.Puzzles);

        puzzlePrompt.Converter = new Func<Puzzle, string>(x => x.IncrementalId.ToString());

        var puzzle = AnsiConsole.Prompt(puzzlePrompt);

        var game = new Game(puzzle);
        game.Start();
    }

    private enum MenuOptions
    {
        Play,
        Quit
    }
}

