using System;
namespace Entities
{
    public class TeamMember
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public TeamMember()
        {
            Id = counter+1;
            counter++;
        }
    }
}