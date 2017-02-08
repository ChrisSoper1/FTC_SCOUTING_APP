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
            List<Team> selectedTeam = (List<Team>)comboBox2.SelectedValue;
            listBox1.DataSource = selectedTeam;
        }

        private void selectChange(object sender, EventArgs e)
        {
            try
            {
                Competition selectedComp = (Competition)compBox.SelectedItem;
                comboBox2.DataSource = selectedComp.team;
                
            }
            catch
            {

            }
        }

        private void teamCgange(object sender, EventArgs e)
        {
           // Team teamLoaded = (Team) comboBox2.DataSource;
            
        }
    }
}
