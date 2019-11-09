using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TestProjectCsharp
{
    public partial class RoomType : Form
    {
        //private RoomInfoOne _roomInfoOne;
        //public RoomType(RoomInfoOne roomInfoOne)
        public RoomType()
        {
            InitializeComponent();
            //_roomInfoOne = roomInfoOne;
        }
        private void InitializeComponent()
        {
            this.radExpresso = new System.Windows.Forms.RadioButton();
            this.rad2020 = new System.Windows.Forms.RadioButton();
            this.radHybrid = new System.Windows.Forms.RadioButton();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.grpRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // radExpresso
            // 
            this.radExpresso.AutoSize = true;
            this.radExpresso.Location = new System.Drawing.Point(24, 35);
            this.radExpresso.Name = "radExpresso";
            this.radExpresso.Size = new System.Drawing.Size(87, 21);
            this.radExpresso.TabIndex = 0;
            this.radExpresso.TabStop = true;
            this.radExpresso.Text = "Expresso";
            this.radExpresso.UseVisualStyleBackColor = true;
            // 
            // rad2020
            // 
            this.rad2020.AutoSize = true;
            this.rad2020.Location = new System.Drawing.Point(146, 35);
            this.rad2020.Name = "rad2020";
            this.rad2020.Size = new System.Drawing.Size(65, 21);
            this.rad2020.TabIndex = 1;
            this.rad2020.TabStop = true;
            this.rad2020.Text = "20/20";
            this.rad2020.UseVisualStyleBackColor = true;
            // 
            // radHybrid
            // 
            this.radHybrid.AutoSize = true;
            this.radHybrid.Location = new System.Drawing.Point(245, 35);
            this.radHybrid.Name = "radHybrid";
            this.radHybrid.Size = new System.Drawing.Size(70, 21);
            this.radHybrid.TabIndex = 2;
            this.radHybrid.TabStop = true;
            this.radHybrid.Text = "Hybrid";
            this.radHybrid.UseVisualStyleBackColor = true;
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.rad2020);
            this.grpRoomType.Controls.Add(this.radHybrid);
            this.grpRoomType.Controls.Add(this.radExpresso);
            this.grpRoomType.Location = new System.Drawing.Point(63, 27);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(340, 83);
            this.grpRoomType.TabIndex = 3;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Select A Room Type:";
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(297, 116);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(154, 30);
            this.btn_continue.TabIndex = 4;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.Btn_continue_Click);
            // 
            // RoomType
            // 
            this.ClientSize = new System.Drawing.Size(471, 164);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.grpRoomType);
            this.Name = "RoomType";
            this.Text = "Automated PullSheet";
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.ResumeLayout(false);

        }
        private GroupBox grpRoomType;
        private Button btn_continue;
        private RadioButton radExpresso;
        private RadioButton rad2020;
        private RadioButton radHybrid;

        private void Btn_continue_Click(object sender, EventArgs e)
        {
            if (radExpresso.Checked is false && rad2020.Checked is false && radHybrid.Checked is false)
                MessageBox.Show("Please select a room type.");
            else
            {
                this.Hide();
                string rtn = GetRoomTypeNames(radExpresso.Checked, rad2020.Checked, radHybrid.Checked);

                RoomInfoOne frm = new RoomInfoOne(this, rtn);
                frm.Show();
            }
        }
        
        private string GetRoomTypeNames(bool _radExpresso, bool _rad2020, bool _radHybrid)
        {
            string auto = "Automated Pullsheet - ";
            if (_radExpresso == true) { return auto + "Expresso"; }
            else if (_rad2020 == true) { return auto + "20/20"; }
            else if (_radHybrid == true) { return auto + "Hybrid"; }
            else { return "Automated Pullsheet"; }
        }
    }
}

