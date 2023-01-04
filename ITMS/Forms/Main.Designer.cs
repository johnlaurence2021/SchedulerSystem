namespace ITMS.Forms
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnStoAudio = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLog = new System.Windows.Forms.Label();
            this.testPlay = new System.Windows.Forms.Label();
            this.textAudio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.dgvScheduler = new System.Windows.Forms.DataGridView();
            this.EventDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeScheduler = new System.Windows.Forms.Timer(this.components);
            this.timerDisplay = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.schedIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audioFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 76);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 583);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.btnStoAudio);
            this.tabPage3.Controls.Add(this.btnPlay);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.btnStop);
            this.tabPage3.Controls.Add(this.btnRun);
            this.tabPage3.Controls.Add(this.btnDeleteEvent);
            this.tabPage3.Controls.Add(this.btnEditEvent);
            this.tabPage3.Controls.Add(this.btnNewEvent);
            this.tabPage3.Controls.Add(this.dgvScheduler);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tabPage3.Size = new System.Drawing.Size(913, 552);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Audio Scheduler";
            // 
            // btnStoAudio
            // 
            this.btnStoAudio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoAudio.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStoAudio.Location = new System.Drawing.Point(788, 404);
            this.btnStoAudio.Name = "btnStoAudio";
            this.btnStoAudio.Size = new System.Drawing.Size(106, 53);
            this.btnStoAudio.TabIndex = 18;
            this.btnStoAudio.Text = "Stop Audio";
            this.btnStoAudio.UseVisualStyleBackColor = true;
            this.btnStoAudio.Click += new System.EventHandler(this.btnStoAudio_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPlay.Location = new System.Drawing.Point(679, 404);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(103, 53);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.Text = "Play Audio";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TimeLog);
            this.groupBox1.Controls.Add(this.testPlay);
            this.groupBox1.Controls.Add(this.textAudio);
            this.groupBox1.Location = new System.Drawing.Point(20, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 70);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(204, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Audio File :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Time :";
            // 
            // TimeLog
            // 
            this.TimeLog.AutoSize = true;
            this.TimeLog.Font = new System.Drawing.Font("Gotham Narrow Book", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLog.ForeColor = System.Drawing.Color.DarkGreen;
            this.TimeLog.Location = new System.Drawing.Point(837, 0);
            this.TimeLog.Name = "TimeLog";
            this.TimeLog.Size = new System.Drawing.Size(28, 6);
            this.TimeLog.TabIndex = 8;
            this.TimeLog.Text = "eventTime";
            // 
            // testPlay
            // 
            this.testPlay.AutoSize = true;
            this.testPlay.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPlay.ForeColor = System.Drawing.Color.DarkGreen;
            this.testPlay.Location = new System.Drawing.Point(63, 34);
            this.testPlay.Name = "testPlay";
            this.testPlay.Size = new System.Drawing.Size(0, 17);
            this.testPlay.TabIndex = 14;
            // 
            // textAudio
            // 
            this.textAudio.AutoSize = true;
            this.textAudio.ForeColor = System.Drawing.Color.DarkGreen;
            this.textAudio.Location = new System.Drawing.Point(298, 34);
            this.textAudio.Name = "textAudio";
            this.textAudio.Size = new System.Drawing.Size(0, 18);
            this.textAudio.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblDisplayTime);
            this.panel1.Controls.Add(this.lblToday);
            this.panel1.Location = new System.Drawing.Point(679, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 76);
            this.panel1.TabIndex = 9;
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplayTime.Location = new System.Drawing.Point(35, 37);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(74, 24);
            this.lblDisplayTime.TabIndex = 21;
            this.lblDisplayTime.Text = "00:00";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Broadway", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblToday.Location = new System.Drawing.Point(59, 13);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(44, 20);
            this.lblToday.TabIndex = 20;
            this.lblToday.Text = "Day";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStop.Location = new System.Drawing.Point(787, 336);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 53);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop All";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRun.Location = new System.Drawing.Point(679, 336);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(103, 53);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run Schedule";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteEvent.Location = new System.Drawing.Point(679, 260);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(215, 53);
            this.btnDeleteEvent.TabIndex = 5;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEvent.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEditEvent.Location = new System.Drawing.Point(679, 186);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(215, 53);
            this.btnEditEvent.TabIndex = 4;
            this.btnEditEvent.Text = "Edit Event";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEvent.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNewEvent.Location = new System.Drawing.Point(679, 111);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(215, 53);
            this.btnNewEvent.TabIndex = 3;
            this.btnNewEvent.Text = "New Event";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // dgvScheduler
            // 
            this.dgvScheduler.AllowUserToAddRows = false;
            this.dgvScheduler.AllowUserToDeleteRows = false;
            this.dgvScheduler.AllowUserToResizeColumns = false;
            this.dgvScheduler.AllowUserToResizeRows = false;
            this.dgvScheduler.AutoGenerateColumns = false;
            this.dgvScheduler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvScheduler.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvScheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schedIDDataGridViewTextBoxColumn,
            this.eventTimeDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.EventDay,
            this.audioFileDataGridViewTextBoxColumn});
            this.dgvScheduler.DataSource = this.schedulerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScheduler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScheduler.Location = new System.Drawing.Point(20, 20);
            this.dgvScheduler.Name = "dgvScheduler";
            this.dgvScheduler.ReadOnly = true;
            this.dgvScheduler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvScheduler.RowHeadersVisible = false;
            this.dgvScheduler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvScheduler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScheduler.Size = new System.Drawing.Size(640, 437);
            this.dgvScheduler.TabIndex = 2;
            this.dgvScheduler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScheduler_CellClick);
            this.dgvScheduler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EventDay
            // 
            this.EventDay.DataPropertyName = "EventDay";
            this.EventDay.HeaderText = "Event Day";
            this.EventDay.Name = "EventDay";
            this.EventDay.ReadOnly = true;
            this.EventDay.Width = 99;
            // 
            // timeScheduler
            // 
            this.timeScheduler.Tick += new System.EventHandler(this.timeScheduler_Tick);
            // 
            // timerDisplay
            // 
            this.timerDisplay.Tick += new System.EventHandler(this.timerDisplay_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(335, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "AUDIO SCHEDULER SYSTEM";
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // schedIDDataGridViewTextBoxColumn
            // 
            this.schedIDDataGridViewTextBoxColumn.DataPropertyName = "SchedID";
            this.schedIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.schedIDDataGridViewTextBoxColumn.Name = "schedIDDataGridViewTextBoxColumn";
            this.schedIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.schedIDDataGridViewTextBoxColumn.Width = 47;
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "Event Time";
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            this.eventTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventTimeDataGridViewTextBoxColumn.Width = 108;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "Event Name";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            this.eventNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventNameDataGridViewTextBoxColumn.Width = 114;
            // 
            // audioFileDataGridViewTextBoxColumn
            // 
            this.audioFileDataGridViewTextBoxColumn.DataPropertyName = "AudioFile";
            this.audioFileDataGridViewTextBoxColumn.HeaderText = "Audio File";
            this.audioFileDataGridViewTextBoxColumn.Name = "audioFileDataGridViewTextBoxColumn";
            this.audioFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schedulerBindingSource
            // 
            this.schedulerBindingSource.DataSource = typeof(ITMS.Models.Scheduler);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvScheduler;
        private System.Windows.Forms.Label TimeLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.Timer timeScheduler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label testPlay;
        private System.Windows.Forms.Label textAudio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource schedulerBindingSource;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn monDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tueDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn wedDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn thuDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn friDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn satDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn sunDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Timer timerDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn audioFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Button btnStoAudio;
        private System.Windows.Forms.Button btnPlay;
    }
}