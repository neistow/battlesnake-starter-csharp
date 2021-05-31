namespace Starter.Core
{
    /// <summary>
    /// Information about the ruleset being used to run this game.
    /// </summary>
    public class Ruleset
    {
        /// <summary>
        /// The name of the ruleset.
        /// </summary>
        /// <example>standard</example>
        public string Name { get; set; }


        /// <summary>
        /// The version of the ruleset.
        /// </summary>
        /// <example>v1.2.3</example>
        public string Version { get; set; }

    }
}
