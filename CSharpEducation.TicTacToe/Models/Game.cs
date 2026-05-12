namespace CSharpEducation.TicTacToe.Models;

/// <summary>Логика игры</summary>
public sealed partial class Game
{
    private readonly Board board = new();

    public ReadOnlySpan<bool?> BoardCells()
    {
        return board.Cells;
    }

    private bool СheckWinLine()
    {
        // Проверка строк
        if (board.Cells[0] != null && board.Cells[0] == board.Cells[1] && board.Cells[0] == board.Cells[2])
            return true;
        if (board.Cells[3] != null && board.Cells[3] == board.Cells[4] && board.Cells[3] == board.Cells[5])
            return true;
        if (board.Cells[6] != null && board.Cells[6] == board.Cells[7] && board.Cells[6] == board.Cells[8])
            return true;

        // Проверка колонок
        if (board.Cells[0] != null && board.Cells[0] == board.Cells[3] && board.Cells[0] == board.Cells[6])
            return true;
        if (board.Cells[1] != null && board.Cells[1] == board.Cells[4] && board.Cells[1] == board.Cells[7])
            return true;
        if (board.Cells[2] != null && board.Cells[2] == board.Cells[5] && board.Cells[2] == board.Cells[8])
            return true;

        // Проверка диагоналей
        if (board.Cells[0] != null && board.Cells[0] == board.Cells[4] && board.Cells[0] == board.Cells[8])
            return true;
        if (board.Cells[2] != null && board.Cells[2] == board.Cells[4] && board.Cells[2] == board.Cells[6])
            return true;

        return false;
    }

    public MoveResult TryMove(int cellNumber, bool player)
    {
        if (cellNumber < 1 || cellNumber > Board.CellsCount)
            return MoveResult.OutOfRange;

        int index = cellNumber - 1;

        if (board.Cells[index] != null)
            return MoveResult.CellOccupied;

        board.SetCell(index,player);

        if (СheckWinLine() || IsFull(board.Cells))
            return MoveResult.GameOver;

        return MoveResult.Success;
    }

    private static bool IsFull(ReadOnlySpan<bool?> span)
    {
        for (int i = 0; i < span.Length; i++)
        {
            if (span[i] is null)
                return false;
        }
        return true;
    }
}
