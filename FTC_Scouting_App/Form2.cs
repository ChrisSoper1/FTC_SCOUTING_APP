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
    public partial class Form2 : Form
    {
        List<Competition> compList = new List<Competition>();
        Form1 adder = new Form1();


        public Form2()
        {
            InitializeComponent();
            compBox.DataSource = Program.compList;
            compBox.DisplayMember = Program.compList.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            adder.Show();
            adder.FormClosed += Adder_FormClosed;
        }

        private void Adder_FormClosed(object sender, FormClosedEventArgs e)
        {
            compBox.DataSource = null;
            compBox.DataSource = Program.compList;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Team newTeam = new Team();
            newTeam.teamName = textBox2.Text;
            newTeam.teamNumber = textBox1.Text;

            Competition comp = (Competition)compBox.SelectedItem;

            comp.team.Add(newTeam);


        }

        private void updateBOc(object sender, MouseEventArgs e)
        {
           
        }
    }
}
