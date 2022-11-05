namespace Starter.Api.Responses;

public class InitResponse
{
    /// <summary>
    /// Version of the Battlesnake API implemented by this Battlesnake. Currently only API version 1 is valid. Example: "1"
    /// </summary>
    public string ApiVersion { get; set; } = "1";

    /// <summary>
    /// Username of the author of this Battlesnake. If provided, this will be used to verify ownership.Example: "BattlesnakeOfficial"
    /// </summary>
    public string? Author { get; set; }

    /// <summary>
    /// Hex color code used to display this Battlesnake. Must start with "#" and be 7 characters long.Example: "#888888"
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// Displayed head of this Battlesnake. See Customization Guide for available optionsExample: "default"
    /// </summary>
    public string? Head { get; set; }

    /// <summary>
    /// Displayed tail of this Battlesnake. See Customization Guide for available optionsExample: "default"
    /// </summary>
    public string? Tail { get; set; }

    /// <summary>
    /// A version number or tag for your snake.
    /// </summary>
    public string? Version { get; set; }
}