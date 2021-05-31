namespace Starter.Core
{
    /// <summary>
    /// Game Object
    /// </summary>
    public class Game
    {
        /// <summary>
        /// A unique identifier for this Game.
        /// </summary>
        public string Id { get; set; }
        
        
        /// <summary>
        /// How much time your snake has to respond to requests for this Game.
        /// Time is in milliseconds.
        /// Example: 500
        /// </summary>
        public int Timeout { get; set; }


        /// <summary>
        /// Information about the ruleset being used to run this game.
        /// Example: {"name": "standard", "version": "v1.2.3"}
        /// </summary>
        public Ruleset Ruleset { get; set; }
    }
}