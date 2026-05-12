using CSharpEducation.TicTacToe.Models;

namespace CSharpEducation.TicTacToe.Abstract;

sealed class GameField
{
    private const int Size = 3;
    private const int CellsCount = Size * Size;
    private bool?[] Field = new bool?[CellsCount];

    public ReadOnlySpan<bool?> Cells => Field;

    public bool CheckWin()
    {
        // Проверка строк
        if (Field[0] != null && Field[0] == Field[1] && Field[0] == Field[2])
            return true;
        if (Field[3] != null && Field[3] == Field[4] && Field[3] == Field[5])
            return true;
        if (Field[6] != null && Field[6] == Field[7] && Field[6] == Field[8])
            return true;

        // Проверка колонок
        if (Field[0] != null && Field[0] == Field[3] && Field[0] == Field[6])
            return true;
        if (Field[1] != null && Field[1] == Field[4] && Field[1] == Field[7])
            return true;
        if (Field[2] != null && Field[2] == Field[5] && Field[2] == Field[8])
            return true;

        // Проверка диагоналей
        if (Field[0] != null && Field[0] == Field[4] && Field[0] == Field[8])
            return true;
        if (Field[2] != null && Field[2] == Field[4] && Field[2] == Field[6])
            return true;

        bool isFieldFull = Array.IndexOf(Field, null) < 0;
        if (isFieldFull)
            return true;

        return false;
    }

    public MoveResult TryMove(int cellNumber, bool player)
    {
        if (cellNumber < 1 || cellNumber > CellsCount)
            return MoveResult.OutOfRange;

        int index = cellNumber - 1;

        if (Field[index] != null)
            return MoveResult.CellOccupied;

        Field[index] = player;
        return MoveResult.Success;
    }
}
