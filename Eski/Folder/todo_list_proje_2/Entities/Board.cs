using System;
namespace Entities
{
    public class Board
    { 
        public Board()
        {
            
        }
        public CardContent Todo { get; set; }
        public CardContent InProgress { get; set; }
        public CardContent Done { get; set; }
    }
}