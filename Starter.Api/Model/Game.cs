namespace Starter.Api;

/// <summary>
/// Game Object
/// </summary>
public class Game
{
    /// <summary>
    /// A unique identifier for this Game.
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Information about the ruleset being used to run this game.
    /// Example: {"name": "standard", "version": "v1.2.3"}
    /// </summary>
    public Ruleset Ruleset { get; set; } = new Ruleset();

    /// <summary>
    /// The name of the map used to populate the game board with snakes, food, and hazards. Example: "standard" See Game Maps
    /// </summary>
    public string Map { get; set; } = string.Empty;

    /// <summary>
    /// How much time your snake has to respond to requests for this Game.
    /// Time is in milliseconds.
    /// Example: 500
    /// </summary>
    public int Timeout { get; set; }

    /// <summary>
    /// The source of this game. One of:
    /// tournament
    /// league (for League Arenas)
    /// arena (for all other Arenas)
    /// challenge
    /// custom (for all other games sources)
    /// The values for this field may change in the near future.
    /// </summary>
    public string Source { get; set; } = string.Empty;
}