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
    public partial class RoomInfoThree : Form
    {
        private RoomInfoTwo _roomInfoTwo;
        public List<string> NurseStation { get; set; }
        public List<int> OrInfo { get; set; }
        public List<int> EasyPortTotals { get; set; }
        public int VideoInput { get; set; }
        public int VideoOutput { get; set; }
        public int FutureCable { get; set; }
        public int MicFuture { get; set; }

        public string specialInstructions;
        public int _ptzInput = 1;
        public int _futureInput = 101;
        public int _VideoInput = 2;
        public int _VideoOutput = 23;
        // NurseStation List
        // [0] tpVideo          [2] printer         [4] audioCount
        // [1] tpPower          [3] musicPort       [5] inputCount

        // orInfo List
        // [0] booms            [2] wallDisp        [4] easyPort    [6] microphone
        // [1] sfd              [3] spkr            [5] camera

        // EasyPortTotals List
        // [0] singleEq         [3] dualAn          [6] singleWall
        // [1] dualEq           [4] singlePerf      [7] dualWall
        // [2] singleAn         [5] dualPerf
        public RoomInfoThree(RoomInfoTwo roomInfoTwo, List<string> _NurseStation, List<int> _OrInfo, List<int> _EasyPortTotals, string _specialInstructions, string _roomTypeName)
        {
            InitializeComponent();
            this.Text = _roomTypeName;
            _roomInfoTwo = roomInfoTwo;
            NurseStation = _NurseStation;
            OrInfo = _OrInfo;
            EasyPortTotals = _EasyPortTotals;
            specialInstructions = _specialInstructions;
            VideoInput = _VideoInput;
            VideoOutput = _VideoOutput;
            FutureCable = _futureInput;
            MicFuture = _futureInput;

            dgv_eqBoom.AllowUserToAddRows = false;
            dgv_anBoom.AllowUserToAddRows = false;
            dgv_perfBoom.AllowUserToAddRows = false;
            dgv_camera.AllowUserToAddRows = false;
            dgv_nrs.AllowUserToAddRows = false;
            dgv_wallplates.AllowUserToAddRows = false;
            dgv_sfd.AllowUserToAddRows = false;
            dgv_wallDisp.AllowUserToAddRows = false;
            dgv_spkr.AllowUserToAddRows = false;
        }

        private void CreateDgvHeaders(DataGridView dgv)
        {
            dgv.ColumnCount = 3;
            dgv.Columns[0].Name = "Label";
            dgv.Columns[1].Name = "Cable";
            dgv.Columns[2].Name = "Purpose";
        }

        // i = 1 .. EQ 
        // i = 2 .. EQ + AN
        // i = 3 .. EQ + AN + Perf
        // i = 4 .. AN
        // i = 5 .. AN + Perf
        // i = 6 .. Perf
        // i = 7 .. Perf + EQ
        // i = 0 .. NONE
        private void PopulateEqBoom (List<int> _OrInfo, List<int> _EasyPortTotals)
        {
            if (_OrInfo[0] == 1 || _OrInfo[0] == 2 || _OrInfo[0] == 3 || _OrInfo[0] == 7)
            {
                int videoLines = (_EasyPortTotals[0] * 1) + (_EasyPortTotals[1] * 2);

                CreateDgvHeaders(dgv_eqBoom);
                dgv_eqBoom.Rows.Add("Operating Room - \nEquipment Boom");

                if (_OrInfo[1] >= 2)
                {
                    for (int i = 41; i <= 44; i++)
                    {
                        dgv_eqBoom.Rows.Add("VM-" + i, "Mini59", "Back-Up");
                    }
                }
                else if (_OrInfo[1] == 1)
                {
                    for (int i = 41; i <= 42; i++)
                    {
                        dgv_eqBoom.Rows.Add("VM-" + i, "Mini59", "Back-Up");
                    }
                }
                else { }

                for (int i = 0; i < videoLines; i++)
                {
                    dgv_eqBoom.Rows.Add("V-" + VideoInput, "RG59", "EasyPort");
                    VideoInput++;
                }

                for (int i = 0; i < 2; i++)
                {
                    dgv_eqBoom.Rows.Add("V-" + FutureCable, "RG59", "Spare");
                    FutureCable++;
                }

                dgv_eqBoom.Rows.Add("CA-03", "24/2", "Footswitch");
                dgv_eqBoom.Rows.Add("CA-13", "24/2", "Footswitch");
            }
            else { grp_eq.Visible = false; }
        }
        private void PopulateAnBoom(List<int> _OrInfo, List<int> _EasyPortTotals)
        {
            if (_OrInfo[0] == 2 || _OrInfo[0] == 3 || _OrInfo[0] == 4 || _OrInfo[0] == 5)
            {
                int videoLines = (_EasyPortTotals[2] * 1) + (_EasyPortTotals[3] * 2);

                CreateDgvHeaders(dgv_anBoom);
                dgv_anBoom.Rows.Add("Operating Room - \nAnesthesia Boom");

                for (int i = 0; i < videoLines; i++)
                {
                    dgv_anBoom.Rows.Add("V-" + VideoInput, "RG59", "EasyPort");
                    VideoInput++;
                }

                for (int i = 0; i < 1; i++)
                {
                    dgv_anBoom.Rows.Add("V-" + FutureCable, "RG59", "Spare");
                    FutureCable++;
                }
            }
            else { grp_an.Visible = false; }
        }
        private void PopulatePerfBoom(List<int> _OrInfo, List<int> _EasyPortTotals)
        {

            if (_OrInfo[0] == 3 || _OrInfo[0] == 5 || _OrInfo[0] == 6 || _OrInfo[0] == 7)
            {
                int videoLines = (_EasyPortTotals[4] * 1) + (_EasyPortTotals[5] * 2);

                CreateDgvHeaders(dgv_perfBoom);
                dgv_perfBoom.Rows.Add("Operating Room - \nPerfusion Boom");

                for (int i = 0; i < videoLines; i++)
                {
                    dgv_perfBoom.Rows.Add("V-" + VideoInput, "RG59", "EasyPort");
                    VideoInput++;
                }

                for (int i = 0; i < 1; i++)
                {
                    dgv_perfBoom.Rows.Add("V-" + FutureCable, "RG59", "Spare");
                    FutureCable++;
                }
            }
            else { grp_perf.Visible = false; }
        }
        private void PopulateNurseStation(List<string> NurseStation)
        {
            // NurseStation List
            // [0] tpVideo          [2] printer         [4] audioCount
            // [1] tpPower          [3] musicPort       [5] inputCount

            CreateDgvHeaders(dgv_nrs);

            if (this.Text.ToLower().Contains("hybrid"))
            {
                dgv_nrs.Rows.Add("Operating Room - \nNurse Station");

                if (NurseStation[0] == "RGB") { dgv_nrs.Rows.Add("HR-22", "RGB", "TP Video"); }
                else { dgv_nrs.Rows.Add("DV-22", "Cat6", "TP Video"); }

                if (NurseStation[1] == "Remote") { dgv_nrs.Rows.Add("PA-10", "14-2", "Power"); }
                else { }

                dgv_nrs.Rows.Add("CD-4", "Cat5", "M&K");
                dgv_nrs.Rows.Add("CD-5", "Cat5", "TP Ctrl");

                // SPARE CABLES
                for (int i = 0; i < 3; i++)
                {
                    dgv_nrs.Rows.Add("V-" + FutureCable, "RG59", "Spare");
                    FutureCable++;
                    dgv_nrs.Rows.Add("AS-" + MicFuture, "24-2pr", "Spare");
                    MicFuture++;
                }

                dgv_nrs.Rows.Add("Control Room - \nNurse Station");

                if (NurseStation[0] == "RGB") { dgv_nrs.Rows.Add("HR-21", "RGB", "TP Video"); }
                else { dgv_nrs.Rows.Add("DV-21", "Cat6", "TP Video"); }

                if (NurseStation[1] == "Remote") { dgv_nrs.Rows.Add("PA-9", "14-2", "Power"); }
                else { }

                dgv_nrs.Rows.Add("CD-1", "Cat5", "M&K");
                dgv_nrs.Rows.Add("CD-2", "Cat5", "TP Ctrl");

                if (NurseStation[2] == "Yes") { dgv_nrs.Rows.Add("CE-8", "Cat5", "Printer"); }
                else { }

                if (Convert.ToInt32(NurseStation[4]) > 0)
                {
                    if (NurseStation[3] == "Yes")
                    {
                        dgv_nrs.Rows.Add("AS-1", "24-2pr", "Audio");
                        dgv_nrs.Rows.Add("AS-2", "24-2pr", "MusicPort");
                        dgv_nrs.Rows.Add("AS-3", "24-2pr", "Audio");
                    }
                    else
                    {
                        int j = 1;
                        for (int i = 0; i < Convert.ToInt32(NurseStation[4]); i++)
                        {
                            dgv_nrs.Rows.Add("AS-" + j, "24-2pr", "Audio");
                            j++;
                        }
                    }
                }

                if (Convert.ToInt32(NurseStation[5]) > 0)
                {
                    for (int i = 0; i < Convert.ToInt32(NurseStation[5]); i++)
                    {
                        dgv_nrs.Rows.Add("V-" + VideoInput, "RG59", "EasyPort");
                        VideoInput++;
                    }
                }

                // SPARE CABLES
                for (int i = 0; i < 3; i++)
                {
                    dgv_nrs.Rows.Add("V-" + FutureCable, "RG59", "Spare");
                    FutureCable++;
                }
            }
            else
            {
                if (NurseStation[0] == "RGB") { dgv_nrs.Rows.Add("HR-21", "RGB", "TP Video"); }
                else { dgv_nrs.Rows.Add("DV-21", "Cat6", "TP Video"); }

                if (NurseStation[1] == "Remote") { dgv_nrs.Rows.Add("PA-9", "14-2", "Power"); }
                else { }

                dgv_nrs.Rows.Add("CD-1", "Cat5", "M&K");
                dgv_nrs.Rows.Add("CD-2", "Cat5", "TP Ctrl");

                if (NurseStation[2] == "Yes") { dgv_nrs.Rows.Add("CE-8", "Cat5", "Printer"); }
                else { }

                if (Convert.ToInt32(NurseStation[4]) > 0)
                {
                    if (NurseStation[3] == "Yes")
                    {
                        dgv_nrs.Rows.Add("AS-1", "24-2pr", "Audio");
                        dgv_nrs.Rows.Add("AS-2", "24-2pr", "MusicPort");
                        dgv_nrs.Rows.Add("AS-3", "24-2pr", "Audio");
                    }
                    else
                    {
                        int j = 1;
                        for (int i = 0; i < Convert.ToInt32(NurseStation[4]); i++)
                        {
                            dgv_nrs.Rows.Add("AS-" + j, "24-2pr", "Audio");
                            j++;
                        }
                    }
                }

                if (Convert.ToInt32(NurseStation[5]) > 0)
                {
                    for (int i = 0; i < Convert.ToInt32(NurseStation[5]); i++)
                    {
                        dgv_nrs.Rows.Add("V-" + VideoInput, "RG59", "EasyPort");
                        VideoInput++;
                    }
                }

                // SPARE CABLES
                for (int i = 0; i < 3; i++)
                {
                    dgv_nrs.Rows.Add("V-" + FutureCable, "RG59", "Spare");
                    FutureCable++;
                }
            }

        }
        // OrInfo[4] = EasyPort Wallplates
        // EasyPortTotals[6] and [7] = SinglePort and DualPort
        private void PopulateWallPlates()
        {
            if (OrInfo[4] > 0)
            {
                CreateDgvHeaders(dgv_wallplates);
                dgv_wallplates.Rows.Add("Operating Room - \nEasyPort WallPlates");

                int count = 1;
                //if (EasyPortTotals[6] > 0)
                //{
                    for (int i = 0; i < EasyPortTotals[6]; i++)
                    {
                        dgv_wallplates.Rows.Add("Wall Plate " + count);
                        dgv_wallplates.Rows.Add("V-" + VideoInput, "RG59", "EasyPort");
                        VideoInput++;
                        dgv_wallplates.Rows.Add("V-" + FutureCable, "RG59", "Spare");
                        FutureCable++;
                        count++;
                    }
                //}
                //else if (EasyPortTotals[7] > 0)
                //{
                    for (int i = 0; i < EasyPortTotals[7]; i++)
                    {
                        dgv_wallplates.Rows.Add("Wall Plate " + count);
                        dgv_wallplates.Rows.Add("V-" + VideoInput, "RG59", "EasyPort");
                        VideoInput++;
                        dgv_wallplates.Rows.Add("V-" + VideoInput, "RG59", "EasyPort");
                        VideoInput++;
                        count++;
                    }
                //}
            }
            else { grp_wallplates.Visible = false; }
        }
        private void InfoSFD(int count, int sfdPower)
        {
            if (count == 1)
            {
                dgv_sfd.Rows.Add("SFD " + count);
                dgv_sfd.Rows.Add("V-" + VideoOutput, "RG59", "Video");
                dgv_sfd.Rows.Add("PC-" + sfdPower, "14-3", "Power");

                // 1 = SFD      3 = Ceiling     5 = PTT + Ceiling   7 = SFD + PTT + Ceiling
                // 2 = PTT      4 = SFD + PTT   6 = SFD + Ceiling
                if (OrInfo[6] == 1 || OrInfo[6] == 4 || OrInfo[6] == 6 || OrInfo[6] == 7)
                {
                    dgv_sfd.Rows.Add("AM-5", "24-2pr", "Mic");
                }

                dgv_sfd.Rows.Add("VM-41", "mini59", "Back-Up");
                dgv_sfd.Rows.Add("VM-42", "mini59", "Back-Up");
            }
            else if (count == 2)
            {
                dgv_sfd.Rows.Add("SFD " + count);
                dgv_sfd.Rows.Add("V-" + VideoOutput, "RG59", "Video");
                dgv_sfd.Rows.Add("PC-" + sfdPower, "14-3", "Power");
                dgv_sfd.Rows.Add("AS-" + MicFuture, "24-2pr", "Mic");
                dgv_sfd.Rows.Add("VM-43", "mini59", "Back-Up");
                dgv_sfd.Rows.Add("VM-44", "mini59", "Back-Up");
                MicFuture++;
            }
            else if (count > 2)
            {
                dgv_sfd.Rows.Add("SFD " + count);
                dgv_sfd.Rows.Add("V-" + VideoOutput, "RG59", "Video");
                dgv_sfd.Rows.Add("PC-" + sfdPower, "14-3", "Power");
                dgv_sfd.Rows.Add("AS-" + MicFuture, "24-2pr", "Mic");
                MicFuture++;
            }
            else { }
        }
        // OrInfo[1] = SFD count
        private void PopulateSFDs()
        {
            if (OrInfo[1] > 0)
            {
                CreateDgvHeaders(dgv_sfd);
                dgv_sfd.Rows.Add("Operating Room - \nSurgical Field Displays");

                int count = 1;
                int sfdPower = 1;

                for (int i = 0; i < OrInfo[1]; i++)
                {
                    InfoSFD(count, sfdPower);
                    VideoOutput++;
                    count++;
                    sfdPower++;
                }
            }
            else { grp_sfd.Visible = false; }
        }
        // OrInfo[2] = Wall Display count
        private void PopulateWallDisplays()
        {
            if (OrInfo[2] > 0)
            {
                int count = 1;

                CreateDgvHeaders(dgv_wallDisp);
                dgv_wallDisp.Rows.Add("Operating Room - \nWall Displays");

                for (int i = 0; i < OrInfo[2]; i++)
                {
                    dgv_wallDisp.Rows.Add("Wall Display " + count);
                    dgv_wallDisp.Rows.Add("V-" + VideoOutput, "RG59", "Video");
                    count++;
                    VideoOutput++;
                }
            }
            else { grp_wallDisp.Visible = false; }
        }
        //OrInfo[5] = Camera        1 = PTZ     2 = IP      3 = PTZ + IP
        private void PopulateCamera()
        {
            if (OrInfo[5] > 0)
            {
                CreateDgvHeaders(dgv_camera);
                dgv_camera.Rows.Add("Operating Room - \nCameras");
                if (OrInfo[5] == 1)
                {
                    dgv_camera.Rows.Add("PTZ", FontStyle.Bold);
                    dgv_camera.Rows.Add("V-1", "RG59", "Video");
                    dgv_camera.Rows.Add("PA-2", "14-2", "Power");
                    dgv_camera.Rows.Add("CE-1", "Cat5", "Control");
                }
                else if (OrInfo[5] == 2)
                {
                    dgv_camera.Rows.Add("IP", FontStyle.Bold);
                    dgv_camera.Rows.Add("CE-7", "Cat5", "Control");
                }
                else if (OrInfo[5] == 3)
                {
                    dgv_camera.Rows.Add("PTZ");
                    dgv_camera.Rows.Add("V-1", "RG59", "Video");
                    dgv_camera.Rows.Add("PA-2", "14-2", "Power");
                    dgv_camera.Rows.Add("CE-1", "Cat5", "Control");
                    dgv_camera.Rows.Add("IP");
                    dgv_camera.Rows.Add("CE-7", "Cat5", "Control");
                }
            }
            else { grp_camera.Visible = false; }
        }
        // OrInfo[3] = Speakers
        private void PopulateSpeakers()
        {
            if (OrInfo[3] > 0)
            {
                CreateDgvHeaders(dgv_spkr);
                for (int i = 0; i < OrInfo[3]; i++)
                {
                    if (i == 0) { dgv_spkr.Rows.Add("Operating Room - \nSpeakers"); }
                    else if (i == 4) { dgv_spkr.Rows.Add("Control Room - \nSpeakers"); }
                                        
                    dgv_spkr.Rows.Add("SP-" + (i + 1), "14-2", "Audio");
                }
            }
            else { grp_spkr.Visible = false; }
        }
        private void PopulateSpecialInstructions()
        {
            txt_spcl.Text = specialInstructions;
        }
        private void RoomInfoThree_Load(object sender, EventArgs e)
        {
            PopulateEqBoom(OrInfo, EasyPortTotals);
            PopulateAnBoom(OrInfo, EasyPortTotals);
            PopulatePerfBoom(OrInfo, EasyPortTotals);
            PopulateNurseStation(NurseStation);
            PopulateWallPlates();
            PopulateSFDs();
            PopulateWallDisplays();
            PopulateCamera();
            PopulateSpeakers();
            PopulateSpecialInstructions();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _roomInfoTwo.Show();
        }

        private void btn_exportToWord_Click(object sender, EventArgs e)
        {
            CreateWordDoc createWordDoc = new CreateWordDoc();

            createWordDoc.ExportToWord(dgv_eqBoom, dgv_anBoom, dgv_perfBoom, dgv_camera, dgv_nrs, dgv_wallplates, dgv_sfd, dgv_wallDisp, dgv_spkr, txt_spcl.Text);
        }
    }
}
