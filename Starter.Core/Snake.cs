using System.Collections.Generic;

namespace Starter.Core
{
    /// <summary>
    /// The snake itself.
    /// </summary>
    public class Snake
    {
        /// <summary>
        /// Unique identifier for this Battlesnake in the context of the current Game.
        /// Example: "totally-unique-snake-id"
        /// </summary>
        public string Id { get; set; }


        /// <summary>
        /// Name given to this Battlesnake by its author.
        /// Example: "Sneky McSnek Face"
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Health value of this Battlesnake, between 0 and 100 inclusively.
        /// Example: 54
        /// </summary>
        public string Health { get; set; }


        /// <summary>
        /// Array of coordinates representing this Battlesnake's location on the game board.
        /// This array is ordered from head to tail.
        /// Example: [{"x": 0, "y": 0}, ..., {"x": 2, "y": 0}]
        /// </summary>
        public IEnumerable<Point> Body { get; set; }


        /// <summary>
        /// Coordinates for this Battlesnake's head. Equivalent to the first element of the body array.
        /// Example: {"x": 0, "y": 0}
        /// </summary>
        public Point Head { get; set; }


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
        public string Shout { get; set; }


        /// <summary>
        /// The previous response time of this Battlesnake, in milliseconds. "0" means
        /// the Battlesnake timed out and failed to respond.
        /// Example: 450
        /// </summary>
        public int Latency { get; set; }


        /// <summary>
        /// The squad that the Battlesnake belongs to. Used to identify squad members in Squad Mode games.
        /// Example: "1"
        /// </summary>
        public string Squad { get; set; }
    }
}