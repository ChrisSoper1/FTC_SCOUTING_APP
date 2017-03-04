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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            compBox.DataSource = Program.compList;

        }

        private void selectChange(object sender, EventArgs e)
        {
            try
            {
                Competition selectedComp = (Competition)compBox.SelectedItem;
                teamBox.DataSource = selectedComp.team;
            }
            catch
            {

            }
        }

        private void teamCgange(object sender, EventArgs e)
        {



        }

        private void teamChange(object sender, EventArgs e)
        {
            Team selectedTeam = (Team)teamBox.SelectedItem;
            try
            {

                listBox1.DataSource = selectedTeam.scores;
            }
            catch
            {

            }
            
        }
    }
}
