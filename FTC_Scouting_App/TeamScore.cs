using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTC_Scouting_App
{
    public class TeamScore
    {
        public String TeamName { get; set; }

        public DateTime MatchTime { get; set; }

        public int BeaconScore { get; set; }

        public int CenterVortexScore { get; set; }

        public int TotalScore
        {
            get {
                return BeaconScore + CenterVortexScore;
            }
        }
    }
}
