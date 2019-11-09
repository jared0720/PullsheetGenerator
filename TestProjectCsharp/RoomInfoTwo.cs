using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectCsharp
{
    public partial class RoomInfoTwo : Form
    {
        public List<string> NurseStation { get; set; }
        public List<int> OrInfo { get; set; }
        private RoomInfoOne _roomInfoOne;
        public RoomInfoTwo(RoomInfoOne roomInfoOne, List<string> _NurseStation, List<int> _OrInfo, string _roomTypeName)
        {
            // NurseStation List
            // [0] tpVideo          [2] printer         [4] audioCount
            // [1] tpPower          [3] musicPort       [5] inputCount

            // orInfo List
            // [0] booms            [2] wallDisp        [4] easyPort    [6] microphone
            // [1] sfd              [3] spkr            [5] camera

            InitializeComponent();
            this.Text = _roomTypeName;
            HideBooms(_OrInfo[0]);
            HideWallPlates(_OrInfo[4]);
            _roomInfoOne = roomInfoOne;
            NurseStation = _NurseStation;
            OrInfo = _OrInfo;
        }   

        private void HideBooms(int boom)
        {
            // 1 .. EQ 
            // 2 .. EQ + AN
            // 3 .. EQ + AN + Perf
            // 4 .. AN
            // 5 .. AN + Perf
            // 6 .. Perf
            // 7 .. Perf + EQ
            // 0 .. NONE
            switch(boom)
            {
                case 1:
                    grp_eq.Visible = true; grp_an.Visible = false; grp_perf.Visible = false;
                    break;
                case 2:
                    grp_eq.Visible = true; grp_an.Visible = true; grp_perf.Visible = false;
                    break;
                case 3:
                    grp_eq.Visible = true; grp_an.Visible = true; grp_perf.Visible = true;
                    break;
                case 4:
                    grp_eq.Visible = false; grp_an.Visible = true; grp_perf.Visible = false;
                    break;
                case 5:
                    grp_eq.Visible = false; grp_an.Visible = true; grp_perf.Visible = true;
                    break;
                case 6:
                    grp_eq.Visible = false; grp_an.Visible = false; grp_perf.Visible = true;
                    break;
                case 7:
                    grp_eq.Visible = true; grp_an.Visible = false; grp_perf.Visible = true;
                    break;
                case 0:
                    grp_eq.Visible = false; grp_an.Visible = false; grp_perf.Visible = false;
                    break;
            }
        }

        private void HideWallPlates(int easyPort)
        {
            if (easyPort == 0)
            { grp_wallplates.Visible = false; }
            else
            { grp_wallplates.Visible = true; }
        }

        private List<int> GetEasyPortTotals(int singleEq, int dualEq, int singleAn, int dualAn, int singlePerf, int dualPerf, int singleWall, int dualWall)
        {
            // EasyPortTotals List
            // [0] singleEq         [3] dualAn          [6] singleWall
            // [1] dualEq           [4] singlePerf      [7] dualWall
            // [2] singleAn         [5] dualPerf
            int[] ept = { singleEq, dualEq, singleAn, dualAn, singlePerf, dualPerf, singleWall, dualWall };
            List<int> easyPortTotals = new List<int>(ept);
            return easyPortTotals;
        }

        private void Btn_continue_Click(object sender, EventArgs e)
        {
            string specialInstructions = txt_spclInstructions.Text;
            string rtn = this.Text;

            if (OrInfo[4] != (((int)num_singleWall.Value * 1) + ((int)num_dualWall.Value * 2)))
            {
                MessageBox.Show("EasyPort Totals For 'Wall Plates' Don't Match Previous Total.");
            }
            else
            {
                List<int> easyPortTotals = GetEasyPortTotals((int)num_singleEq.Value, (int)num_dualEq.Value, (int)num_singleAn.Value, (int)num_dualAn.Value, (int)num_singlePerf.Value, (int)num_dualPerf.Value, (int)num_singleWall.Value, (int)num_dualWall.Value);
                this.Hide();

                RoomInfoThree frm = new RoomInfoThree(this, NurseStation, OrInfo, easyPortTotals, specialInstructions, rtn);
                frm.Show();
            }
            //MessageBox.Show(NurseStation[0]);
        }

        private void RoomInfoTwo_Load(object sender, EventArgs e)
        {
            num_singleEq.Minimum = 0;
            num_singleEq.Maximum = 5;
            num_singleAn.Minimum = 0;
            num_singleAn.Maximum = 5;
            num_singlePerf.Minimum = 0;
            num_singlePerf.Maximum = 5;
            num_singleWall.Minimum = 0;
            num_singleWall.Maximum = 5;
            num_dualEq.Minimum = 0;
            num_dualEq.Maximum = 5;
            num_dualAn.Minimum = 0;
            num_dualAn.Maximum = 5;
            num_dualPerf.Minimum = 0;
            num_dualPerf.Maximum = 5;
            num_dualWall.Minimum = 0;
            num_dualWall.Maximum = 5;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _roomInfoOne.Show();
        }

        //private void Btn_back_Click(object sender, EventArgs e)
        //{
        //    RoomInfoOne frm = new RoomInfoOne();
        //    frm.Show();
        //}
    } 
}
