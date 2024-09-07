using System;
using System.Collections.Generic;
using Entities;

namespace DataAccess.Concrete
{
    public class InMemoryTeamMember
    {
        private static List<TeamMember> _teamMembers;
          static InMemoryTeamMember()
        {
            _teamMembers = new List<TeamMember>
            {
             new TeamMember{Name =  "Burak Karaman"},
             new TeamMember{Name =  "Cüneyt Altunoğlu"},
             new TeamMember{Name =  "Hüseyin Aktoka"},
             new TeamMember{Name =  "Kadriye Kılınç"},
             new TeamMember{Name =  "Alen Darçin"},
            };
        }
       public TeamMember GetTeamMember(int id)
       {
           var teamMember = _teamMembers.Find(tm=> tm.Id == id);
           if (teamMember == null)
           {
               Console.WriteLine("Takım üyesi bulunamadı !");
           }
           return teamMember;
       }
        
    }
}