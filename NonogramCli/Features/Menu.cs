using Spectre.Console;

namespace NonogramCli.Features;

internal class Menu<T>
{
    internal required string Title { get; set; }
    internal List<(T Value, string Label)> Choices { get; set; } = [];

    internal T Prompt()
    {
        Console.Clear();

        var prompt = new SelectionPrompt<(T Value, string Label)>()
            .Title(Title)
            .AddChoices(Choices);

        prompt.Converter = new Func<(T Value, string Label), string>(x => x.Label);

        var (Value, Label) = AnsiConsole.Prompt(prompt);

        return Value;
    }
}