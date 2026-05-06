ConsoleKey selectedPlayer;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Добро пожаловать в игру крестики-нолики!");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Выберите кто будет ходить первым: X и O");

do
{
    selectedPlayer = Console.ReadKey(true).Key;

} while (selectedPlayer != ConsoleKey.X && selectedPlayer != ConsoleKey.O);

Console.ResetColor();
Console.WriteLine($"Первым ходит: {selectedPlayer}");
Console.ReadKey();