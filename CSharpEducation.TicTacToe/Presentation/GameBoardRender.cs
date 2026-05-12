namespace CSharpEducation.TicTacToe.Presentation;

internal static class GameBoardRender
{
    public static void Render(ReadOnlySpan<bool?> cells)
    {
        Console.WriteLine($"-------------");
        Console.WriteLine($"| {RenderFieldCell(cells, 0)} | {RenderFieldCell(cells, 1)} | {RenderFieldCell(cells, 2)} |");
        Console.WriteLine($"-------------");
        Console.WriteLine($"| {RenderFieldCell(cells, 3)} | {RenderFieldCell(cells, 4)} | {RenderFieldCell(cells, 5)} |");
        Console.WriteLine($"-------------");
        Console.WriteLine($"| {RenderFieldCell(cells, 6)} | {RenderFieldCell(cells, 7)} | {RenderFieldCell(cells, 8)} |");
        Console.WriteLine($"-------------");
    }

    private static string RenderFieldCell(ReadOnlySpan<bool?> cells, int indexCell)
    {
        if (cells[indexCell] == true)
            return "\u001b[41;30mX\u001b[0m";
        if (cells[indexCell] == false)
            return "\u001b[43;30mO\u001b[0m";
        return (indexCell + 1).ToString();
    }
}
