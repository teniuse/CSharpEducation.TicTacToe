namespace CSharpEducation.TicTacToe.Models;

public enum MoveResult
{
    /// <summary>Успешный ход</summary>
    Success,
    /// <summary>Клетка занята</summary>
    CellOccupied,
    /// <summary>Игра окончена</summary>
    GameOver,
    /// <summary>Неправильно значенеи поля</summary>
    OutOfRange
}
