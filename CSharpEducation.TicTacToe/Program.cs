using CSharpEducation.TicTacToe.Models;
using CSharpEducation.TicTacToe.Presentation;

MoveResult resultMove;
ConsoleKey selectedPlayer;
Player currentPlayer;
Game game = new();

StartMessageRender.Render();

do
{
    selectedPlayer = Console.ReadKey(true).Key;

} while (selectedPlayer != ConsoleKey.X && selectedPlayer != ConsoleKey.O);
currentPlayer = selectedPlayer == ConsoleKey.X ? Player.X : Player.O;

Console.WriteLine($"Первым ходит: {currentPlayer}");

GameBoardRender.Render(game.BoardCells());
do
{
    Console.Write($"Ходит {currentPlayer}: ");
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
    currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
    GameBoardRender.Render(game.BoardCells());
} while (resultMove != MoveResult.GameOver);

Console.WriteLine("Игра окончена. Нажмите любую клавишу для выхода.");
Console.ReadKey();