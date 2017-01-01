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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Competition newComp = new Competition();
            newComp.date = DateTime.Now.ToLongDateString();
            newComp.location = nameBox.Text;
            Program.compList.Add(newComp);
            this.Close();
            
            
        }
    }
}
