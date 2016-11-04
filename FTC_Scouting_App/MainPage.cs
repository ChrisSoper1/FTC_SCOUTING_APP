using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Scouting_App
{
    public partial class MainPage : Form
    {


        int teamScore=0;
        int sideScore=0;


        public MainPage()
        {
            InitializeComponent();
            textBox2.Text = teamScore.ToString();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            teamScore = teamScore + 5;
            sideScore = sideScore + 5;
            textBox2.Text = teamScore.ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void t2_beacon_auto_Click(object sender, EventArgs e)
        {
            teamScore=teamScore + 30;
            sideScore=sideScore + 30;
            textBox2.Text = teamScore.ToString();

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void t2_high_goal_auto_Click(object sender, EventArgs e)
        {
            teamScore = teamScore + 15;
            sideScore = sideScore + 15;
            textBox2.Text = teamScore.ToString();

        }

        private void t2_yoga_auto_Click(object sender, EventArgs e)
        {
            teamScore = teamScore + 5;
            sideScore = sideScore + 5;
            textBox2.Text = teamScore.ToString();

        }

        private void T2_Full_Park_auto_Click(object sender, EventArgs e)
        {
            teamScore = teamScore + 10;
            sideScore = sideScore + 10;
            textBox2.Text = teamScore.ToString();
        }

        private void t2_highGoal_tele_Click(object sender, EventArgs e)
        {
            teamScore = teamScore + 5;
            sideScore = sideScore + 5;
            textBox2.Text = teamScore.ToString();

        }

        private void t2_corner_Tele_Click(object sender, EventArgs e)
        {
            teamScore = teamScore + 1;
            sideScore = sideScore + 1;
            textBox2.Text = teamScore.ToString();
        }

        private void t2_Yoga_Tele_Click(object sender, EventArgs e)
        {
            teamScore = teamScore + 40;
            sideScore = sideScore + 40;
            textBox2.Text = teamScore.ToString();
        }

        private void T2_beacons_tele_Click(object sender, EventArgs e)
        {
            teamScore = teamScore + 10;
            sideScore = sideScore + 10;
            textBox2.Text = teamScore.ToString();
        }
    }
}
