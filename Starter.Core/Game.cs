﻿namespace Starter.Core
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
        /// </summary>
        public int Timeout { get; set; }
    }
}