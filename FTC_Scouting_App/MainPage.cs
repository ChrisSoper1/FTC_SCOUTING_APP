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
            textBox3.Text = redSideScore.ToString();
            textBox2.Text = firstTeamScore.ToString();
            textBox1.Text = secondTeamScore.ToString();
            textBox4.Text = thirdTeamScore.ToString();
            textBox5.Text = fourthTeamScore.ToString();
            textBox6.Text = blueSideScore.ToString();
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
            redSideScore = redSideScore + 30;
            secondTeamScore = secondTeamScore + 30;
            updateScore();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redSideScore = redSideScore + 15;
            secondTeamScore = secondTeamScore + 15;
            updateScore();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            redSideScore = redSideScore + 5;
            secondTeamScore = secondTeamScore + 5;
            updateScore();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            redSideScore = redSideScore + 5;
            secondTeamScore = secondTeamScore + 5;
            updateScore();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 5;
            blueSideScore = blueSideScore + 5;
            updateScore();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void t2_beacon_auto_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 30;
            blueSideScore = blueSideScore + 30;
            updateScore();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            secondTeamScore = secondTeamScore + 10;
            redSideScore = redSideScore + 10;
            updateScore();
        }

        private void t2_high_goal_auto_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 15;
            blueSideScore = blueSideScore + 15;
            updateScore();

        }

        private void t2_yoga_auto_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 5;
            blueSideScore = blueSideScore + 5;
            updateScore();

        }

        private void T2_Full_Park_auto_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 10;
            blueSideScore = blueSideScore + 10;
            updateScore();
        }

        private void t2_highGoal_tele_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 5;
            blueSideScore = blueSideScore + 5;
            updateScore();

        }

        private void t2_corner_Tele_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 1;
            blueSideScore = blueSideScore + 1;
            updateScore();
        }

        private void t2_Yoga_Tele_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 40;
            blueSideScore = blueSideScore + 40;
            updateScore();
        }

        private void T2_beacons_tele_Click(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 10;
            blueSideScore = blueSideScore + 10;
            updateScore();
        }

        private void t1_highGoal_tele_Click(object sender, EventArgs e)
        {
            redSideScore = redSideScore + 5;
            secondTeamScore = secondTeamScore + 5;
            updateScore();

        }

        private void t1_corner_Tele_Click(object sender, EventArgs e)
        {
            redSideScore = redSideScore + 1;
            secondTeamScore = secondTeamScore + 1;
            updateScore();
        }

        private void t1_Yoga_Tele_Click(object sender, EventArgs e)
        {
            redSideScore = redSideScore + 40;
            secondTeamScore = secondTeamScore + 40;
            updateScore();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            secondTeamScore = secondTeamScore + 20;
            redSideScore = secondTeamScore + 20;
            updateScore();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            secondTeamScore = secondTeamScore + 10;
            redSideScore = secondTeamScore + 10;
            updateScore();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 10;
            blueSideScore = blueSideScore + 10;
            updateScore();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            firstTeamScore = firstTeamScore + 20;
            blueSideScore = blueSideScore + 20;
            updateScore();
        }


        private void button26_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 30;
            redSideScore = redSideScore + 30;
            updateScore();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 15;
            redSideScore = redSideScore + 15;
            updateScore();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 5;
            redSideScore = redSideScore + 5;
            updateScore();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 5;
            redSideScore = redSideScore + 5;
            updateScore();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 10;
            redSideScore = redSideScore + 10;
            updateScore();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 5;
            redSideScore = redSideScore + 5;
            updateScore();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 1;
            redSideScore = redSideScore + 1;
            updateScore();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 10;
            redSideScore = redSideScore + 10;
            updateScore();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 40;
            redSideScore = redSideScore + 40;
            updateScore();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 20;
            redSideScore = redSideScore + 20;
            updateScore();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            thirdTeamScore = thirdTeamScore + 10;
            redSideScore = redSideScore + 10;
            updateScore();
        }

        private void T1_beacons_tele_Click(object sender, EventArgs e)
        {
            secondTeamScore = secondTeamScore + 10;
            redSideScore = redSideScore + 10;
            updateScore();

        }

        private void button37_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 30;
            blueSideScore = blueSideScore + 30;
            updateScore();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 15;
            blueSideScore = blueSideScore + 15;
            updateScore();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 5;
            blueSideScore = blueSideScore + 5;
            updateScore();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 5;
            blueSideScore = blueSideScore + 5;
            updateScore();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 10;
            blueSideScore = blueSideScore + 10;
            updateScore();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 5;
            blueSideScore = blueSideScore + 5;
            updateScore();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 1;
            blueSideScore = blueSideScore + 1;
            updateScore();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 10;
            blueSideScore = blueSideScore + 10;
            updateScore();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 40;
            blueSideScore = blueSideScore + 40;
            updateScore();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 20;
            blueSideScore = blueSideScore + 20;
            updateScore();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            fourthTeamScore = fourthTeamScore + 10;
            blueSideScore = blueSideScore + 10;
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
            TeamScore Team1Scores = new TeamScore();
            Team1Scores.BeaconScore = firstTeamScore;
            Team1Scores.CenterVortexScore = firstTeamScore * 30;

            FileStream writer = new FileStream(Path.Combine(SaveFileFolder, "Team1Score.xml"), FileMode.Create);
            serializer.Serialize(writer, Team1Scores);
            writer.Close();
        }
    }
}
