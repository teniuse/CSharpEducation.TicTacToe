namespace CSharpEducation.TicTacToe.Models;

public sealed partial class Game
{
    /// <summary>Игровое поле</summary>
    private sealed class Board
    {
        private const int Size = 3;
        public const int CellsCount = Size * Size;
        private readonly Player?[] board = new Player?[CellsCount];

        /// <summary>Получить состояние поля</summary>
        public ReadOnlySpan<Player?> Cells => board;

        public void SetCell(int index, Player player) => board[index] = player;
    }
}
