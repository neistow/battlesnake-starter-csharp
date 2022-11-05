namespace Starter.Api;

/// <summary>
/// The snake itself.
/// </summary>
public class Snake
{
    /// <summary>
    /// Unique identifier for this Battlesnake in the context of the current Game.
    /// Example: "totally-unique-snake-id"
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Name given to this Battlesnake by its author.
    /// Example: "Sneky McSnek Face"
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Health value of this Battlesnake, between 0 and 100 inclusively.
    /// Example: 54
    /// </summary>
    public int Health { get; set; }

    /// <summary>
    /// Array of coordinates representing this Battlesnake's location on the game board.
    /// This array is ordered from head to tail.
    /// Example: [{"x": 0, "y": 0}, ..., {"x": 2, "y": 0}]
    /// </summary>
    public IEnumerable<Coordinate> Body { get; set; } = new Coordinate[] { new Coordinate(0, 0) };

    /// <summary>
    /// Coordinates for this Battlesnake's head. Equivalent to the first element of the body array.
    /// Example: {"x": 0, "y": 0}
    /// </summary>
    public Coordinate Head { get; set; } = new Coordinate(0, 0);

    /// <summary>
    /// Length of this Battlesnake from head to tail. Equivalent to the length of the body
    /// array.
    /// Example: 3
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// Message shouted by this Battlesnake on the previous turn.
    /// Example: "why are we shouting??"
    /// </summary>
    public string Shout { get; set; } = string.Empty;

    /// <summary>
    /// The previous response time of this Battlesnake, in milliseconds.
    /// If the Battlesnake timed out and failed to respond, the game timeout will be returned (game.timeout)
    /// Example: 500
    /// </summary>
    public string Latency { get; set; } = string.Empty;

    /// <summary>
    /// The squad that the Battlesnake belongs to. Used to identify squad members in Squad Mode games.
    /// Example: "1"
    /// </summary>
    public string Squad { get; set; } = string.Empty;

    /// <summary>
    /// The collection of customizations applied to this Battlesnake that represent how it is viewed.
    /// Follows the same rules as in the Info request.
    /// Example: {"color":"#888888", "head":"default", "tail":"default" }
    /// </summary>
    public SnakeCustomizations Customizations { get; set; } = new SnakeCustomizations();

    public class SnakeCustomizations
    {
        /// <summary>
        /// Hex color code used to display this Battlesnake. Must start with "#" and be 7 characters long.Example: "#888888"
        /// </summary>
        public string Color { get; set; } = string.Empty;

        /// <summary>
        /// Displayed head of this Battlesnake. See Customization Guide for available optionsExample: "default"
        /// </summary>
        public string Head { get; set; } = string.Empty;

        /// <summary>
        /// Displayed tail of this Battlesnake. See Customization Guide for available optionsExample: "default"
        /// </summary>
        public string Tail { get; set; } = string.Empty;
    }
}