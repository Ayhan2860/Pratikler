using System;

namespace Entities
{
    public class CardContent
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string  Header { get; set; }
        public string Content { get; set; }
        public TeamMember TeamMember { get; set; }
        public SizeEnum SizeEnum { get; set; } 

        public CardContent()
        {
            Id = counter+1;
            counter++;
        }    
        
    }
}