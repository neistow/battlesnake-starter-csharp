namespace Starter.Api.Requests;

public class GameStatusRequest
{

    /// <summary>
    /// <see cref="Game"/> Object describing the game being played.
    /// </summary>
    public Game Game { get; set; } = new Game();

    /// <summary>
    /// start: Turn number of the game being played (0 for new games).
    /// move: Turn number for this move.
    /// end: Turn number for the last turn of the game.
    /// </summary>
    public int Turn { get; set; }

    /// <summary>
    /// start: <see cref="Board"/> Object describing the initial state of the game board.
    /// move: <see cref="Board"/> Object describing the game board on this turn.
    /// end: <see cref="Board"/> Object describing the final state of the game board.
    /// </summary>
    public Board Board { get; set; } = new Board();

    /// <summary>
    /// <see cref="Snake"/> Object describing your Battlesnake.
    /// </summary>
    public Snake You { get; set; } = new Snake();
}