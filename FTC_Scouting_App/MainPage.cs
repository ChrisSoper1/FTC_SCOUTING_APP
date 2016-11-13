using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FTC_Scouting_App
{
    public partial class MainPage : Form
    {
        TeamScore Team1Scores = new TeamScore();
        TeamScore Team2Scores = new TeamScore();
        TeamScore Team3Scores = new TeamScore();
        TeamScore Team4Scores = new TeamScore();
        
        Form2 settings = new Form2();

        


        int firstTeamScore = 0;
        int secondTeamScore = 0;
        int thirdTeamScore = 0;
        int fourthTeamScore = 0;

        int blueSideScore = 0;
        int redSideScore = 0;


        public MainPage()
        {
            

            InitializeComponent();
            textBox2.Text = firstTeamScore.ToString();
            textBox1.Text = secondTeamScore.ToString();
            textBox3.Text = redSideScore.ToString();
            textBox4.Text = thirdTeamScore.ToString();
            textBox5.Text = fourthTeamScore.ToString();
            textBox6.Text = blueSideScore.ToString();
           


        }

        private void updateScore()
        {

            textBox3.Text = (Team2Scores.TotalScore + Team3Scores.TotalScore).ToString();
            textBox2.Text = Team1Scores.TotalScore.ToString();
            textBox1.Text = Team2Scores.TotalScore.ToString(); 
            textBox4.Text = Team3Scores.TotalScore.ToString();
            textBox5.Text = Team4Scores.TotalScore.ToString();
            textBox6.Text = (Team1Scores.TotalScore + Team4Scores.TotalScore).ToString();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team2Scores.BeaconScoreAuto = Team2Scores.BeaconScoreAuto + 30;
            updateScore();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Team2Scores.CenterVortexScoreAuto = Team2Scores.CenterVortexScoreAuto + 15;
            updateScore();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Team2Scores.YogaBallAuto = Team2Scores.YogaBallAuto + 5;
            updateScore();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Team2Scores.EndHeightAuto = Team2Scores.EndHeightAuto + 5;
            updateScore();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Team1Scores.EndHeightAuto = Team1Scores.EndHeightAuto + 5;
            updateScore();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void t2_beacon_auto_Click(object sender, EventArgs e)
        {
            Team1Scores.BeaconScoreAuto = Team1Scores.BeaconScoreAuto + 30;
            updateScore();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Team2Scores.EndHeightAuto = Team2Scores.EndHeightAuto + 10;
            updateScore();
        }

        private void t2_high_goal_auto_Click(object sender, EventArgs e)
        {
            Team1Scores.BeaconScoreAuto = Team1Scores.BeaconScoreAuto + 15;
            updateScore();

        }

        private void t2_yoga_auto_Click(object sender, EventArgs e)
        {
            Team1Scores.CornerVortexAuto = Team1Scores.CornerVortexAuto + 5;
            updateScore();

        }

        private void T2_Full_Park_auto_Click(object sender, EventArgs e)
        {
            Team1Scores.EndHeightAuto = Team1Scores.EndHeightAuto + 10;
            updateScore();
        }

        private void t2_highGoal_tele_Click(object sender, EventArgs e)
        {
            Team1Scores.CenterVortexScoreAuto = Team1Scores.CenterVortexScoreAuto + 5;
            updateScore();

        }

        private void t2_corner_Tele_Click(object sender, EventArgs e)
        {
            Team1Scores.CornerVortexScoreTele =Team1Scores.CornerVortexScoreTele + 1;
            updateScore();
        }

        private void t2_Yoga_Tele_Click(object sender, EventArgs e)
        {
            Team1Scores.YogaBallTele = Team1Scores.YogaBallTele + 40;
            updateScore();
        }

        private void T2_beacons_tele_Click(object sender, EventArgs e)
        {
            Team1Scores.BeaconScoreTele = Team1Scores.BeaconScoreTele + 10;
            updateScore();
        }

        private void t1_highGoal_tele_Click(object sender, EventArgs e)
        {
            Team2Scores.CenterVortexScoreTele = Team2Scores.CenterVortexScoreTele + 5;
            updateScore();

        }

        private void t1_corner_Tele_Click(object sender, EventArgs e)
        {
            Team2Scores.CornerVortexScoreTele = Team2Scores.CornerVortexScoreTele + 1;
            updateScore();
        }

        private void t1_Yoga_Tele_Click(object sender, EventArgs e)
        {
            Team2Scores.YogaBallTele = Team2Scores.YogaBallTele + 40;
            updateScore();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Team2Scores.YogaBallTele = Team2Scores.YogaBallTele + 20;
            updateScore();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Team2Scores.YogaBallTele = Team2Scores.YogaBallTele + 10;
            updateScore();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Team1Scores.YogaBallTele = Team1Scores.YogaBallTele + 10;
            updateScore();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Team1Scores.YogaBallTele = Team1Scores.YogaBallTele + 20;
            updateScore();
        }


        private void button26_Click(object sender, EventArgs e)
        {
            Team3Scores.BeaconScoreAuto = Team3Scores.BeaconScoreAuto + 30;
            updateScore();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Team3Scores.CenterVortexScoreAuto = Team3Scores.CenterVortexScoreAuto + 15;
            updateScore();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Team3Scores.YogaBallAuto = Team3Scores.YogaBallAuto + 5;
            updateScore();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Team3Scores.EndHeightAuto = Team3Scores.EndHeightAuto + 5;
            updateScore();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Team3Scores.EndHeightAuto = Team3Scores.EndHeightAuto + 10;
            updateScore();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Team3Scores.CenterVortexScoreTele = Team3Scores.CenterVortexScoreTele + 5;
            updateScore();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Team3Scores.CornerVortexScoreTele = Team3Scores.CornerVortexScoreTele + 1;
            updateScore();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Team3Scores.BeaconScoreTele = Team3Scores.BeaconScoreTele + 10;
            updateScore();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Team3Scores.YogaBallTele = Team3Scores.YogaBallTele + 40;
            updateScore();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Team3Scores.YogaBallTele = Team3Scores.YogaBallTele + 20;
            updateScore();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Team3Scores.YogaBallTele = Team3Scores.YogaBallTele + 10;
            updateScore();
        }

        private void T1_beacons_tele_Click(object sender, EventArgs e)
        {
            Team2Scores.BeaconScoreTele = Team2Scores.BeaconScoreTele + 10;
            updateScore();

        }

        private void button37_Click(object sender, EventArgs e)
        {
            Team4Scores.BeaconScoreAuto = Team4Scores.BeaconScoreAuto + 30;
            updateScore();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Team4Scores.CenterVortexScoreAuto = Team4Scores.CenterVortexScoreAuto + 15;
            updateScore();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Team4Scores.YogaBallAuto = Team4Scores.YogaBallAuto + 5;
            updateScore();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Team4Scores.EndHeightAuto = Team4Scores.EndHeightAuto + 5;
            updateScore();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Team4Scores.EndHeightAuto = Team4Scores.EndHeightAuto + 10;
            updateScore();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Team4Scores.CenterVortexScoreTele = Team4Scores.CenterVortexScoreTele + 5;
            updateScore();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Team4Scores.CornerVortexScoreTele = Team4Scores.CornerVortexScoreTele + 1;
            updateScore();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Team4Scores.BeaconScoreTele = Team4Scores.BeaconScoreTele + 10;
            updateScore();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Team4Scores.YogaBallTele = Team4Scores.YogaBallTele + 40;
            updateScore();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Team4Scores.YogaBallTele = Team4Scores.YogaBallTele + 20;
            updateScore();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Team4Scores.YogaBallTele = Team4Scores.YogaBallTele + 10;
            updateScore();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateScore();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String SaveFileFolder = Path.Combine(MyDocumentsFolder, "FTC_Scorecard");
            if (!Directory.Exists(SaveFileFolder)) {
                Directory.CreateDirectory(SaveFileFolder);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(TeamScore));



          

            FileStream writer = new FileStream(Path.Combine(SaveFileFolder, "Team1Score.xml"), FileMode.Create);
            serializer.Serialize(writer, Team1Scores);
            writer.Close();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Team2Scores.CornerVortexAuto = Team2Scores.CornerVortexAuto + 5;
            updateScore();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Team1Scores.CornerVortexAuto = Team1Scores.CornerVortexAuto + 5;
            updateScore();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Team3Scores.CornerVortexAuto = Team3Scores.CornerVortexAuto + 5;
            updateScore();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Team4Scores.CornerVortexAuto = Team4Scores.CornerVortexAuto + 5;
            updateScore();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            settings.Show();
        }
    }
}
