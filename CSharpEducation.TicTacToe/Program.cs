using CSharpEducation.TicTacToe.Abstract;
using CSharpEducation.TicTacToe.Models;
using CSharpEducation.TicTacToe.Presentation;

ConsoleKey pressedKey;
bool currentPlayer;
GameField gameField = new();
GameFieldRender fieldRender = new();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Добро пожаловать в игру крестики-нолики!");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Выберите кто будет ходить первым: X и O");
Console.ResetColor();

do
{
    pressedKey = Console.ReadKey(true).Key;
    currentPlayer = pressedKey == ConsoleKey.X ? true : false;

} while (pressedKey != ConsoleKey.X && pressedKey != ConsoleKey.O);

Console.WriteLine($"Первым ходит: {pressedKey}");
fieldRender.Render(gameField.Cells);

do
{
    var cheyHod = currentPlayer == true ? Player.X : Player.O;
    Console.Write($"Ходит {cheyHod}: ");
    char ch;
    int number;
    do
    {
        ch = Console.ReadKey().KeyChar;

    } while (ch < '1' || ch > '9');

    Console.WriteLine();
    number = ch - '0';
    var resultMove = gameField.TryMove(number, currentPlayer);

    if (resultMove == MoveResult.CellOccupied)
    {
        Console.WriteLine("Клетка занята. Повторите попытку.");
        continue;
    }
    currentPlayer = !currentPlayer;
    fieldRender.Render(gameField.Cells);
} while (!gameField.CheckWin());
Console.WriteLine("Игра окончена. Нажмите любую клавишу для выхода.");
Console.ReadKey();