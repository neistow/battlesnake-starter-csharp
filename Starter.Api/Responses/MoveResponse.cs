namespace Starter.Api.Responses;

public class MoveResponse
{
    /// <summary>
    /// Your Battlesnake's move for this turn. Valid moves are up, down, left, or right.Example: "up"
    /// </summary>
    public string Move { get; set; } = "up";

    /// <summary>
    /// An optional message sent to all other Battlesnakes on the next turn. Must be 256 characters or less.Example: "I am moving up!"
    /// </summary>
    public string? Shout { get; set; }
}