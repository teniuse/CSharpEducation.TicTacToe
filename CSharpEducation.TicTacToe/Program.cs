using CSharpEducation.TicTacToe.Models;
using CSharpEducation.TicTacToe.Presentation;

ConsoleKey pressedKey;
bool currentPlayer;
Game game = new();

StartMessageRender.Render();

do
{
    pressedKey = Console.ReadKey(true).Key;
    currentPlayer = pressedKey == ConsoleKey.X ? true : false;

} while (pressedKey != ConsoleKey.X && pressedKey != ConsoleKey.O);

Console.WriteLine($"Первым ходит: {pressedKey}");
GameBoardRender.Render(game.BoardCells());
MoveResult resultMove;
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
    resultMove = game.TryMove(number, currentPlayer);

    if (resultMove == MoveResult.CellOccupied)
    {
        Console.WriteLine("Клетка занята. Повторите попытку.");
        continue;
    }
    currentPlayer = !currentPlayer;
    GameBoardRender.Render(game.BoardCells());
} while (resultMove != MoveResult.GameOver);
Console.WriteLine("Игра окончена. Нажмите любую клавишу для выхода.");
Console.ReadKey();