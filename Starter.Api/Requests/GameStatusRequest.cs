using Starter.Core;

namespace Starter.Api.Requests
{
    public class GameStatusRequest
    {
        public Game Game { get; set; }
        public int Turn { get; set; }
        public Board Board { get; set; }
        public Snake You { get; set; }
    }
}