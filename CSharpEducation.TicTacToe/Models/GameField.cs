using CSharpEducation.TicTacToe.Models;

namespace CSharpEducation.TicTacToe.Abstract;

sealed class GameField
{
    private const int Size = 3;
    Player[] Field = new Player[Size * Size];

    public bool CheckWin()
    {
        // Проверка строк
        if (Field[0] == Field[1] && Field[0] == Field[2])
            return true;
        if (Field[3] == Field[4] && Field[3] == Field[5])
            return true;
        if (Field[6] == Field[7] && Field[6] == Field[8])
            return true;

        // Проверка колонок
        if (Field[0] == Field[3] && Field[0] == Field[6])
            return true;
        if (Field[1] == Field[4] && Field[1] == Field[7])
            return true;
        if (Field[2] == Field[5] && Field[2] == Field[8])
            return true;

        // Проверка диагоналей
        if (Field[0] == Field[4] && Field[0] == Field[8])
            return true;
        if (Field[2] == Field[4] && Field[2] == Field[6])
            return true;

        return false;
    }
}
