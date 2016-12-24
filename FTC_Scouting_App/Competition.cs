using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Scouting_App
{
    public class Competition
    {
     
         
           
        public String location { get; set;}
        public String date { get; set; }
        public List <Team> team { get; set; }
        
    }

    
    public class Team
    {
        public String teamName { get; set; }
        public String teamNumber { get; set; }
        public List<TeamScore> scores { get; set; }
        public String comments { get; set; }
    }
}

