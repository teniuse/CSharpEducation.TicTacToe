namespace CSharpEducation.TicTacToe.Presentation;

internal static class StartMessageRender
{
    public static void Render()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Добро пожаловать в игру крестики-нолики!");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Выберите кто будет ходить первым: X и O");
        Console.ResetColor();
    }
}
