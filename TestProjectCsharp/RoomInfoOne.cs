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
    public partial class RoomInfoOne : Form
    {

        private RoomType _roomType;
        public RoomInfoOne(RoomType roomType, string _roomTypeName)
        {
            InitializeComponent();
            this.Text = _roomTypeName;
            _roomType = roomType;
        }

        private void RoomInfoOne_Load(object sender, EventArgs e)
        {
            //       InitializeComponent();

            num_sfd.Minimum = 0;
            num_sfd.Maximum = 10;
            num_wallDisp.Minimum = 0;
            num_wallDisp.Maximum = 10;
            num_easyPort.Minimum = 0;
            num_easyPort.Maximum = 10;
            num_audioCount.Minimum = 0;
            num_audioCount.Maximum = 3;
            num_inputCount.Minimum = 0;
            num_inputCount.Maximum = 10;
            cmbo_spkr.DisplayMember = "Text";
            cmbo_spkr.ValueMember = "Value";
            cmbo_spkr.Items.Add(new { Text = "2", Value = "2" });
            cmbo_spkr.Items.Add(new { Text = "4", Value = "4" });
            cmbo_spkr.Items.Add(new { Text = "6", Value = "6" });


            cmbo_tpVid.DisplayMember = "Text";
            cmbo_tpVid.ValueMember = "Value";
            cmbo_tpVid.Items.Add(new { Text = "RGB", Value = "rgb" });
            cmbo_tpVid.Items.Add(new { Text = "Cat6", Value = "cat6" });
            cmbo_tpPower.DisplayMember = "Text";
            cmbo_tpPower.ValueMember = "Value";
            cmbo_tpPower.Items.Add(new { Text = "Remote", Value = "remote" });
            cmbo_tpPower.Items.Add(new { Text = "Local", Value = "local" });
            cmbo_printer.DisplayMember = "Text";
            cmbo_printer.ValueMember = "Value";
            cmbo_printer.Items.Add(new { Text = "Yes", Value = "yes" });
            cmbo_printer.Items.Add(new { Text = "No", Value = "no" });
            cmbo_musicPort.DisplayMember = "Text";
            cmbo_musicPort.ValueMember = "Value";
            cmbo_musicPort.Items.Add(new { Text = "Yes", Value = "yes" });
            cmbo_musicPort.Items.Add(new { Text = "No", Value = "no" });
        }

        private int ComboBoxCheckerNurseStation(string tpVid, string tpPower, string printer, string musicPort)
        {
            int i = 0;
            if (tpVid == "RGB" || tpVid == "Cat6") { }
            else
            {
                MessageBox.Show("Please select RGB or Cat6 for the Touch Panel Video.");
                i++;
                // throw new Exception("Touch Panel Video.  Option not selected.");
            }
            if (tpPower == "Local" || tpPower == "Remote") { }
            else
            {
                MessageBox.Show("Please select Remote or Local for the Touch Panel Power.");
                i++;
                // throw new Exception("Touch Panel Power.  Option not selected.");
            }
            if (printer == "Yes" || printer == "No") { }
            else
            {
                MessageBox.Show("Please select Yes or No for the Printer.");
                i++;
                // throw new Exception("Printer.  Option not selected.");
            }
            if (musicPort == "Yes" || musicPort == "No") { }
            else
            {
                MessageBox.Show("Please select Yes or No for the MusicPort.");
                i++;
                // throw new Exception("MusicPort.  Option not selected.");
            }
            return i;
        }

        private int BoomChecker()
        {
            int i = 0;
            // i = 1 .. EQ 
            // i = 2 .. EQ + AN
            // i = 3 .. EQ + AN + Perf
            // i = 4 .. AN
            // i = 5 .. AN + Perf
            // i = 6 .. Perf
            // i = 7 .. Perf + EQ
            // i = 0 .. NONE
            if (chk_eqBoom.Checked == true && chk_anBoom.Checked == false && chk_perfBoom.Checked == false)
            { i = 1; }
            else if (chk_eqBoom.Checked == true && chk_anBoom.Checked == true && chk_perfBoom.Checked == false)
            { i = 2; }
            else if (chk_eqBoom.Checked == true && chk_anBoom.Checked == true && chk_perfBoom.Checked == true)
            { i = 3; }
            else if (chk_eqBoom.Checked == false && chk_anBoom.Checked == true && chk_perfBoom.Checked == false)
            { i = 4; }
            else if (chk_eqBoom.Checked == false && chk_anBoom.Checked == true && chk_perfBoom.Checked == true)
            { i = 5; }
            else if (chk_eqBoom.Checked == false && chk_anBoom.Checked == false && chk_perfBoom.Checked == true)
            { i = 6; }
            else if (chk_eqBoom.Checked == true && chk_anBoom.Checked == false && chk_perfBoom.Checked == true)
            { i = 7; }
            else
            { return 0; }
            return i;
        }

        private int CameraChecker()
        {
            int i = 0;
            if (chk_ptz.Checked == true && chk_ip.Checked == false) { i = 1; }
            else if (chk_ptz.Checked == false && chk_ip.Checked == true) { i = 2; }
            else if (chk_ptz.Checked == true && chk_ip.Checked == true) { i = 3; }
            else { return i; }
            return i;
        }

        // 1 = SFD      3 = Ceiling     5 = PTT + Ceiling   7 = SFD + PTT + Ceiling
        // 2 = PTT      4 = SFD + PTT   6 = SFD + Ceiling
        private int MicrophoneChecker()
        {
            int i = 0;
            if (chk_micSFD.Checked == true && chk_micPTT.Checked == false && chk_micCeiling.Checked == false) { i = 1; }
            else if (chk_micSFD.Checked == false && chk_micPTT.Checked == true && chk_micCeiling.Checked == false) { i = 2; }
            else if (chk_micSFD.Checked == false && chk_micPTT.Checked == false && chk_micCeiling.Checked == true) { i = 3; }
            else if (chk_micSFD.Checked == true && chk_micPTT.Checked == true && chk_micCeiling.Checked == false) { i = 4; }
            else if (chk_micSFD.Checked == false && chk_micPTT.Checked == true && chk_micCeiling.Checked == true) { i = 5; }
            else if (chk_micSFD.Checked == true && chk_micPTT.Checked == false && chk_micCeiling.Checked == true) { i = 6; }
            else if (chk_micSFD.Checked == true && chk_micPTT.Checked == true && chk_micCeiling.Checked == true) { i = 7; }
            else { return i; }
            return i;
        }

        private List<string> NurseStation(string tpVideo, string tpPower, string printer, string musicPort, double audioCount, double inputCount)
        {
            // nurseStation List
            // [0] tpVideo          [2] printer         [4] audioCount
            // [1] tpPower          [3] musicPort       [5] inputCount
            string[] ns = { tpVideo, tpPower, printer, musicPort, Convert.ToString(audioCount), Convert.ToString(inputCount) };
            List<string> nurseStation = new List<string>(ns);
            return nurseStation;
        }

        private List<int> OrInfo(int booms, int sfd, int wallDisp, int spkr, int easyPort, int camera, int mic)
        {
            // orInfo List
            // [0] booms            [2] wallDisp        [4] easyPort    [6] microphone
            // [1] sfd              [3] spkr            [5] camera
            int[] or = { booms, sfd, wallDisp, spkr, easyPort, camera, mic };
            List<int> orInfo = new List<int>(or);
            return orInfo;
        }

        private void Btn_continue_Click(object sender, EventArgs e)
        {
            int cbc = 0;
            cbc = ComboBoxCheckerNurseStation(cmbo_tpVid.Text, cmbo_tpPower.Text, cmbo_printer.Text, cmbo_musicPort.Text);

            List <string> nurseStation = NurseStation(cmbo_tpVid.Text, cmbo_tpPower.Text, cmbo_printer.Text, cmbo_musicPort.Text, (double)num_audioCount.Value, (double)num_inputCount.Value);
            List<int> orInfo = OrInfo(BoomChecker(), (int)num_sfd.Value, (int)num_wallDisp.Value, (int)Convert.ToInt32(cmbo_spkr.Text), (int)num_easyPort.Value, CameraChecker(), MicrophoneChecker());

            string rtn = this.Text;

            if (cbc == 0)
            {
                this.Hide();

                RoomInfoTwo frm = new RoomInfoTwo(this, nurseStation, orInfo, rtn);
                frm.Show();
            }
            else { }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _roomType.Show(this);
        }
    }
}
