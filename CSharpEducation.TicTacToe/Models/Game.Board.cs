namespace CSharpEducation.TicTacToe.Models;

public sealed partial class Game
{
    /// <summary>Игровое поле</summary>
    private sealed class Board
    {
        private const int Size = 3;
        public const int CellsCount = Size * Size;
        private readonly bool?[] board = new bool?[CellsCount];

        /// <summary>Получить состояние поля</summary>
        public ReadOnlySpan<bool?> Cells => board;

        public void SetCell(int index, bool player) => board[index] = player;
    }
}
