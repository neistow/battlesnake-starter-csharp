namespace Starter.Api;

public class RulesetSettings
{
    /// <summary>
    /// Percentage chance of spawning a new food every round.
    /// </summary>
    public int FoodSpawnChance { get; set; }

    /// <summary>
    /// Minimum food to keep on the board every turn.
    /// </summary>
    public int MinimumFood { get; set; }

    /// <summary>
    /// Health damage a snake will take when ending its turn in a hazard. This stacks on top of the regular 1 damage a snake takes per turn.
    /// </summary>
    public int HazardDamagePerTurn { get; set; }

    public RoyaleModeRulesetSettings Royale { get; set; } = new RoyaleModeRulesetSettings();

    public SquadModeRulesetSettings Squad { get; set; } = new SquadModeRulesetSettings();

    public class RoyaleModeRulesetSettings
    {
        /// <summary>
        /// In Royale mode, the number of turns between generating new hazards (shrinking the safe board space).
        /// </summary>
        public int ShrinkEveryNTurns { get; set; }
    }

    public class SquadModeRulesetSettings
    {
        /// <summary>
        /// In Squad mode, allow members of the same squad to move over each other without dying.
        /// </summary>
        public bool AllowBodyCollisions { get; set; }

        /// <summary>
        /// In Squad mode, all squad members are eliminated when one is eliminated.
        /// </summary>
        public bool SharedElimination { get; set; }

        /// <summary>
        /// In Squad mode, all squad members share health.
        /// </summary>
        public bool SharedHealth { get; set; }

        /// <summary>
        /// In Squad mode, all squad members share length.
        /// </summary>
        public bool SharedLength { get; set; }
    }
}
