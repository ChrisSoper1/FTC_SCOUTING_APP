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


        public int BeaconScoreAuto { get; set; }
        public int CornerVortexAuto { get; set; }
        public int CenterVortexScoreAuto { get; set; }
        public int YogaBallAuto { get; set; }
        public int EndHeightAuto { get; set; }



        public int BeaconScoreTele { get; set; }

        public int CenterVortexScoreTele { get; set; }

        public int CornerVortexScoreTele { get; set; }

        public int YogaBallTele { get; set; }

        public int TotalScore
        {
            get {
               
                return BeaconScoreTele + CenterVortexScoreTele + CornerVortexScoreTele + YogaBallTele+ BeaconScoreAuto+ CornerVortexAuto+CenterVortexScoreAuto+ YogaBallAuto+ EndHeightAuto;
            }
        }
    }
}
