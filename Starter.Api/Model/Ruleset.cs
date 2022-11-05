namespace Starter.Api;

/// <summary>
/// Information about the ruleset being used to run this game.
/// </summary>
public class Ruleset
{
    /// <summary>
    /// Name of the ruleset being used to run this game.
    /// Possible values include: standard, solo, royale, squad, constrictor, wrapped.
    /// See Game Modes for more information on each ruleset.Example: "standard"
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The release version of the Rules module used in this game.
    /// Example: "version": "v1.2.3"
    /// </summary>
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// A collection of specific settings being used by the current game that control how the rules are applied.
    /// </summary>
    public RulesetSettings Settings { get; set; } = new RulesetSettings();
}
