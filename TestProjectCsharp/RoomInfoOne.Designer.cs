namespace TestProjectCsharp
{
    public partial class RoomInfoOne
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
            this.grpBoomType = new System.Windows.Forms.GroupBox();
            this.chk_anBoom = new System.Windows.Forms.CheckBox();
            this.chk_eqBoom = new System.Windows.Forms.CheckBox();
            this.chk_perfBoom = new System.Windows.Forms.CheckBox();
            this.lbl_sfd = new System.Windows.Forms.Label();
            this.lbl_wallDisp = new System.Windows.Forms.Label();
            this.lbl_spkr = new System.Windows.Forms.Label();
            this.num_sfd = new System.Windows.Forms.NumericUpDown();
            this.num_wallDisp = new System.Windows.Forms.NumericUpDown();
            this.lbl_easyPorts = new System.Windows.Forms.Label();
            this.num_easyPort = new System.Windows.Forms.NumericUpDown();
            this.grp_nurseStation = new System.Windows.Forms.GroupBox();
            this.grp_inputs = new System.Windows.Forms.GroupBox();
            this.num_inputCount = new System.Windows.Forms.NumericUpDown();
            this.lbl_inputs = new System.Windows.Forms.Label();
            this.grp_audio = new System.Windows.Forms.GroupBox();
            this.num_audioCount = new System.Windows.Forms.NumericUpDown();
            this.lbl_audioCount = new System.Windows.Forms.Label();
            this.cmbo_musicPort = new System.Windows.Forms.ComboBox();
            this.lbl_musicport = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_printer = new System.Windows.Forms.Label();
            this.cmbo_printer = new System.Windows.Forms.ComboBox();
            this.lbl_power = new System.Windows.Forms.Label();
            this.cmbo_tpPower = new System.Windows.Forms.ComboBox();
            this.lbl_tpVid = new System.Windows.Forms.Label();
            this.cmbo_tpVid = new System.Windows.Forms.ComboBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.grp_camera = new System.Windows.Forms.GroupBox();
            this.chk_ip = new System.Windows.Forms.CheckBox();
            this.chk_ptz = new System.Windows.Forms.CheckBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.cmbo_spkr = new System.Windows.Forms.ComboBox();
            this.grp_mic = new System.Windows.Forms.GroupBox();
            this.chk_micCeiling = new System.Windows.Forms.CheckBox();
            this.chk_micPTT = new System.Windows.Forms.CheckBox();
            this.chk_micSFD = new System.Windows.Forms.CheckBox();
            this.grpBoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sfd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wallDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_easyPort)).BeginInit();
            this.grp_nurseStation.SuspendLayout();
            this.grp_inputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_inputCount)).BeginInit();
            this.grp_audio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_audioCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_camera.SuspendLayout();
            this.grp_mic.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoomType
            // 
            this.grpBoomType.Controls.Add(this.chk_anBoom);
            this.grpBoomType.Controls.Add(this.chk_eqBoom);
            this.grpBoomType.Controls.Add(this.chk_perfBoom);
            this.grpBoomType.Location = new System.Drawing.Point(36, 32);
            this.grpBoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoomType.Name = "grpBoomType";
            this.grpBoomType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoomType.Size = new System.Drawing.Size(161, 185);
            this.grpBoomType.TabIndex = 0;
            this.grpBoomType.TabStop = false;
            this.grpBoomType.Text = "Boom Type:";
            // 
            // chk_anBoom
            // 
            this.chk_anBoom.AutoSize = true;
            this.chk_anBoom.Location = new System.Drawing.Point(29, 90);
            this.chk_anBoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_anBoom.Name = "chk_anBoom";
            this.chk_anBoom.Size = new System.Drawing.Size(115, 24);
            this.chk_anBoom.TabIndex = 3;
            this.chk_anBoom.Text = "Anesthesia";
            this.chk_anBoom.UseVisualStyleBackColor = true;
            // 
            // chk_eqBoom
            // 
            this.chk_eqBoom.AutoSize = true;
            this.chk_eqBoom.Location = new System.Drawing.Point(29, 45);
            this.chk_eqBoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_eqBoom.Name = "chk_eqBoom";
            this.chk_eqBoom.Size = new System.Drawing.Size(112, 24);
            this.chk_eqBoom.TabIndex = 1;
            this.chk_eqBoom.Text = "Equipment";
            this.chk_eqBoom.UseVisualStyleBackColor = true;
            // 
            // chk_perfBoom
            // 
            this.chk_perfBoom.AutoSize = true;
            this.chk_perfBoom.Location = new System.Drawing.Point(29, 132);
            this.chk_perfBoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_perfBoom.Name = "chk_perfBoom";
            this.chk_perfBoom.Size = new System.Drawing.Size(102, 24);
            this.chk_perfBoom.TabIndex = 2;
            this.chk_perfBoom.Text = "Perfusion";
            this.chk_perfBoom.UseVisualStyleBackColor = true;
            // 
            // lbl_sfd
            // 
            this.lbl_sfd.AutoSize = true;
            this.lbl_sfd.Location = new System.Drawing.Point(235, 32);
            this.lbl_sfd.Name = "lbl_sfd";
            this.lbl_sfd.Size = new System.Drawing.Size(219, 20);
            this.lbl_sfd.TabIndex = 1;
            this.lbl_sfd.Text = "Surgical Field Display - Count:";
            // 
            // lbl_wallDisp
            // 
            this.lbl_wallDisp.AutoSize = true;
            this.lbl_wallDisp.Location = new System.Drawing.Point(235, 104);
            this.lbl_wallDisp.Name = "lbl_wallDisp";
            this.lbl_wallDisp.Size = new System.Drawing.Size(154, 20);
            this.lbl_wallDisp.TabIndex = 2;
            this.lbl_wallDisp.Text = "Wall Display - Count:";
            // 
            // lbl_spkr
            // 
            this.lbl_spkr.AutoSize = true;
            this.lbl_spkr.Location = new System.Drawing.Point(235, 170);
            this.lbl_spkr.Name = "lbl_spkr";
            this.lbl_spkr.Size = new System.Drawing.Size(129, 20);
            this.lbl_spkr.TabIndex = 3;
            this.lbl_spkr.Text = "Speaker - Count:";
            // 
            // num_sfd
            // 
            this.num_sfd.Location = new System.Drawing.Point(464, 32);
            this.num_sfd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_sfd.Name = "num_sfd";
            this.num_sfd.Size = new System.Drawing.Size(47, 26);
            this.num_sfd.TabIndex = 4;
            // 
            // num_wallDisp
            // 
            this.num_wallDisp.Location = new System.Drawing.Point(398, 104);
            this.num_wallDisp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_wallDisp.Name = "num_wallDisp";
            this.num_wallDisp.Size = new System.Drawing.Size(47, 26);
            this.num_wallDisp.TabIndex = 5;
            // 
            // lbl_easyPorts
            // 
            this.lbl_easyPorts.AutoSize = true;
            this.lbl_easyPorts.Location = new System.Drawing.Point(235, 231);
            this.lbl_easyPorts.Name = "lbl_easyPorts";
            this.lbl_easyPorts.Size = new System.Drawing.Size(192, 20);
            this.lbl_easyPorts.TabIndex = 7;
            this.lbl_easyPorts.Text = "EasyPort On Wall - Count:";
            // 
            // num_easyPort
            // 
            this.num_easyPort.Location = new System.Drawing.Point(436, 231);
            this.num_easyPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_easyPort.Name = "num_easyPort";
            this.num_easyPort.Size = new System.Drawing.Size(47, 26);
            this.num_easyPort.TabIndex = 8;
            // 
            // grp_nurseStation
            // 
            this.grp_nurseStation.Controls.Add(this.grp_inputs);
            this.grp_nurseStation.Controls.Add(this.grp_audio);
            this.grp_nurseStation.Controls.Add(this.groupBox1);
            this.grp_nurseStation.Location = new System.Drawing.Point(36, 324);
            this.grp_nurseStation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_nurseStation.Name = "grp_nurseStation";
            this.grp_nurseStation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_nurseStation.Size = new System.Drawing.Size(574, 335);
            this.grp_nurseStation.TabIndex = 4;
            this.grp_nurseStation.TabStop = false;
            this.grp_nurseStation.Text = "Nurse Station:";
            // 
            // grp_inputs
            // 
            this.grp_inputs.Controls.Add(this.num_inputCount);
            this.grp_inputs.Controls.Add(this.lbl_inputs);
            this.grp_inputs.Location = new System.Drawing.Point(273, 208);
            this.grp_inputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_inputs.Name = "grp_inputs";
            this.grp_inputs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_inputs.Size = new System.Drawing.Size(248, 85);
            this.grp_inputs.TabIndex = 9;
            this.grp_inputs.TabStop = false;
            this.grp_inputs.Text = "Video Inputs On Booms:";
            // 
            // num_inputCount
            // 
            this.num_inputCount.Location = new System.Drawing.Point(88, 36);
            this.num_inputCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_inputCount.Name = "num_inputCount";
            this.num_inputCount.Size = new System.Drawing.Size(47, 26);
            this.num_inputCount.TabIndex = 12;
            // 
            // lbl_inputs
            // 
            this.lbl_inputs.AutoSize = true;
            this.lbl_inputs.Location = new System.Drawing.Point(26, 36);
            this.lbl_inputs.Name = "lbl_inputs";
            this.lbl_inputs.Size = new System.Drawing.Size(56, 20);
            this.lbl_inputs.TabIndex = 0;
            this.lbl_inputs.Text = "Count:";
            // 
            // grp_audio
            // 
            this.grp_audio.Controls.Add(this.num_audioCount);
            this.grp_audio.Controls.Add(this.lbl_audioCount);
            this.grp_audio.Controls.Add(this.cmbo_musicPort);
            this.grp_audio.Controls.Add(this.lbl_musicport);
            this.grp_audio.Location = new System.Drawing.Point(273, 50);
            this.grp_audio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_audio.Name = "grp_audio";
            this.grp_audio.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_audio.Size = new System.Drawing.Size(248, 134);
            this.grp_audio.TabIndex = 9;
            this.grp_audio.TabStop = false;
            this.grp_audio.Text = "Audio Inputs:";
            // 
            // num_audioCount
            // 
            this.num_audioCount.Location = new System.Drawing.Point(115, 79);
            this.num_audioCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_audioCount.Name = "num_audioCount";
            this.num_audioCount.Size = new System.Drawing.Size(47, 26);
            this.num_audioCount.TabIndex = 10;
            // 
            // lbl_audioCount
            // 
            this.lbl_audioCount.AutoSize = true;
            this.lbl_audioCount.Location = new System.Drawing.Point(25, 81);
            this.lbl_audioCount.Name = "lbl_audioCount";
            this.lbl_audioCount.Size = new System.Drawing.Size(56, 20);
            this.lbl_audioCount.TabIndex = 11;
            this.lbl_audioCount.Text = "Count:";
            // 
            // cmbo_musicPort
            // 
            this.cmbo_musicPort.FormattingEnabled = true;
            this.cmbo_musicPort.Location = new System.Drawing.Point(115, 38);
            this.cmbo_musicPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbo_musicPort.Name = "cmbo_musicPort";
            this.cmbo_musicPort.Size = new System.Drawing.Size(111, 28);
            this.cmbo_musicPort.TabIndex = 6;
            // 
            // lbl_musicport
            // 
            this.lbl_musicport.AutoSize = true;
            this.lbl_musicport.Location = new System.Drawing.Point(25, 38);
            this.lbl_musicport.Name = "lbl_musicport";
            this.lbl_musicport.Size = new System.Drawing.Size(83, 20);
            this.lbl_musicport.TabIndex = 10;
            this.lbl_musicport.Text = "MusicPort:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_printer);
            this.groupBox1.Controls.Add(this.cmbo_printer);
            this.groupBox1.Controls.Add(this.lbl_power);
            this.groupBox1.Controls.Add(this.cmbo_tpPower);
            this.groupBox1.Controls.Add(this.lbl_tpVid);
            this.groupBox1.Controls.Add(this.cmbo_tpVid);
            this.groupBox1.Location = new System.Drawing.Point(29, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(218, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Touch Panel:";
            // 
            // lbl_printer
            // 
            this.lbl_printer.AutoSize = true;
            this.lbl_printer.Location = new System.Drawing.Point(20, 115);
            this.lbl_printer.Name = "lbl_printer";
            this.lbl_printer.Size = new System.Drawing.Size(59, 20);
            this.lbl_printer.TabIndex = 5;
            this.lbl_printer.Text = "Printer:";
            // 
            // cmbo_printer
            // 
            this.cmbo_printer.FormattingEnabled = true;
            this.cmbo_printer.Location = new System.Drawing.Point(81, 115);
            this.cmbo_printer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbo_printer.Name = "cmbo_printer";
            this.cmbo_printer.Size = new System.Drawing.Size(111, 28);
            this.cmbo_printer.TabIndex = 4;
            // 
            // lbl_power
            // 
            this.lbl_power.AutoSize = true;
            this.lbl_power.Location = new System.Drawing.Point(20, 78);
            this.lbl_power.Name = "lbl_power";
            this.lbl_power.Size = new System.Drawing.Size(57, 20);
            this.lbl_power.TabIndex = 3;
            this.lbl_power.Text = "Power:";
            // 
            // cmbo_tpPower
            // 
            this.cmbo_tpPower.FormattingEnabled = true;
            this.cmbo_tpPower.Location = new System.Drawing.Point(81, 78);
            this.cmbo_tpPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbo_tpPower.Name = "cmbo_tpPower";
            this.cmbo_tpPower.Size = new System.Drawing.Size(111, 28);
            this.cmbo_tpPower.TabIndex = 2;
            // 
            // lbl_tpVid
            // 
            this.lbl_tpVid.AutoSize = true;
            this.lbl_tpVid.Location = new System.Drawing.Point(20, 40);
            this.lbl_tpVid.Name = "lbl_tpVid";
            this.lbl_tpVid.Size = new System.Drawing.Size(54, 20);
            this.lbl_tpVid.TabIndex = 1;
            this.lbl_tpVid.Text = "Video:";
            // 
            // cmbo_tpVid
            // 
            this.cmbo_tpVid.FormattingEnabled = true;
            this.cmbo_tpVid.Location = new System.Drawing.Point(81, 40);
            this.cmbo_tpVid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbo_tpVid.Name = "cmbo_tpVid";
            this.cmbo_tpVid.Size = new System.Drawing.Size(111, 28);
            this.cmbo_tpVid.TabIndex = 0;
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(436, 679);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(173, 38);
            this.btn_continue.TabIndex = 9;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.Btn_continue_Click);
            // 
            // grp_camera
            // 
            this.grp_camera.Controls.Add(this.chk_ip);
            this.grp_camera.Controls.Add(this.chk_ptz);
            this.grp_camera.Location = new System.Drawing.Point(36, 222);
            this.grp_camera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_camera.Name = "grp_camera";
            this.grp_camera.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_camera.Size = new System.Drawing.Size(100, 94);
            this.grp_camera.TabIndex = 4;
            this.grp_camera.TabStop = false;
            this.grp_camera.Text = "Camera:";
            // 
            // chk_ip
            // 
            this.chk_ip.AutoSize = true;
            this.chk_ip.Location = new System.Drawing.Point(29, 60);
            this.chk_ip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_ip.Name = "chk_ip";
            this.chk_ip.Size = new System.Drawing.Size(50, 24);
            this.chk_ip.TabIndex = 3;
            this.chk_ip.Text = "IP";
            this.chk_ip.UseVisualStyleBackColor = true;
            // 
            // chk_ptz
            // 
            this.chk_ptz.AutoSize = true;
            this.chk_ptz.Location = new System.Drawing.Point(29, 26);
            this.chk_ptz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_ptz.Name = "chk_ptz";
            this.chk_ptz.Size = new System.Drawing.Size(64, 24);
            this.chk_ptz.TabIndex = 1;
            this.chk_ptz.Text = "PTZ";
            this.chk_ptz.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(36, 679);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(173, 38);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // cmbo_spkr
            // 
            this.cmbo_spkr.FormattingEnabled = true;
            this.cmbo_spkr.Location = new System.Drawing.Point(371, 170);
            this.cmbo_spkr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbo_spkr.Name = "cmbo_spkr";
            this.cmbo_spkr.Size = new System.Drawing.Size(73, 28);
            this.cmbo_spkr.TabIndex = 13;
            // 
            // grp_mic
            // 
            this.grp_mic.Controls.Add(this.chk_micCeiling);
            this.grp_mic.Controls.Add(this.chk_micPTT);
            this.grp_mic.Controls.Add(this.chk_micSFD);
            this.grp_mic.Location = new System.Drawing.Point(238, 266);
            this.grp_mic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_mic.Name = "grp_mic";
            this.grp_mic.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_mic.Size = new System.Drawing.Size(272, 64);
            this.grp_mic.TabIndex = 5;
            this.grp_mic.TabStop = false;
            this.grp_mic.Text = "Microphone:";
            // 
            // chk_micCeiling
            // 
            this.chk_micCeiling.AutoSize = true;
            this.chk_micCeiling.Location = new System.Drawing.Point(170, 26);
            this.chk_micCeiling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_micCeiling.Name = "chk_micCeiling";
            this.chk_micCeiling.Size = new System.Drawing.Size(82, 24);
            this.chk_micCeiling.TabIndex = 4;
            this.chk_micCeiling.Text = "Ceiling";
            this.chk_micCeiling.UseVisualStyleBackColor = true;
            // 
            // chk_micPTT
            // 
            this.chk_micPTT.AutoSize = true;
            this.chk_micPTT.Location = new System.Drawing.Point(99, 26);
            this.chk_micPTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_micPTT.Name = "chk_micPTT";
            this.chk_micPTT.Size = new System.Drawing.Size(63, 24);
            this.chk_micPTT.TabIndex = 3;
            this.chk_micPTT.Text = "PTT";
            this.chk_micPTT.UseVisualStyleBackColor = true;
            // 
            // chk_micSFD
            // 
            this.chk_micSFD.AutoSize = true;
            this.chk_micSFD.Location = new System.Drawing.Point(29, 26);
            this.chk_micSFD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_micSFD.Name = "chk_micSFD";
            this.chk_micSFD.Size = new System.Drawing.Size(68, 24);
            this.chk_micSFD.TabIndex = 1;
            this.chk_micSFD.Text = "SFD";
            this.chk_micSFD.UseVisualStyleBackColor = true;
            // 
            // RoomInfoOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 745);
            this.Controls.Add(this.grp_mic);
            this.Controls.Add(this.cmbo_spkr);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.grp_camera);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.grp_nurseStation);
            this.Controls.Add(this.num_easyPort);
            this.Controls.Add(this.lbl_easyPorts);
            this.Controls.Add(this.num_wallDisp);
            this.Controls.Add(this.num_sfd);
            this.Controls.Add(this.lbl_spkr);
            this.Controls.Add(this.lbl_wallDisp);
            this.Controls.Add(this.lbl_sfd);
            this.Controls.Add(this.grpBoomType);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoomInfoOne";
            this.Text = "a";
            this.Load += new System.EventHandler(this.RoomInfoOne_Load);
            this.grpBoomType.ResumeLayout(false);
            this.grpBoomType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sfd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wallDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_easyPort)).EndInit();
            this.grp_nurseStation.ResumeLayout(false);
            this.grp_inputs.ResumeLayout(false);
            this.grp_inputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_inputCount)).EndInit();
            this.grp_audio.ResumeLayout(false);
            this.grp_audio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_audioCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_camera.ResumeLayout(false);
            this.grp_camera.PerformLayout();
            this.grp_mic.ResumeLayout(false);
            this.grp_mic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoomType;
        private System.Windows.Forms.CheckBox chk_anBoom;
        private System.Windows.Forms.CheckBox chk_eqBoom;
        private System.Windows.Forms.CheckBox chk_perfBoom;
        private System.Windows.Forms.Label lbl_sfd;
        private System.Windows.Forms.Label lbl_wallDisp;
        private System.Windows.Forms.Label lbl_spkr;
        private System.Windows.Forms.NumericUpDown num_sfd;
        private System.Windows.Forms.NumericUpDown num_wallDisp;
        private System.Windows.Forms.Label lbl_easyPorts;
        private System.Windows.Forms.NumericUpDown num_easyPort;
        private System.Windows.Forms.GroupBox grp_nurseStation;
        private System.Windows.Forms.GroupBox grp_inputs;
        private System.Windows.Forms.NumericUpDown num_inputCount;
        private System.Windows.Forms.Label lbl_inputs;
        private System.Windows.Forms.GroupBox grp_audio;
        private System.Windows.Forms.NumericUpDown num_audioCount;
        private System.Windows.Forms.Label lbl_audioCount;
        private System.Windows.Forms.ComboBox cmbo_musicPort;
        private System.Windows.Forms.Label lbl_musicport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_printer;
        private System.Windows.Forms.ComboBox cmbo_printer;
        private System.Windows.Forms.Label lbl_power;
        private System.Windows.Forms.ComboBox cmbo_tpPower;
        private System.Windows.Forms.Label lbl_tpVid;
        private System.Windows.Forms.ComboBox cmbo_tpVid;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.GroupBox grp_camera;
        private System.Windows.Forms.CheckBox chk_ip;
        private System.Windows.Forms.CheckBox chk_ptz;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmbo_spkr;
        private System.Windows.Forms.GroupBox grp_mic;
        private System.Windows.Forms.CheckBox chk_micCeiling;
        private System.Windows.Forms.CheckBox chk_micPTT;
        private System.Windows.Forms.CheckBox chk_micSFD;
    }
}