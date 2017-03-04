namespace FTC_Scouting_App
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.compBox = new System.Windows.Forms.ComboBox();
            this.teamBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.matchBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // compBox
            // 
            this.compBox.FormattingEnabled = true;
            this.compBox.Location = new System.Drawing.Point(26, 16);
            this.compBox.Name = "compBox";
            this.compBox.Size = new System.Drawing.Size(186, 21);
            this.compBox.TabIndex = 0;
            this.compBox.Text = "Competition";
            this.compBox.SelectionChangeCommitted += new System.EventHandler(this.selectChange);
            // 
            // teamBox
            // 
            this.teamBox.FormattingEnabled = true;
            this.teamBox.Location = new System.Drawing.Point(527, 16);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(223, 21);
            this.teamBox.TabIndex = 1;
            this.teamBox.Text = "Team";
            this.teamBox.SelectedValueChanged += new System.EventHandler(this.teamChange);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.listBox1.CustomTabOffsets;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 238);
            this.listBox1.TabIndex = 2;
            // 
            // matchBox
            // 
            this.matchBox.FormattingEnabled = true;
            this.matchBox.Location = new System.Drawing.Point(34, 345);
            this.matchBox.Name = "matchBox";
            this.matchBox.Size = new System.Drawing.Size(121, 21);
            this.matchBox.TabIndex = 3;
            this.matchBox.Text = "Match Number";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 454);
            this.Controls.Add(this.matchBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.teamBox);
            this.Controls.Add(this.compBox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox compBox;
        private System.Windows.Forms.ComboBox teamBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox matchBox;
    }
}