namespace Wisol_Vacuum
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnStartNewLot = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picturePLC = new System.Windows.Forms.PictureBox();
            this.pictureBtnSetting = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentBarcode = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblTitleLot = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.groupBoxTotalLot = new System.Windows.Forms.GroupBox();
            this.lblTotalLot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waittime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeVacuum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempOrdinary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStartLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEndLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperatureWorking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnSetting)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxTotalLot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1209, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Designed by";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnStartNewLot);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 76);
            this.panel1.TabIndex = 5;
            // 
            // BtnStartNewLot
            // 
            this.BtnStartNewLot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.BtnStartNewLot.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartNewLot.ForeColor = System.Drawing.Color.White;
            this.BtnStartNewLot.Location = new System.Drawing.Point(390, 18);
            this.BtnStartNewLot.Name = "BtnStartNewLot";
            this.BtnStartNewLot.Size = new System.Drawing.Size(137, 43);
            this.BtnStartNewLot.TabIndex = 8;
            this.BtnStartNewLot.Text = "Start New Lot";
            this.BtnStartNewLot.UseVisualStyleBackColor = false;
            this.BtnStartNewLot.Click += new System.EventHandler(this.BtnStartNewLot_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(76, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 21);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vaccum Data Monotoring";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Wisol_Vacuum.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Wisol_Vacuum.Properties.Resources.MSlogo;
            this.pictureBox2.Location = new System.Drawing.Point(1151, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.picturePLC);
            this.panel2.Controls.Add(this.pictureBtnSetting);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 745);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::Wisol_Vacuum.Properties.Resources.database;
            this.pictureBox3.Location = new System.Drawing.Point(6, 640);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // picturePLC
            // 
            this.picturePLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picturePLC.Image = global::Wisol_Vacuum.Properties.Resources.plc;
            this.picturePLC.Location = new System.Drawing.Point(6, 691);
            this.picturePLC.Name = "picturePLC";
            this.picturePLC.Size = new System.Drawing.Size(34, 34);
            this.picturePLC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePLC.TabIndex = 1;
            this.picturePLC.TabStop = false;
            this.picturePLC.Click += new System.EventHandler(this.picturePLC_Click);
            // 
            // pictureBtnSetting
            // 
            this.pictureBtnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBtnSetting.Image = global::Wisol_Vacuum.Properties.Resources.settings;
            this.pictureBtnSetting.Location = new System.Drawing.Point(6, 590);
            this.pictureBtnSetting.Name = "pictureBtnSetting";
            this.pictureBtnSetting.Size = new System.Drawing.Size(34, 34);
            this.pictureBtnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBtnSetting.TabIndex = 0;
            this.pictureBtnSetting.TabStop = false;
            this.pictureBtnSetting.Click += new System.EventHandler(this.pictureBtnSetting_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblCurrentBarcode);
            this.panel3.Controls.Add(this.lblProgress);
            this.panel3.Controls.Add(this.lblTitleLot);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Controls.Add(this.groupBoxTotalLot);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 745);
            this.panel3.TabIndex = 7;
            // 
            // lblCurrentBarcode
            // 
            this.lblCurrentBarcode.AutoSize = true;
            this.lblCurrentBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentBarcode.Location = new System.Drawing.Point(345, 82);
            this.lblCurrentBarcode.Name = "lblCurrentBarcode";
            this.lblCurrentBarcode.Size = new System.Drawing.Size(223, 18);
            this.lblCurrentBarcode.TabIndex = 15;
            this.lblCurrentBarcode.Text = "PA84-00176WMYFBU1I8T00097";
            this.lblCurrentBarcode.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(80)))), ((int)(((byte)(131)))));
            this.lblProgress.Location = new System.Drawing.Point(397, 105);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(77, 15);
            this.lblProgress.TabIndex = 13;
            this.lblProgress.Text = "(In Progress)";
            this.lblProgress.Visible = false;
            // 
            // lblTitleLot
            // 
            this.lblTitleLot.AutoSize = true;
            this.lblTitleLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleLot.Location = new System.Drawing.Point(315, 81);
            this.lblTitleLot.Name = "lblTitleLot";
            this.lblTitleLot.Size = new System.Drawing.Size(32, 18);
            this.lblTitleLot.TabIndex = 14;
            this.lblTitleLot.Text = "Lot";
            this.lblTitleLot.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(102, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "TOTAL LOT";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.circularProgressBar);
            this.groupBox5.Location = new System.Drawing.Point(312, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 195);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Achieved";
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 1000;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(45, 16);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.circularProgressBar.ProgressWidth = 19;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(166, 169);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 0;
            this.circularProgressBar.Text = "0%";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 68;
            // 
            // groupBoxTotalLot
            // 
            this.groupBoxTotalLot.Controls.Add(this.lblTotalLot);
            this.groupBoxTotalLot.Location = new System.Drawing.Point(54, 118);
            this.groupBoxTotalLot.Name = "groupBoxTotalLot";
            this.groupBoxTotalLot.Size = new System.Drawing.Size(239, 194);
            this.groupBoxTotalLot.TabIndex = 10;
            this.groupBoxTotalLot.TabStop = false;
            // 
            // lblTotalLot
            // 
            this.lblTotalLot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLot.AutoSize = true;
            this.lblTotalLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(80)))), ((int)(((byte)(131)))));
            this.lblTotalLot.Location = new System.Drawing.Point(89, 71);
            this.lblTotalLot.Name = "lblTotalLot";
            this.lblTotalLot.Size = new System.Drawing.Size(50, 54);
            this.lblTotalLot.TabIndex = 10;
            this.lblTotalLot.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Waittime,
            this.Overtime,
            this.Pressure,
            this.TimeVacuum,
            this.TempOrdinary,
            this.TimeStartLot,
            this.TimeEndLot,
            this.Vent,
            this.TemperatureWorking,
            this.Datetime});
            this.dataGridView1.Location = new System.Drawing.Point(58, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1294, 387);
            this.dataGridView1.TabIndex = 17;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Waittime
            // 
            this.Waittime.HeaderText = "Wait Time";
            this.Waittime.Name = "Waittime";
            this.Waittime.ReadOnly = true;
            // 
            // Overtime
            // 
            this.Overtime.HeaderText = "Overtime";
            this.Overtime.Name = "Overtime";
            this.Overtime.ReadOnly = true;
            // 
            // Pressure
            // 
            this.Pressure.HeaderText = "Pressure";
            this.Pressure.Name = "Pressure";
            this.Pressure.ReadOnly = true;
            // 
            // TimeVacuum
            // 
            this.TimeVacuum.HeaderText = "Time Vacuum";
            this.TimeVacuum.Name = "TimeVacuum";
            this.TimeVacuum.ReadOnly = true;
            // 
            // TempOrdinary
            // 
            this.TempOrdinary.HeaderText = "Temperature Ordinary (℃)";
            this.TempOrdinary.Name = "TempOrdinary";
            this.TempOrdinary.ReadOnly = true;
            // 
            // TimeStartLot
            // 
            this.TimeStartLot.HeaderText = "Time Start Lot";
            this.TimeStartLot.Name = "TimeStartLot";
            this.TimeStartLot.ReadOnly = true;
            // 
            // TimeEndLot
            // 
            this.TimeEndLot.HeaderText = "Time End Lot";
            this.TimeEndLot.Name = "TimeEndLot";
            this.TimeEndLot.ReadOnly = true;
            // 
            // Vent
            // 
            this.Vent.HeaderText = "Time Vent";
            this.Vent.Name = "Vent";
            this.Vent.ReadOnly = true;
            // 
            // TemperatureWorking
            // 
            this.TemperatureWorking.HeaderText = "Temperature Working";
            this.TemperatureWorking.Name = "TemperatureWorking";
            this.TemperatureWorking.ReadOnly = true;
            // 
            // Datetime
            // 
            this.Datetime.HeaderText = "Date Time";
            this.Datetime.Name = "Datetime";
            this.Datetime.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnSetting)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxTotalLot.ResumeLayout(false);
            this.groupBoxTotalLot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBtnSetting;
        private System.Windows.Forms.PictureBox picturePLC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnStartNewLot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCurrentBarcode;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblTitleLot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.GroupBox groupBoxTotalLot;
        private System.Windows.Forms.Label lblTotalLot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waittime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeVacuum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempOrdinary;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStartLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEndLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperatureWorking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datetime;
    }
}

