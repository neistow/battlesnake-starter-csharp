namespace Starter.Core
{
    /// <summary>
    /// Information about the ruleset being used to run this game.
    /// </summary>
    public class Ruleset
    {
        /// <summary>
        /// The name of the ruleset.
        /// Example: "standard"
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// The version of the ruleset.
        /// Example: "v1.2.3"
        /// </summary>
        public string Version { get; set; }

    }
}
