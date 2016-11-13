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

        TeamList teamList = new TeamList();
        String blank = "empty";
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String check = textBox1.Text;
            for (int i = 1; i < 30; i++)
            {

                if (check == teamList.number[i])
                {
                    break;
                }
            }
            for (int k = 0; k < 30; k++)
            {

                if (teamList.number[k].Equals(teamList.number[28]))
                {


                }
                else
                {
                    teamList.number[k] = check;
                    teamList.name[k] = textBox2.Text;
                    break;
                }
            }
            label3.Text = teamList.name[1];
            label4.Text = (teamList.number).ToString();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 0; i++) {
                teamList.name[i] = "empty";
                teamList.number[i] = "empty";
            }
        }
    }
}
